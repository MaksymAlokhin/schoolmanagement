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
    public class SubjectsTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public SubjectsTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("SubjectsTestDatabase")
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
        public async Task Subjects_IndexModel_OnGetAsync_SubjectsAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.IndexModel(context, config);
            var expectedSubjects = context.Subjects;

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualSubjects = Assert.IsAssignableFrom<PaginatedList<Subject>>(pageModel.Subject);
            Assert.Equal(
                expectedSubjects
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualSubjects
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Subjects_IndexModel_OnGetAsync_SubjectsAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.IndexModel(context, config);
            var expectedSubjects = context.Subjects;

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualSubjects = Assert.IsAssignableFrom<PaginatedList<Subject>>(pageModel.Subject);
            Assert.Equal(
                expectedSubjects
                    .OrderByDescending(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualSubjects
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("ія")]
        [InlineData("те")]
        [InlineData("ра")]
        public async Task Subjects_IndexModel_OnGetAsync_FilteredListOfSubjectsIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.IndexModel(context, config);
            IQueryable<Subject> expectedSubjects = context.Subjects;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedSubjects = expectedSubjects.Where(s => s.Name.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualSubjects = Assert.IsAssignableFrom<PaginatedList<Subject>>(pageModel.Subject);
            Assert.Equal(
                expectedSubjects
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualSubjects
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Subjects_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.IndexModel(context, config);
            List<Subject> expectedSubjects = new List<Subject>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Subjects.Count() / (double)PageSize))
            {
                expectedSubjects = context.Subjects
                    .OrderBy(m => m.Name)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedSubjects = context.Subjects
                    .OrderBy(m => m.Name)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualSubjects = Assert.IsAssignableFrom<PaginatedList<Subject>>(pageModel.Subject);
            Assert.Equal(
                expectedSubjects
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualSubjects
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Subjects_CreateModel_OnPostAsync_SubjectIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.CreateModel(context);
            var expectedSubjects = new Subject
            {
                Id = 42,
                Name = "New Subject"
            };
            pageModel.Subject = expectedSubjects;
            // Act
            var result = await pageModel.OnPostAsync(null);

            // Assert
            var actualSubject = await context.Subjects
                .Where(c => c.Name == "New Subject")
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedSubjects);
            //var object2Json = JsonSerializer.Serialize(actualSubject);
            Assert.Equal(expectedSubjects.Name, actualSubject.Name);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Subjects_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.CreateModel(context);
            var expectedSubjects = new Subject
            {
                Id = 42,
                Name = "New Subject",
            };
            pageModel.Subject = expectedSubjects;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Subjects_DeleteModel_OnGetAsync_SubjectIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Subject>(pageModel.Subject);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Англійська мова", model.Name);
        }
        [Fact]
        public async Task Subjects_DeleteModel_OnPostAsync_SubjectIsDeleted_WhenSubjectIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.DeleteModel(context);
            var testId = 1;
            var expectedSubjects = context.Subjects.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualSubjects = await context.Subjects.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedSubjects.OrderBy(m => m.Id).Select(m => m.Name ),
                actualSubjects.OrderBy(m => m.Id).Select(m => m.Name ));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Subjects_DeleteModel_OnPostAsync_NoSubjectIsDeleted_WhenSubjectIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.DeleteModel(context);
            var testId = 320;
            var expectedSubjects = context.Subjects;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualSubjects = await context.Subjects.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedSubjects.OrderBy(m => m.Id).Select(m => m.Name),
                actualSubjects.OrderBy(m => m.Id).Select(m => m.Name));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Subjects_EditModel_OnGetAsync_SubjectIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.EditModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Subject>(pageModel.Subject);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Англійська мова", model.Name);
        }
        [Fact]
        public async Task Subjects_EditModel_OnPostAsync_SubjectIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.EditModel(context);
            int testId = 1;
            var expectedSubject = context.Subjects.FirstOrDefault(m => m.Id == testId);
            pageModel.Subject = expectedSubject;
            pageModel.Subject.Name = "Modified Subject";

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Subject>(pageModel.Subject);
            Assert.Equal("Modified Subject", model.Name);
            var actualSubject = context.Subjects.FirstOrDefault(m => m.Id == testId);
            Assert.Equal("Modified Subject", actualSubject.Name);
        }
        [Fact]
        public async Task Subjects_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.EditModel(context);
            int testId = 1;
            var expectedSubject = context.Subjects.FirstOrDefault(m => m.Id == testId);
            pageModel.Subject = expectedSubject;
            pageModel.Subject.Name = "Modified Subject";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null, testId, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Subjects_DetailsModel_OnGetAsync_SubjectIsFetched_WhenSubjectIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Subject>(pageModel.Subject);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Англійська мова", model.Name);
        }

        //DetailsModel
        [Fact]
        public async Task Subjects_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenSubjectIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Subjects.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
