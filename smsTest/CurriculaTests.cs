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
            var actualCurricula = Assert.IsAssignableFrom<List<Curriculum>>(pageModel.Curriculum);
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
    }
}
