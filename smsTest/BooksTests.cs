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
using sms.Pages.Library;

namespace smsTest
{
    public class BooksTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public BooksTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("BooksTestDatabase")
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
        public async Task Books_IndexModel_OnGetAsync_BooksAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.IndexModel(context, config);
            var expectedBooks = context.Books;

            // Act
            await pageModel.OnGetAsync(null, null, null, null, null);

            // Assert
            var actualBooks = Assert.IsAssignableFrom<PaginatedList<Book>>(pageModel.Book);
            Assert.Equal(
                expectedBooks
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
                    .Take(PageSize).Select(m => m.Name),
                actualBooks
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Books_IndexModel_OnGetAsync_BooksAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.IndexModel(context, config);
            var expectedBooks = context.Books;

            // Act
            await pageModel.OnGetAsync(null, "name_desc", null, null, null);

            // Assert
            var actualBooks = Assert.IsAssignableFrom<PaginatedList<Book>>(pageModel.Book);
            Assert.Equal(
                expectedBooks
                    .OrderByDescending(m => m.Name).ThenByDescending(s => s.Grade).ThenByDescending(s => s.Year)
                    .Take(PageSize).Select(m => m.Name),
                actualBooks
                    .OrderByDescending(m => m.Name).ThenByDescending(s => s.Grade).ThenByDescending(s => s.Year)
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("Фі")]
        [InlineData("од")]
        [InlineData("лі")]
        public async Task Books_IndexModel_OnGetAsync_FilteredListOfBooksIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.IndexModel(context, config);
            IQueryable<Book> expectedBooks = context.Books;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedBooks = expectedBooks.Where(s => s.Name.Contains(searchString)
                                       || s.Author.Contains(searchString)
                                       || s.PublishingHouse.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null, null);

            // Assert
            var actualBooks = Assert.IsAssignableFrom<PaginatedList<Book>>(pageModel.Book);
            Assert.Equal(
                expectedBooks
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
                    .Take(PageSize).Select(m => m.Name),
                actualBooks
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
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
        public async Task Books_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.IndexModel(context, config);
            List<Book> expectedBooks = new List<Book>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Books.Count() / (double)PageSize))
            {
                expectedBooks = context.Books
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedBooks = context.Books
                    .OrderBy(s => s.Grade).ThenBy(s => s.Name).ThenBy(s => s.Year)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, null, pageIndex);

            // Assert
            var actualBooks = Assert.IsAssignableFrom<PaginatedList<Book>>(pageModel.Book);
            Assert.Equal(
                expectedBooks
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualBooks
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Books_CreateModel_OnPostAsync_BookIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.CreateModel(context);
            var expectedBooks = new Book
            {
                Id = 182,
                Year = 2022,
                Qty = 30
            };
            pageModel.Book = expectedBooks;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualBook = await context.Books
                .Where(c => c.Year == 2022)
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedBooks);
            //var object2Json = JsonSerializer.Serialize(actualBook);
            Assert.Equal(expectedBooks, actualBook);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Books_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.CreateModel(context);
            var expectedBooks = new Book
            {
                Id = 182,
                Year = 2022,
                Qty = 30
            };
            pageModel.Book = expectedBooks;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Books_DeleteModel_OnGetAsync_BookIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.DeleteModel(context);
            var bookId = 1;

            // Act
            var result = await pageModel.OnGetAsync(bookId, null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Book>(pageModel.Book);
            Assert.Equal(bookId, model.Id);
            Assert.Equal("Карп'юк О.Д.", model.Author);
            Assert.Equal("Карп'юк О.Д.", model.Author);
            Assert.Equal("Англійська мова", model.Name);
            Assert.Equal("Астон", model.PublishingHouse);
            Assert.Equal(2018, model.Year);
            Assert.Equal(1, model.Grade);
            Assert.Equal(54, model.Qty);
        }
        [Fact]
        public async Task Book_DeleteModel_OnPostAsync_BookIsDeleted_WhenBookIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.DeleteModel(context);
            var bookId = 1;
            var expectedBooks = context.Books.Where(c => c.Id != bookId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(bookId, null, null, null);

            // Assert
            var actualBooks = await context.Books.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedBooks.OrderBy(m => m.Id).Select(m => m.Name),
                actualBooks.OrderBy(m => m.Id).Select(m => m.Name));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Book_DeleteModel_OnPostAsync_NoBookIsDeleted_WhenBookIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.DeleteModel(context);
            var bookId = 320;
            var expectedBooks = context.Books;

