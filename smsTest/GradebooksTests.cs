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
    public class GradebooksTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public GradebooksTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("GradebooksTestDatabase")
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
        public async Task Gradebooks_IndexModel_OnGetAsync_GradebooksAreReturned()
        {
            // Arrange
            int gradeId = 1;
            int subjectId = 24;
            int year = 2021;
            int month = 9;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.IndexModel(context, config);
            var expectedListOfStudents = context.Students
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName);
            var expectedListOfGradebooks = context.Gradebooks
                .Include(g => g.Student)
                .Where(g => g.LessonDate.Month == month
                    && g.LessonDate.Year == year
                    && g.SubjectId == subjectId
                    && g.Student.GradeId == gradeId);

            // Act
            await pageModel.OnGetAsync(null, gradeId, subjectId, year, month);

            // Assert
            var actualListOfStudents = Assert.IsAssignableFrom<List<Student>>(pageModel.students);
            var actualListOfGradebooks = Assert.IsAssignableFrom<List<Gradebook>>(pageModel.gradebooks);
            Assert.Equal(expectedListOfStudents, actualListOfStudents);
            Assert.Equal(expectedListOfGradebooks, actualListOfGradebooks);
        }
        [Fact]
        public async Task Inventory_IndexModel_OnPostAsync_GradebookIsAdded()
        {
            // Arrange
            int studentId = 1;
            int day = 6;
            string mark = "12";
            int year = 2021;
            int month = 9;
            int gradeId = 1;
            int subjectId = 38;
            int teacherId = 28;
            int pageIndex = 1;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.IndexModel(context, config);

            // Act
            var result = await pageModel.OnPostAsync(year, month, day, gradeId, studentId, subjectId, mark, pageIndex);

            // Assert
            var actualGradebook = context.Gradebooks
                .Where(s => s.Mark == mark 
                    && s.StudentId == studentId
                    && s.SubjectId == subjectId
                    && s.TeacherId == teacherId)
                .FirstOrDefault();
            Assert.IsType<RedirectToPageResult>(result);
            Assert.NotNull(actualGradebook);
        }
        [Fact]
        public async Task Inventory_IndexModel_OnPostAsync_GradebookIsEdited()
        {
            // Arrange
            int studentId = 1;
            int day = 7;
            string mark = "12";
            int year = 2021;
            int month = 9;
            int gradeId = 1;
            int subjectId = 1;
            int teacherId = 2;
            int pageIndex = 1;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.IndexModel(context, config);

            // Act
            var result = await pageModel.OnPostAsync(year, month, day, gradeId, studentId, subjectId, mark, pageIndex);

            // Assert
            var actualGradebook = context.Gradebooks
                .Where(s => s.Mark == mark
                    && s.StudentId == studentId
                    && s.SubjectId == subjectId
                    && s.TeacherId == teacherId)
                .FirstOrDefault();
            Assert.IsType<RedirectToPageResult>(result);
            Assert.Equal(mark, actualGradebook.Mark);
        }
        [Fact]
        public async Task Inventory_IndexModel_OnPostAsync_GradebookIsDeleted()
        {
            // Arrange
            int studentId = 1;
            int day = 7;
            string mark = "4";
            int year = 2021;
            int month = 9;
            int gradeId = 1;
            int subjectId = 1;
            int teacherId = 2;
            int pageIndex = 1;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.IndexModel(context, config);

            // Act
            var result = await pageModel.OnPostAsync(year, month, day, gradeId, studentId, subjectId, null, pageIndex);

            // Assert
            var actualGradebook = context.Gradebooks
                .Where(s => s.StudentId == studentId
                    && s.SubjectId == subjectId
                    && s.TeacherId == teacherId
                    && s.LessonDate == new DateTime(year, month, day))
                .FirstOrDefault();
            Assert.IsType<RedirectToPageResult>(result);
            Assert.Null(actualGradebook);
        }

    }
}
