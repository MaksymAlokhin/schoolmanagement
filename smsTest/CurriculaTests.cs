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
    public class CurriculaTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public CurriculaTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("CurriculaTestDatabase")
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
        public async Task Curricula_IndexModel_OnGetAsync_CurriculaAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.IndexModel(context, config);
            var expectedCurricula = context.Curricula;

            // Act
            await pageModel.OnGetAsync(null, null, null, null, 1);

            // Assert
            var actualCurricula = Assert.IsAssignableFrom<PaginatedList<Curriculum>>(pageModel.Curriculum);
            Assert.Equal(
                expectedCurricula
                    .Where(m => m.GradeId == 1)
                    .OrderBy(m => m.Subject.Name)
                    .Take(PageSize).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualCurricula
                    .OrderBy(m => m.Subject.Name)
                    .Select(m => new { m.GradeId, m.SubjectId, m.TeacherId })
                );
        }
        [Fact]
        public async Task Curricula_IndexModel_OnGetAsync_CurriculaAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.IndexModel(context, config);
            var expectedCurricula = context.Curricula;

            // Act
            await pageModel.OnGetAsync("subj_desc", null, null, null, 1);

            // Assert
            var actualCurricula = Assert.IsAssignableFrom<PaginatedList<Curriculum>>(pageModel.Curriculum);
            Assert.Equal(
                expectedCurricula
                    .Where(m => m.GradeId == 1)
                    .OrderByDescending(m => m.Subject.Name)
                    .Take(PageSize).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualCurricula
                    .OrderByDescending(m => m.Subject.Name)
                    .Select(m => new { m.GradeId, m.SubjectId, m.TeacherId })
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("יסü")]
        [InlineData("צע")]
        [InlineData("נא")]
        public async Task Curricula_IndexModel_OnGetAsync_FilteredListOfCurriculaIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.IndexModel(context, config);
            IQueryable<Curriculum> expectedCurricula = context.Curricula;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedCurricula = expectedCurricula.Where(s => s.Teacher.LastName.Contains(searchString)
                                           || s.Teacher.FirstName.Contains(searchString)
                                           || s.Teacher.Patronymic.Contains(searchString)
                                           || s.Subject.Name.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null, 1);

            // Assert
            var actualCurricula = Assert.IsAssignableFrom<PaginatedList<Curriculum>>(pageModel.Curriculum);
            Assert.Equal(
                expectedCurricula
                    .Where(m => m.GradeId == 1)
                    .OrderBy(m => m.Subject.Name)
                    .Take(PageSize).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualCurricula
                    .OrderBy(m => m.Subject.Name)
                    .Select(m => new { m.GradeId, m.SubjectId, m.TeacherId })
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Curricula_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.IndexModel(context, config);
            List<Curriculum> expectedCurricula = new List<Curriculum>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Curricula.Where(m => m.GradeId == 1).Count() / (double)PageSize))
            {
                expectedCurricula = context.Curricula
                    .Where(m => m.GradeId == 1)
                    .OrderBy(m => m.Subject.Name)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedCurricula = context.Curricula
                    .Where(m => m.GradeId == 1)
                    .OrderBy(m => m.Subject.Name)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex, 1);

            // Assert
            var actualCurricula = Assert.IsAssignableFrom<PaginatedList<Curriculum>>(pageModel.Curriculum);
            Assert.Equal(
                expectedCurricula
                    .Where(m => m.GradeId == 1)
                    .OrderBy(m => m.Subject.Name)
                    .Take(PageSize).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualCurricula
                    .OrderBy(m => m.Subject.Name)
                    .Select(m => new { m.GradeId, m.SubjectId, m.TeacherId })
                );
        }
        [Fact]
        public async Task Curricula_CreateModel_OnPostAsync_CurriculumIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.CreateModel(context);
            var expectedCurricula = new Curriculum
            {
                Id = 315,
                Quantity = 1,
                GradeId = 1,
                SubjectId = 14,
                TeacherId = 12
            };
            pageModel.Curriculum = expectedCurricula;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualCurriculum = await context.Curricula
                .Where(c => c.Quantity == 1 && c.GradeId == 1 && c.SubjectId == 14 && c.TeacherId == 12)
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedCurricula);
            //var object2Json = JsonSerializer.Serialize(actualCurriculum);
            Assert.Equal(expectedCurricula, actualCurriculum);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Curricula_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.CreateModel(context);
            var expectedCurricula = new Curriculum
            {
                Id = 315,
                Quantity = 1,
                GradeId = 1,
                SubjectId = 14,
                TeacherId = 12
            };
            pageModel.Curriculum = expectedCurricula;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Curricula_DeleteModel_OnGetAsync_CurriculumIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Curriculum>(pageModel.Curriculum);
            Assert.Equal(testId, model.Id);
            Assert.Equal(2, model.Quantity);
            Assert.Equal(1, model.GradeId);
            Assert.Equal(1, model.SubjectId);
            Assert.Equal(2, model.TeacherId);
        }
        [Fact]
        public async Task Curriculum_DeleteModel_OnPostAsync_CurriculumIsDeleted_WhenCurriculumIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.DeleteModel(context);
            var testId = 1;
            var expectedCurricula = context.Curricula.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualCurricula = await context.Curricula.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedCurricula.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId } ),
                actualCurricula.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId } ));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Curriculum_DeleteModel_OnPostAsync_NoCurriculumIsDeleted_WhenCurriculumIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.DeleteModel(context);
            var testId = 320;
            var expectedCurricula = context.Curricula;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualCurricula = await context.Curricula.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedCurricula.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }),
                actualCurricula.OrderBy(m => m.Id).Select(m => new { m.GradeId, m.SubjectId, m.TeacherId }));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Curriculum_EditModel_OnGetAsync_CurriculumIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.EditModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Curriculum>(pageModel.Curriculum);
            Assert.Equal(testId, model.Id);
            Assert.Equal(2, model.Quantity);
            Assert.Equal(1, model.GradeId);
            Assert.Equal(1, model.SubjectId);
            Assert.Equal(2, model.TeacherId);
        }
        [Fact]
        public async Task Curriculum_EditModel_OnPostAsync_CurriculumIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.EditModel(context);
            int testId = 1;
            var expectedCurriculum = context.Curricula.FirstOrDefault(m => m.Id == testId);
            pageModel.Curriculum = expectedCurriculum;
            pageModel.Curriculum.Quantity = 33;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Curriculum>(pageModel.Curriculum);
            Assert.Equal(33, model.Quantity);
            var actualCurriculum = context.Curricula.FirstOrDefault(m => m.Id == testId);
            Assert.Equal(33, actualCurriculum.Quantity);
        }
        [Fact]
        public async Task Curriculum_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.EditModel(context);
            int testId = 1;
            var expectedCurriculum = context.Curricula.FirstOrDefault(m => m.Id == testId);
            pageModel.Curriculum = expectedCurriculum;
            pageModel.Curriculum.Quantity = 33;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Curriculum_DetailsModel_OnGetAsync_CurriculumIsFetched_WhenCurriculumIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Curriculum>(pageModel.Curriculum);
            Assert.Equal(testId, model.Id);
            Assert.Equal(2, model.Quantity);
            Assert.Equal(1, model.GradeId);
            Assert.Equal(1, model.SubjectId);
            Assert.Equal(2, model.TeacherId);
        }

        //DetailsModel
        [Fact]
        public async Task Curriculum_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenCurriculumIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Curricula.DetailsModel(context);
            int testId = 320;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