            // Act
            var result = await pageModel.OnPostAsync(bookId, null, null, null);

            // Assert
            var actualBooks = await context.Books.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedBooks.OrderBy(m => m.Id).Select(m => m.Name),
                actualBooks.OrderBy(m => m.Id).Select(m => m.Name));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Book_EditModel_OnGetAsync_BookIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.EditModel(context);
            int bookId = 1;

            // Act
            var result = await pageModel.OnGetAsync(bookId, null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Book>(pageModel.Book);
            Assert.Equal(bookId, model.Id);
            Assert.Equal("Карп'юк О.Д.", model.Author);
            Assert.Equal("Англійська мова", model.Name);
            Assert.Equal("Астон", model.PublishingHouse);
            Assert.Equal(2018, model.Year);
            Assert.Equal(1, model.Grade);
            Assert.Equal(54, model.Qty);
        }
        [Fact]
        public async Task Book_EditModel_OnPostAsync_BookIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.EditModel(context);
            int bookId = 1;
            var expectedBook = context.Books.FirstOrDefault(m => m.Id == bookId);
            pageModel.Book = expectedBook;
            pageModel.Book.Name = "Англійська мова";

            // Act
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Book>(pageModel.Book);
            Assert.Equal("Англійська мова", model.Name);
        }
        [Fact]
        public async Task Book_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.EditModel(context);
            int bookId = 1;
            var expectedBook = context.Books.FirstOrDefault(m => m.Id == bookId);
            pageModel.Book = expectedBook;
            pageModel.Book.Name = "Англійська мова";

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        //******************
        [Fact]
        public async Task Books_LendStudentModel_OnGetAsync_StudentsAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            var expectedList = context.Students;

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedList
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                        .Take(PageSize).Select(m => m.LastName),
                actualList
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic).Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Books_LendStudentModel_OnGetAsync_StudentsAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            var expectedList = context.Students;

            // Act
            await pageModel.OnGetAsync(bookId, "name_desc", null, null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedList
                        .OrderByDescending(s => s.LastName)
                            .ThenByDescending(s => s.FirstName)
                            .ThenByDescending(s => s.Patronymic)
                        .Take(PageSize).Select(m => m.LastName),
                actualList
                        .OrderByDescending(s => s.LastName)
                            .ThenByDescending(s => s.FirstName)
                            .ThenByDescending(s => s.Patronymic).Select(m => m.LastName)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("Бе")]
        [InlineData("ди")]
        [InlineData("нь")]
        public async Task Books_LendStudentModel_OnGetAsync_FilteredListOfStudentsIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            IQueryable<Student> expectedList = context.Students
                .Include(m => m.Books)
                .Include(m => m.Grade);
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedList = expectedList.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, searchString, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedList
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Take(PageSize).Select(m => m.LastName),
                actualList
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
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
        public async Task Books_LendStudentModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            List<Student> expectedList = new List<Student>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Books.Count() / (double)PageSize))
            {
                expectedList = context.Students
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedList = context.Students
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, null, pageIndex);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Student>>(pageModel.Student);
            Assert.Equal(
                expectedList
                    .Take(PageSize).Select(m => m.LastName),
                actualList
                    .Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Books_LendStudentModel_OnPostAsync_BookIsAddedToStudent()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            int studentId = 1;
            int gradeId = 1;
            var book = context.Books.Find(1);
            int expectedQty = book.Qty;

            // Act
            await pageModel.OnPostAsync(bookId, studentId, null, null, gradeId, null);

            // Assert
            var actualQuantity = context.Books.Find(1).Qty;
            Assert.True(context.Students.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty - 1, actualQuantity);
        }
        [Fact]
        public async Task Books_LendStudentModel_OnPostAsync_BookIsRemovedFromStudent()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendStudentModel(context, config);
            int bookId = 1;
            int studentId = 1;
            int gradeId = 1;
            var book = context.Books.Find(1);
            int expectedQty = book.Qty;

            // Act
            await pageModel.OnPostAsync(bookId, studentId, null, null, gradeId, null);

            // Assert
            var actualQuantity = context.Books.Find(1).Qty;
            Assert.True(context.Students.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty - 1, actualQuantity);

            await pageModel.OnPostAsync(bookId, studentId, null, null, gradeId, null);
            actualQuantity = context.Books.Find(1).Qty;
            Assert.False(context.Students.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty, actualQuantity);
        }
        //******************
        [Fact]
        public async Task Books_LendTeacherModel_OnGetAsync_TeachersAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            var expectedList = context.Teachers;

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedList
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                        .Take(PageSize).Select(m => m.LastName),
                actualList
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic).Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Books_LendTeacherModel_OnGetAsync_TeachersAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            var expectedList = context.Teachers;

            // Act
            await pageModel.OnGetAsync(bookId, "name_desc", null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedList
                        .OrderByDescending(s => s.LastName)
                            .ThenByDescending(s => s.FirstName)
                            .ThenByDescending(s => s.Patronymic)
                        .Take(PageSize).Select(m => m.LastName),
                actualList
                        .OrderByDescending(s => s.LastName)
                            .ThenByDescending(s => s.FirstName)
                            .ThenByDescending(s => s.Patronymic).Select(m => m.LastName)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("Бе")]
        [InlineData("ди")]
        [InlineData("нь")]
        public async Task Books_LendTeacherModel_OnGetAsync_FilteredListOfTeachersIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            IQueryable<Teacher> expectedList = context.Teachers.Include(m => m.Books);
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedList = expectedList.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, searchString, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedList
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Take(PageSize).Select(m => m.LastName),
                actualList
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
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
        public async Task Books_LendTeacherModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            List<Teacher> expectedList = new List<Teacher>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Books.Count() / (double)PageSize))
            {
                expectedList = context.Teachers
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedList = context.Teachers
                    .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, pageIndex);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Teacher>>(pageModel.Teacher);
            Assert.Equal(
                expectedList
                    .Take(PageSize).Select(m => m.LastName),
                actualList
                    .Select(m => m.LastName)
                );
        }
        [Fact]
        public async Task Books_LendTeacherModel_OnPostAsync_BookIsAddedToStudent()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            int teacherId = 1;
            var book = context.Books.Find(1);
            int expectedQty = book.Qty - 1;

            // Act
            await pageModel.OnPostAsync(bookId, teacherId, null, null, null);

            // Assert
            var actualQuantity = context.Books.Find(1).Qty;
            Assert.True(context.Teachers.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty, actualQuantity);
        }
        [Fact]
        public async Task Books_LendTeacherModel_OnPostAsync_BookIsRemovedFromStudent()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.LendTeacherModel(context, config);
            int bookId = 1;
            int teacherId = 1;
            var book = context.Books.Find(1);
            int expectedQty = book.Qty;

            // Act
            await pageModel.OnPostAsync(bookId, teacherId, null, null, null);

            // Assert
            var actualQuantity = context.Books.Find(1).Qty;
            Assert.True(context.Teachers.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty - 1, actualQuantity);

            await pageModel.OnPostAsync(bookId, teacherId, null, null, null);
            actualQuantity = context.Books.Find(1).Qty;
            Assert.False(context.Teachers.Find(1).Books.Contains(book));
            Assert.Equal(expectedQty, actualQuantity);
        }
        //*****************
        [Fact]
        public async Task Books_ReadersModel_OnGetAsync_ReadersAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.ReadersModel(context, config);
            int bookId = 1;
            int gradeId = 1;
            //Add book to students
            var lendStudentModel = new sms.Pages.Library.LendStudentModel(context, config);
            await lendStudentModel.OnPostAsync(bookId, 1, null, null, gradeId, null);
            await lendStudentModel.OnPostAsync(bookId, 2, null, null, gradeId, null);

            //Add book to teachers
            var lendTeacherModel = new sms.Pages.Library.LendTeacherModel(context, config);
            await lendTeacherModel.OnPostAsync(bookId, 1, null, null, null);
            await lendTeacherModel.OnPostAsync(bookId, 2, null, null, null);

            //Create expected list
            var students = await context.Students.Include(s => s.Books).Include(s => s.Grade).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            var teachers = await context.Teachers.Include(s => s.Books).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            IList<Reader> expectedList = new List<Reader>();
            foreach (var student in students)
                expectedList.Add(new Reader { Id = student.Id, Name = student.FullName, Type = sms.Pages.Library.Type.Учень, Grade = student.Grade.FullName });
            foreach (var teacher in teachers)
                expectedList.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = sms.Pages.Library.Type.Персонал, Grade = "" });

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Reader>>(pageModel.Reader);
            Assert.Equal(
                expectedList
                        .OrderBy(s => s.Name)
                        .Take(PageSize).Select(m => m.Name),
                actualList
                        .OrderBy(s => s.Name)
                        .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Books_ReadersModel_OnGetAsync_ReadersAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.ReadersModel(context, config);
            int bookId = 1;
            int gradeId = 1;
            //Add book to students
            var lendStudentModel = new sms.Pages.Library.LendStudentModel(context, config);
            await lendStudentModel.OnPostAsync(bookId, 1, null, null, gradeId, null);
            await lendStudentModel.OnPostAsync(bookId, 2, null, null, gradeId, null);

            //Add book to teachers
            var lendTeacherModel = new sms.Pages.Library.LendTeacherModel(context, config);
            await lendTeacherModel.OnPostAsync(bookId, 1, null, null, null);
            await lendTeacherModel.OnPostAsync(bookId, 2, null, null, null);

            //Create expected list
            var students = await context.Students.Include(s => s.Books).Include(s => s.Grade).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            var teachers = await context.Teachers.Include(s => s.Books).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            IList<Reader> expectedList = new List<Reader>();
            foreach (var student in students)
                expectedList.Add(new Reader { Id = student.Id, Name = student.FullName, Type = sms.Pages.Library.Type.Учень, Grade = student.Grade.FullName });
            foreach (var teacher in teachers)
                expectedList.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = sms.Pages.Library.Type.Персонал, Grade = "" });

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Reader>>(pageModel.Reader);
            Assert.Equal(
                expectedList
                        .OrderByDescending(s => s.Name)
                        .Take(PageSize).Select(m => m.Name),
                actualList
                        .OrderByDescending(s => s.Name)
                        .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("Бе")]
        [InlineData("ди")]
        [InlineData("нь")]
        public async Task Books_ReadersModel_OnGetAsync_FilteredListOfReadersIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.ReadersModel(context, config);
            int bookId = 1;
            int gradeId = 1;
            //Add book to students
            var lendStudentModel = new sms.Pages.Library.LendStudentModel(context, config);
            await lendStudentModel.OnPostAsync(bookId, 1, null, null, gradeId, null);
            await lendStudentModel.OnPostAsync(bookId, 2, null, null, gradeId, null);

            //Add book to teachers
            var lendTeacherModel = new sms.Pages.Library.LendTeacherModel(context, config);
            await lendTeacherModel.OnPostAsync(bookId, 1, null, null, null);
            await lendTeacherModel.OnPostAsync(bookId, 2, null, null, null);

            //Create expected list
            var students = await context.Students.Include(s => s.Books).Include(s => s.Grade).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            var teachers = await context.Teachers.Include(s => s.Books).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            IList<Reader> expectedList = new List<Reader>();
            foreach (var student in students)
                expectedList.Add(new Reader { Id = student.Id, Name = student.FullName, Type = sms.Pages.Library.Type.Учень, Grade = student.Grade.FullName });
            foreach (var teacher in teachers)
                expectedList.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = sms.Pages.Library.Type.Персонал, Grade = "" });
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedList = expectedList.Where(s => s.Name.ToLowerInvariant().Contains(searchString.ToLowerInvariant())
                                       || s.Grade.ToLowerInvariant().Contains(searchString.ToLowerInvariant())
                                       || s.Type.ToString().ToLowerInvariant().ToString().Contains(searchString.ToLowerInvariant()))
                                    .ToList();
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, searchString, null);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Reader>>(pageModel.Reader);
            Assert.Equal(
                expectedList
                        .OrderBy(s => s.Name)
                        .Take(PageSize).Select(m => m.Name),
                actualList
                        .OrderBy(s => s.Name)
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
        public async Task Books_ReadersModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.ReadersModel(context, config);
            int bookId = 1;
            int gradeId = 1;
            //Add book to students
            var lendStudentModel = new sms.Pages.Library.LendStudentModel(context, config);
            await lendStudentModel.OnPostAsync(bookId, 1, null, null, gradeId, null);
            await lendStudentModel.OnPostAsync(bookId, 2, null, null, gradeId, null);

            //Add book to teachers
            var lendTeacherModel = new sms.Pages.Library.LendTeacherModel(context, config);
            await lendTeacherModel.OnPostAsync(bookId, 1, null, null, null);
            await lendTeacherModel.OnPostAsync(bookId, 2, null, null, null);

            //Create expected list
            var students = await context.Students.Include(s => s.Books).Include(s => s.Grade).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            var teachers = await context.Teachers.Include(s => s.Books).Where(s => s.Books.Any(b => b.Id == bookId)).ToListAsync();
            IList<Reader> expectedList = new List<Reader>();
            foreach (var student in students)
                expectedList.Add(new Reader { Id = student.Id, Name = student.FullName, Type = sms.Pages.Library.Type.Учень, Grade = student.Grade.FullName });
            foreach (var teacher in teachers)
                expectedList.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = sms.Pages.Library.Type.Персонал, Grade = "" });
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)expectedList.Count() / (double)PageSize))
            {
                expectedList = expectedList
                    .OrderBy(s => s.Name)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedList = expectedList
                    .OrderBy(s => s.Name)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(bookId, null, null, null, pageIndex);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<Reader>>(pageModel.Reader);
            Assert.Equal(
                expectedList
                        .OrderBy(s => s.Name)
                        .Take(PageSize).Select(m => m.Name),
                actualList
                        .OrderBy(s => s.Name)
                        .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Books_ReadersModel_OnPostAsync_BookIsRemovedFromReader()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Library.ReadersModel(context, config);
            int bookId = 1;
            int gradeId = 1;
            int teacherId = 1;
            int studentId = 1;
            var book = context.Books.Find(1);
            int expectedQty = book.Qty;

            //Add book to student
            var lendStudentModel = new sms.Pages.Library.LendStudentModel(context, config);
            await lendStudentModel.OnPostAsync(bookId, studentId, null, null, gradeId, null);

            //Add book to teacher
            var lendTeacherModel = new sms.Pages.Library.LendTeacherModel(context, config);
            await lendTeacherModel.OnPostAsync(bookId, teacherId, null, null, null);
            

            // Act
            //Take books away
            await pageModel.OnPostAsync(bookId, null, teacherId, null, null, null);
            await pageModel.OnPostAsync(bookId, studentId, null, null, null, null);

            // Assert
            var actualQuantity = context.Books.Find(1).Qty;
            Assert.False(context.Teachers.Find(teacherId).Books.Contains(book));
            Assert.False(context.Students.Find(studentId).Books.Contains(book));
            Assert.Equal(expectedQty, actualQuantity);
        }
    }
}
