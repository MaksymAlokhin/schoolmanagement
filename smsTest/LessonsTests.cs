using System;
using Xunit;
using sms.Pages;
using sms.Data;
using sms.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sms;

namespace smsTest
{
    public class LessonsTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public LessonsTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("LessonsTestDatabase")
                    .Options;
            context = new ApplicationDbContext(contextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Seeder seeder = new Seeder(context);
        }
        public void Dispose()
        {
            context.Dispose();
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Lessons_IndexModel_OnGetAsync_LessonsAndTeachersAreReturned(int day)
        {
            // Arrange
            var logger = Mock.Of<Microsoft.Extensions.Logging.ILogger<sms.Pages.TimeTable.IndexModel>>();
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.IndexModel(context, logger);
            var expectedTeachers = await context.Teachers
                .OrderBy(i => i.LastName)
                .ToListAsync();
            var expectedLessons = await context.Lessons
                .Where(i => i.Day == day)
                .Include(i => i.Grade)
                .ToListAsync();

            // Act
            await pageModel.OnGetAsync(day);

            // Assert
            var actualLessons = Assert.IsAssignableFrom<List<Lesson>>(pageModel.lessons);
            var actualTeachers = Assert.IsAssignableFrom<List<Teacher>>(pageModel.teachers);
            Assert.Equal(expectedLessons, actualLessons);
            Assert.Equal(expectedTeachers, actualTeachers);
        }
        [Fact]
        public async Task Lessons_CreateModel_OnPostAsync_LessonIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.CreateModel(context);
            var expectedLessons = new Lesson
            {
                Id = 606,
                Day = 1,
                Slot = 1,
                Room = "209",
                GradeId = 1,
                SubjectId = 14,
                TeacherId = 12
            };
            pageModel.Lesson = expectedLessons;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualLesson = await context.Lessons
                .Where(c => c.Id == 606)
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedLessons);
            //var object2Json = JsonSerializer.Serialize(actualLesson);
            Assert.Equal(expectedLessons.Room, actualLesson.Room);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Lessons_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.CreateModel(context);
            var expectedLessons = new Lesson
            {
                Id = 606,
                Day = 1,
                Slot = 1,
                Room = "209",
                GradeId = 1,
                SubjectId = 14,
                TeacherId = 12
            };
            pageModel.Lesson = expectedLessons;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Lessons_DeleteModel_OnGetAsync_LessonIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Lesson>(pageModel.Lesson);
            Assert.Equal(testId, model.Id);
            Assert.Equal(1, model.Day);
            Assert.Equal(1, model.Slot);
            Assert.Equal("209", model.Room);
            Assert.Equal(13, model.GradeId);
            Assert.Equal(12, model.SubjectId);
            Assert.Equal(12, model.TeacherId);
        }
        [Fact]
        public async Task Lesson_DeleteModel_OnPostAsync_LessonIsDeleted_WhenLessonIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.DeleteModel(context);
            var testId = 1;
            var expectedLessons = context.Lessons.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(testId);

            // Assert
            var actualLessons = await context.Lessons.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedLessons.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId} ),
                actualLessons.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId}));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Lesson_DeleteModel_OnPostAsync_NoLessonIsDeleted_WhenLessonIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.DeleteModel(context);
            var testId = 880;
            var expectedLessons = context.Lessons;

            // Act
            var result = await pageModel.OnPostAsync(testId);

            // Assert
            var actualLessons = await context.Lessons.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedLessons.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualLessons.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Lesson_EditModel_OnGetAsync_LessonIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.EditModel(context);
            int teacherId = 12;
            int day = 1;
            int slot = 1;
            // Act
            var result = await pageModel.OnGetAsync(day, slot, teacherId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Lesson>(pageModel.Lesson);
            Assert.Equal(12, model.TeacherId);
            Assert.Equal(1, model.Day);
            Assert.Equal(1, model.Slot);
        }
        [Fact]
        public async Task Lesson_EditModel_OnPostAsync_LessonIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.EditModel(context);
            int testId = 1;
            var expectedLesson = context.Lessons.FirstOrDefault(m => m.Id == testId);
            pageModel.Lesson = expectedLesson;
            pageModel.Lesson.Room = "335";

            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Lesson>(pageModel.Lesson);
            Assert.Equal("335", model.Room);
            var actualLesson = context.Lessons.FirstOrDefault(m => m.Id == testId);
            Assert.Equal("335", actualLesson.Room);
        }
        [Fact]
        public async Task Lesson_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.EditModel(context);
            int testId = 1;
            var expectedLesson = context.Lessons.FirstOrDefault(m => m.Id == testId);
            pageModel.Lesson = expectedLesson;
            pageModel.Lesson.Room = "335";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Lesson_StudentsTTModel_OnGetAsync_LessonsAreReturned(int gradeId)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.TimeTable.StudentsTTModel(context);
            var expectedLessons = await context.Lessons
                .Where(l => l.GradeId == gradeId)
                .Include(l => l.Grade)
                .Include(l => l.Subject)
                .ToListAsync();
            // Act
            await pageModel.OnGetAsync(gradeId);

            // Assert
            var actualLessons = Assert.IsAssignableFrom<List<Lesson>>(pageModel.lessons);
            Assert.Equal(expectedLessons, actualLessons);
        }
    }
}
