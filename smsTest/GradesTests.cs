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
    public class GradesTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public GradesTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("GradesTestDatabase")
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
        public async Task Grades_IndexModel_OnGetAsync_GradesAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.IndexModel(context, config);
            var expectedGrades = context.Grades;

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualGrades = Assert.IsAssignableFrom<PaginatedList<Grade>>(pageModel.Grade);
            Assert.Equal(
                expectedGrades
                    .OrderBy(m => m.Room)
                    .Take(PageSize).Select(m => m.Room),
                actualGrades
                    .OrderBy(m => m.Room)
                    .Select(m => m.Room)
                );
        }
        [Fact]
        public async Task Grades_IndexModel_OnGetAsync_GradesAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.IndexModel(context, config);
            var expectedGrades = context.Grades;

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualGrades = Assert.IsAssignableFrom<PaginatedList<Grade>>(pageModel.Grade);
            Assert.Equal(
                expectedGrades
                    .OrderByDescending(m => m.Room)
                    .Take(PageSize).Select(m => m.Room),
                actualGrades
                    .OrderByDescending(m => m.Room)
                    .Select(m => m.Room)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("À")]
        [InlineData("ß")]
        public async Task Grades_IndexModel_OnGetAsync_FilteredListOfGradesIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.IndexModel(context, config);
            IQueryable<Grade> expectedGrades = context.Grades;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedGrades = expectedGrades.Where(s => s.Number.ToString().Contains(searchString)
                                           || s.Letter.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualGrades = Assert.IsAssignableFrom<PaginatedList<Grade>>(pageModel.Grade);
            Assert.Equal(
                expectedGrades
                    .OrderBy(m => m.Room)
                    .Take(PageSize).Select(m => m.Room),
                actualGrades
                    .OrderBy(m => m.Room)
                    .Select(m => m.Room)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Grades_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.IndexModel(context, config);
            List<Grade> expectedGrades = new List<Grade>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Grades.Count() / (double)PageSize))
            {
                expectedGrades = context.Grades
                    .OrderBy(m => m.Room)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedGrades = context.Grades
                    .OrderBy(m => m.Room)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualGrades = Assert.IsAssignableFrom<PaginatedList<Grade>>(pageModel.Grade);
            Assert.Equal(
                expectedGrades
                    .OrderBy(m => m.Room)
                    .Take(PageSize).Select(m => m.Room),
                actualGrades
                    .OrderBy(m => m.Room)
                    .Select(m => m.Room)
                );
        }
        [Fact]
        public async Task Grades_CreateModel_OnPostAsync_GradeIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.CreateModel(context);
            var expectedGrades = new Grade
            {
                Id = 23,
                Number = 13,
                Letter = "ß",
                Room = "122"
            };
            pageModel.Grade = expectedGrades;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualGrade = await context.Grades
                .Where(c => c.Room == "122")
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedGrades);
            //var object2Json = JsonSerializer.Serialize(actualGrade);
            Assert.Equal(expectedGrades, actualGrade);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Grades_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.CreateModel(context);
            var expectedGrades = new Grade
            {
                Id = 23,
                Number = 13,
                Letter = "ß",
                Room = "122"
            };
            pageModel.Grade = expectedGrades;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Grades_DeleteModel_OnGetAsync_GradeIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Grade>(pageModel.Grade);
            Assert.Equal(testId, model.Id);
            Assert.Equal(1, model.Number);
            Assert.Equal("À", model.Letter);
            Assert.Equal("105", model.Room);
        }
        [Fact]
        public async Task Grades_DeleteModel_OnPostAsync_GradeIsDeleted_WhenGradeIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.DeleteModel(context);
            var testId = 1;
            var expectedGrades = context.Grades.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualGrades = await context.Grades.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedGrades.OrderBy(m => m.Id).Select(m => m.Room ),
                actualGrades.OrderBy(m => m.Id).Select(m => m.Room ));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Grades_DeleteModel_OnPostAsync_NoGradeIsDeleted_WhenGradeIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.DeleteModel(context);
            var testId = 320;
            var expectedGrades = context.Grades;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualGrades = await context.Grades.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedGrades.OrderBy(m => m.Id).Select(m => m.Room),
                actualGrades.OrderBy(m => m.Id).Select(m => m.Room));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Grades_EditModel_OnGetAsync_GradeIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.EditModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Grade>(pageModel.Grade);
            Assert.Equal(testId, model.Id);
            Assert.Equal(1, model.Number);
            Assert.Equal("À", model.Letter);
            Assert.Equal("105", model.Room);
        }
        [Fact]
        public async Task Grades_EditModel_OnPostAsync_GradeIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.EditModel(context);
            int testId = 1;
            var expectedGrade = context.Grades.FirstOrDefault(m => m.Id == testId);
            pageModel.Grade = expectedGrade;
            pageModel.Grade.Letter = "ß";

            // Act
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Grade>(pageModel.Grade);
            Assert.Equal("ß", model.Letter);
            var actualGrade = context.Grades.FirstOrDefault(m => m.Id == testId);
            Assert.Equal("ß", actualGrade.Letter);
        }
        [Fact]
        public async Task Grades_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.EditModel(context);
            int testId = 1;
            var expectedGrade = context.Grades.FirstOrDefault(m => m.Id == testId);
            pageModel.Grade = expectedGrade;
            pageModel.Grade.Letter = "ß";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Grades_DetailsModel_OnGetAsync_GradeIsFetched_WhenGradeIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Grade>(pageModel.Grade);
            Assert.Equal(testId, model.Id);
            Assert.Equal(1, model.Number);
            Assert.Equal("À", model.Letter);
            Assert.Equal("105", model.Room);
        }

        //DetailsModel
        [Fact]
        public async Task Grades_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenGradeIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Grades.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
