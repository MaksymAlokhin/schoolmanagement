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
    public class StudentsTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public StudentsTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("StudentsTestDatabase")
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
        public async Task Students_IndexModel_OnGetAsync_StudentsAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.IndexModel(context, config);
            var expectedStudents = context.Students;

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualStudents = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedStudents
                    .OrderBy(s => s.LastName)
                    .Take(PageSize).Select(s => s.LastName),
                actualStudents
                    .Select(s => s.LastName)
                );
        }
        [Fact]
        public async Task Students_IndexModel_OnGetAsync_StudentsAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.IndexModel(context, config);
            var expectedStudents = context.Students;

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualStudents = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedStudents
                    .OrderByDescending(s => s.LastName)
                    .Take(PageSize).Select(s => s.LastName),
                actualStudents
                    .Select(s => s.LastName)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("ов")]
        [InlineData("ам")]
        [InlineData("ко")]
        public async Task Students_IndexModel_OnGetAsync_FilteredListOfStudentsIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.IndexModel(context, config);
            IQueryable<Student> expectedStudents = context.Students;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedStudents = expectedStudents.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualStudents = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedStudents
                    .OrderBy(m => m.LastName)
                    .Take(PageSize).Select(m => m.LastName),
                actualStudents
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
        public async Task Students_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.IndexModel(context, config);
            List<Student> expectedStudents = new List<Student>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Students.Count() / (double)PageSize))
            {
                expectedStudents = context.Students
                    .OrderBy(m => m.LastName)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedStudents = context.Students
                    .OrderBy(m => m.LastName)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualStudents = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedStudents
                    .OrderBy(m => m.LastName)
                    .Take(PageSize).Select(m => m.LastName),
                actualStudents
                    .Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Students_CreateModel_OnPostAsync_StudentIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.CreateModel(context, null);
            var expectedStudent = new Student
            {
                Id = 133,
                LastName = "LastName",
                FirstName = "FirstName",
                Patronymic = "Patronymic",
                DateOfBirth = DateTime.Parse("2022-01-01"),
                Address = "Address",
                Gender = "Gender",
            };

            pageModel.Student = expectedStudent;
            // Act
            var result = await pageModel.OnPostAsync("Gender");

            // Assert
            var actualStudent = await context.Students
                .Where(c => c.Patronymic == "Patronymic")
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedStudents);
            //var object2Json = JsonSerializer.Serialize(actualStudent);
            Assert.Equal(expectedStudent.LastName, actualStudent.LastName);
            Assert.Equal(expectedStudent.FirstName, actualStudent.FirstName);
            Assert.Equal(expectedStudent.Patronymic, actualStudent.Patronymic);
            Assert.Equal(expectedStudent.DateOfBirth, actualStudent.DateOfBirth);
            Assert.Equal(expectedStudent.Address, actualStudent.Address);
            Assert.Equal(expectedStudent.Gender, actualStudent.Gender);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Students_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.CreateModel(context, null);
            var expectedStudent = new Student
            {
                LastName = "LastName",
                FirstName = "FirstName",
                Patronymic = "Patronymic",
                DateOfBirth = DateTime.Parse("2022-01-01"),
                Address = "Address",
                Gender = "Gender",
                ProfilePicture = "ProfilePicture.jpg"
            };
            pageModel.Student = expectedStudent;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync("Gender");

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Students_DeleteModel_OnGetAsync_StudentIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.DeleteModel(context, null);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Student>(pageModel.Student);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Белявський", model.LastName);
            Assert.Equal("Олег", model.FirstName);
            Assert.Equal("Владиславович", model.Patronymic);
        }
        [Fact]
        public async Task Student_DeleteModel_OnPostAsync_StudentIsDeleted_WhenStudentIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.DeleteModel(context, null);
            var testId = 1;
            var expectedStudents = context.Students.Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualStudents = await context.Students.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedStudents.OrderBy(m => m.Id).Select(m => m.LastName ),
                actualStudents.OrderBy(m => m.Id).Select(m => m.LastName));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Student_DeleteModel_OnPostAsync_NoStudentIsDeleted_WhenStudentIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.DeleteModel(context, null);
            var testId = 320;
            var expectedStudents = context.Students;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualStudents = await context.Students.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedStudents.OrderBy(m => m.Id).Select(m => m.LastName),
                actualStudents.OrderBy(m => m.Id).Select(m => m.LastName));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Student_EditModel_OnGetAsync_StudentIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.EditModel(context, null);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Student>(pageModel.Student);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Белявський", model.LastName);
            Assert.Equal("Олег", model.FirstName);
            Assert.Equal("Владиславович", model.Patronymic);
        }
        [Fact]
        public async Task Student_EditModel_OnPostAsync_StudentIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.EditModel(context, null);
            int testId = 1;
            var expectedStudent = context.Students.FirstOrDefault(m => m.Id == testId);
            pageModel.Student = expectedStudent;
            pageModel.Student.LastName = "Modified";

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId, "Gender");

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Student>(pageModel.Student);
            Assert.Equal("Modified", model.LastName);
            var actualStudent = context.Students.FirstOrDefault(m => m.Id == testId);
            Assert.Equal("Modified", actualStudent.LastName);
        }
        [Fact]
        public async Task Student_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.EditModel(context, null);
            int testId = 1;
            var expectedStudent = context.Students.FirstOrDefault(m => m.Id == testId);
            pageModel.Student = expectedStudent;
            pageModel.Student.LastName = "Modified";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null, testId, "Gender");

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Student_DetailsModel_OnGetAsync_StudentIsFetched_WhenStudentIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Student>(pageModel.Student);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Белявський", model.LastName);
            Assert.Equal("Олег", model.FirstName);
            Assert.Equal("Владиславович", model.Patronymic);
        }

        //DetailsModel
        [Fact]
        public async Task Student_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenStudentIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Students.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
