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
    public class TeachersTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public TeachersTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("TeachersTestDatabase")
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

        [Fact]
        public async Task Teachers_IndexModel_OnGetAsync_TeachersAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.IndexModel(context, config);
            var expectedTeachers = context.Teachers;

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualTeachers = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedTeachers
                    .OrderBy(s => s.LastName)
                    .Take(PageSize).Select(s => s.LastName),
                actualTeachers
                    .Select(s => s.LastName)
                );
        }
        [Fact]
        public async Task Teachers_IndexModel_OnGetAsync_TeachersAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.IndexModel(context, config);
            var expectedTeachers = context.Teachers;

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualTeachers = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedTeachers
                    .OrderByDescending(s => s.LastName)
                    .Take(PageSize).Select(s => s.LastName),
                actualTeachers
                    .Select(s => s.LastName)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("ов")]
        [InlineData("ам")]
        [InlineData("ко")]
        public async Task Teachers_IndexModel_OnGetAsync_FilteredListOfTeachersIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.IndexModel(context, config);
            IQueryable<Teacher> expectedTeachers = context.Teachers;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedTeachers = expectedTeachers.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualTeachers = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedTeachers
                    .OrderBy(m => m.LastName)
                    .Take(PageSize).Select(m => m.LastName),
                actualTeachers
                    .Select(m => m.LastName)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Teachers_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.IndexModel(context, config);
            List<Teacher> expectedTeachers = new List<Teacher>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Teachers.Count() / (double)PageSize))
            {
                expectedTeachers = context.Teachers
                    .OrderBy(m => m.LastName)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedTeachers = context.Teachers
                    .OrderBy(m => m.LastName)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualTeachers = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedTeachers
                    .OrderBy(m => m.LastName)
                    .Take(PageSize).Select(m => m.LastName),
                actualTeachers
                    .Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Teachers_CreateModel_OnPostAsync_TeacherIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.CreateModel(context, null);
            var expectedTeacher = new Teacher
            {
                Id = 133,
                LastName = "LastName",
                FirstName = "FirstName",
                Patronymic = "Patronymic",
            };

            pageModel.Teacher = expectedTeacher;
            // Act
            var result = await pageModel.OnPostAsync(null);

            // Assert
            var actualTeacher = await context.Teachers
                .Where(c => c.Patronymic == "Patronymic")
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedTeachers);
            //var object2Json = JsonSerializer.Serialize(actualTeacher);
            Assert.Equal(expectedTeacher.LastName, actualTeacher.LastName);
            Assert.Equal(expectedTeacher.FirstName, actualTeacher.FirstName);
            Assert.Equal(expectedTeacher.Patronymic, actualTeacher.Patronymic);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Teachers_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.CreateModel(context, null);
            var expectedTeacher = new Teacher
            {
                LastName = "LastName",
                FirstName = "FirstName",
                Patronymic = "Patronymic",
            };
            pageModel.Teacher = expectedTeacher;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Teachers_DeleteModel_OnGetAsync_TeacherIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.DeleteModel(context, null);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Teacher>(pageModel.Teacher);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Лісічкіна", model.LastName);
            Assert.Equal("Світлана", model.FirstName);
            Assert.Equal("Миколаївна", model.Patronymic);
        }
        [Fact]
        public async Task Teachers_DeleteModel_OnPostAsync_TeacherIsDeleted_WhenTeacherIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.DeleteModel(context, null);
            var testId = 1;
            var expectedTeachers = context.Teachers.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualTeachers = await context.Teachers.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedTeachers.OrderBy(m => m.Id).Select(m => m.LastName ),
                actualTeachers.OrderBy(m => m.Id).Select(m => m.LastName));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Teachers_DeleteModel_OnPostAsync_NoTeacherIsDeleted_WhenTeacherIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.DeleteModel(context, null);
            var testId = 320;
            var expectedTeachers = context.Teachers;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualTeachers = await context.Teachers.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedTeachers.OrderBy(m => m.Id).Select(m => m.LastName),
                actualTeachers.OrderBy(m => m.Id).Select(m => m.LastName));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Teachers_EditModel_OnGetAsync_TeacherIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.EditModel(context, null);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Teacher>(pageModel.Teacher);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Лісічкіна", model.LastName);
            Assert.Equal("Світлана", model.FirstName);
            Assert.Equal("Миколаївна", model.Patronymic);
        }
        [Fact]
        public async Task Teachers_EditModel_OnPostAsync_TeacherIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.EditModel(context, null);
            int testId = 1;
            var expectedTeacher = context.Teachers.FirstOrDefault(m => m.Id == testId);
            pageModel.Teacher = expectedTeacher;
            pageModel.Teacher.LastName = "Modified";

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Teacher>(pageModel.Teacher);
            Assert.Equal("Modified", model.LastName);
            var actualTeacher = context.Teachers.FirstOrDefault(m => m.Id == testId);
            Assert.Equal("Modified", actualTeacher.LastName);
        }
        [Fact]
        public async Task Teachers_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.EditModel(context, null);
            int testId = 1;
            var expectedTeacher = context.Teachers.FirstOrDefault(m => m.Id == testId);
            pageModel.Teacher = expectedTeacher;
            pageModel.Teacher.LastName = "Modified";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null, testId, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Teachers_DetailsModel_OnGetAsync_TeacherIsFetched_WhenTeacherIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Teacher>(pageModel.Teacher);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Лісічкіна", model.LastName);
            Assert.Equal("Світлана", model.FirstName);
            Assert.Equal("Миколаївна", model.Patronymic);
        }

        //DetailsModel
        [Fact]
        public async Task Teachers_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenTeacherIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Teachers.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
