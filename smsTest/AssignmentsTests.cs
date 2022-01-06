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
    public class AssignmentsTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public AssignmentsTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("AssignmentsTestDatabase")
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
        public async Task Assignments_IndexModel_OnGetAsync_AssignmentsAreReturned()
        {
            // Arrange
            int gradeId = 12;
            int subjectId = 4;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.IndexModel(context, config);
            var expectedAssignments = context.Assignments
                    .Where(a => a.GradeId == gradeId && a.SubjectId == subjectId);

            // Act
            await pageModel.OnGetAsync(null, "date", gradeId, subjectId);

            // Assert
            var actualAssignments = Assert.IsAssignableFrom<PaginatedList<Assignment>>(pageModel.Assignment);
            Assert.Equal(
                expectedAssignments
                    .OrderBy(s => s.DateOfPost)
                    .Take(PageSize).Select(s => s.DateOfPost),
                actualAssignments
                    .Select(s => s.DateOfPost)
                );
        }
        [Fact]
        public async Task Assignments_IndexModel_OnGetAsync_AssignmentsAreReturnedInDescendingOrder()
        {
            // Arrange
            int gradeId = 12;
            int subjectId = 4;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.IndexModel(context, config);
            var expectedAssignments = context.Assignments
                    .Where(a => a.GradeId == gradeId && a.SubjectId == subjectId);

            // Act
            await pageModel.OnGetAsync(null, null, gradeId, subjectId);

            // Assert
            var actualAssignments = Assert.IsAssignableFrom<PaginatedList<Assignment>>(pageModel.Assignment);
            Assert.Equal(
                expectedAssignments
                    .OrderByDescending(s => s.DateOfPost)
                    .Take(PageSize).Select(s => s.DateOfPost),
                actualAssignments
                    .Select(s => s.DateOfPost)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Assignments_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            int gradeId = 9;
            int subjectId = 19;
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.IndexModel(context, config);
            var expectedAssignments = context.Assignments
                    .Where(a => a.GradeId == gradeId && a.SubjectId == subjectId);
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Assignments.Count() / (double)PageSize))
            {
                expectedAssignments = expectedAssignments
                    .OrderByDescending(m => m.DateOfPost)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize);
            }
            else
            {
                expectedAssignments = expectedAssignments
                    .OrderByDescending(m => m.DateOfPost)
                    .Take(PageSize);
            }

            // Act
            await pageModel.OnGetAsync(pageIndex, null, gradeId, subjectId);

            // Assert
            var actualAssignments = Assert.IsAssignableFrom<PaginatedList<Assignment>>(pageModel.Assignment);
            Assert.Equal(
                expectedAssignments.Select(s => s.DateOfPost),
                actualAssignments.Select(s => s.DateOfPost)
                );
        }
        [Fact]
        public async Task Assignments_CreateModel_OnPostAsync_AssignmentIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.CreateModel(context);
            var expectedAssignment = new Assignment
            {
                Id = 5,
                Post = "New Assignment. Due tomorrow",
                DateOfPost = new DateTime(2022, 1, 5),
                GradeId = 1,
                SubjectId = 1,
                TeacherId = 1
            };
            pageModel.Assignment = expectedAssignment;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualAssignment = await context.Assignments
                .Where(c => c.DateOfPost == new DateTime(2022, 1, 5))
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedAssignments);
            //var object2Json = JsonSerializer.Serialize(actualAssignment);
            Assert.Equal(expectedAssignment, actualAssignment);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Assignments_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.CreateModel(context);
            var expectedAssignment = new Assignment
            {
                Id = 5,
                Post = "New Assignment. Due tomorrow",
                DateOfPost = new DateTime(2022, 1, 5),
                GradeId = 1,
                SubjectId = 1,
                TeacherId = 1
            };
            pageModel.Assignment = expectedAssignment;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Assignments_DeleteModel_OnGetAsync_AssignmentIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Assignment>(pageModel.Assignment);
            Assert.Equal(testId, model.Id);
            Assert.Equal(9, model.GradeId);
            Assert.Equal(19, model.SubjectId);
            Assert.Equal(17, model.TeacherId);
        }
        [Fact]
        public async Task Assignment_DeleteModel_OnPostAsync_AssignmentIsDeleted_WhenAssignmentIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.DeleteModel(context);
            var testId = 1;
            var expectedAssignments = context.Assignments.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, testId);

            // Assert
            var actualAssignments = await context.Assignments.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedAssignments.Select(m => m.DateOfPost),
                actualAssignments.Select(m => m.DateOfPost));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Assignment_DeleteModel_OnPostAsync_NoAssignmentIsDeleted_WhenAssignmentIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.DeleteModel(context);
            var testId = 320;
            var expectedAssignments = context.Assignments.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, testId);

            // Assert
            var actualAssignments = await context.Assignments.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedAssignments.OrderByDescending(s => s.DateOfPost).Select(m => m.DateOfPost),
                actualAssignments.OrderByDescending(s => s.DateOfPost).Select(m => m.DateOfPost));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Assignment_EditModel_OnGetAsync_AssignmentIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.EditModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Assignment>(pageModel.Assignment);
            Assert.Equal(testId, model.Id);
            Assert.Equal(9, model.GradeId);
            Assert.Equal(19, model.SubjectId);
            Assert.Equal(17, model.TeacherId);
        }
        [Fact]
        public async Task Assignment_EditModel_OnPostAsync_AssignmentIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.EditModel(context);
            int testId = 1;
            var expectedAssignment = context.Assignments.FirstOrDefault(m => m.Id == testId);
            pageModel.Assignment = expectedAssignment;
            pageModel.Assignment.DateOfPost = new DateTime(2022, 1, 5);

            // Act
            var result = await pageModel.OnPostAsync(null, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Assignment>(pageModel.Assignment);
            Assert.Equal(new DateTime(2022, 1, 5), model.DateOfPost);
            var actualAssignment = context.Assignments.FirstOrDefault(m => m.Id == testId);
            Assert.Equal(new DateTime(2022, 1, 5), actualAssignment.DateOfPost);

        }
        [Fact]
        public async Task Assignment_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.EditModel(context);
            int testId = 1;
            var expectedAssignment = context.Assignments.FirstOrDefault(m => m.Id == testId);
            pageModel.Assignment = expectedAssignment;
            pageModel.Assignment.DateOfPost = new DateTime(2022, 1, 5);

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Assignment_DetailsModel_OnGetAsync_AssignmentIsFetched_WhenAssignmentIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Assignment>(pageModel.Assignment);
            Assert.Equal(testId, model.Id);
            Assert.Equal(9, model.GradeId);
            Assert.Equal(19, model.SubjectId);
            Assert.Equal(17, model.TeacherId);
        }

        //DetailsModel
        [Fact]
        public async Task Assignment_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenAssignmentIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Remote.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
