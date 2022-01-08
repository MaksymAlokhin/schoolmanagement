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
using sms.Pages.Register;

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
        public async Task Gradebooks_IndexModel_OnPostAsync_GradebookIsAdded()
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
        public async Task Gradebooks_IndexModel_OnPostAsync_GradebookIsEdited()
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
        public async Task Gradebooks_IndexModel_OnPostAsync_GradebookIsDeleted()
        {
            // Arrange
            int studentId = 1;
            int day = 7;
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
        [Fact]
        public async Task Gradebooks_StatGradeModel_OnGetAsync_StatisticsForAllGradesReturned()
        {
            // Arrange
            int year = 2021;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatGradeModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate 
                    && s.LessonDate <= endDate 
                    && s.Mark != "0")
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new StatGrade
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                });

            // Act
            await pageModel.OnGetAsync(String.Empty);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGrade>>(pageModel.grades);

            Assert.Equal(
                expectedList
                    .OrderBy(s => s.Number).ThenBy(s => s.Letter)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .OrderBy(s => s.Number).ThenBy(s => s.Letter)
                    .Select(s => s.Avg));
        }
        [Fact]
        public async Task Gradebooks_StatGradeModel_OnGetAsync_StatisticsForAllGradesReturned_InDescendingOrder()
        {
            // Arrange
            int year = 2021;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatGradeModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate
                    && s.LessonDate <= endDate
                    && s.Mark != "0")
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new StatGrade
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                });

            // Act
            await pageModel.OnGetAsync("name_desc");

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGrade>>(pageModel.grades);

            Assert.Equal(
                expectedList
                    .OrderByDescending(s => s.Number).ThenByDescending(s => s.Letter)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public async Task Gradebooks_StatGradeDetailsModel_OnGetAsync_StatisticsForSingleGradeReturned()
        {
            // Arrange
            int gradeId = 1;
            int year = 2021;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatGradeDetailsModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate 
                && s.LessonDate <= endDate 
                && s.Student.GradeId == gradeId 
                && s.Mark != "0")
                .GroupBy(s => s.Subject.Name)
                .Select(g => new StatGradeDetails
                {
                    Name = g.Key,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1)
                });


            // Act
            await pageModel.OnGetAsync(String.Empty, gradeId);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGradeDetails>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderBy(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public async Task Gradebooks_StatGradeDetailsModel_OnGetAsync_StatisticsForSingleGradeReturned_InDescendingOrder()
        {
            // Arrange
            int gradeId = 1;
            int year = 2021;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatGradeDetailsModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate
                && s.LessonDate <= endDate
                && s.Student.GradeId == gradeId
                && s.Mark != "0")
                .GroupBy(s => s.Subject.Name)
                .Select(g => new StatGradeDetails
                {
                    Name = g.Key,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1)
                });


            // Act
            await pageModel.OnGetAsync("name_desc", gradeId);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGradeDetails>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderByDescending(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public void Gradebooks_StatStudentModel_OnGetAsync_StatisticsForSingleStudentReturned()
        {
            // Arrange
            int gradeId = 1;
            int studentId = 1;
            int year = 2021;
            int month = 9;

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatStudentModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate.Month == month && s.LessonDate.Year == year
                    && s.Student.GradeId == gradeId && s.StudentId == studentId && s.Mark != "0")
                .Select(s => new
                {
                    Name = s.Subject.Name,
                    Mark = Convert.ToInt32(s.Mark)
                })
                .AsEnumerable()
                .GroupBy(s => s.Name)
                .Select(g => new StatStudent
                {
                    Name = g.Key,
                    Avg = Math.Round(g.Average(s => s.Mark), 1),
                    Mark = g.Select(x => x.Mark).ToList()
                });

            // Act
            pageModel.OnGetAsync(string.Empty, gradeId, year, month, studentId);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatStudent>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderBy(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public void Gradebooks_StatStudentModel_OnGetAsync_StatisticsForSingleStudentReturned_InDescendingOrder()
        {
            // Arrange
            int gradeId = 1;
            int studentId = 1;
            int year = 2021;
            int month = 9;

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatStudentModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate.Month == month && s.LessonDate.Year == year
                    && s.Student.GradeId == gradeId && s.StudentId == studentId && s.Mark != "0")
                .Select(s => new
                {
                    Name = s.Subject.Name,
                    Mark = Convert.ToInt32(s.Mark)
                })
                .AsEnumerable()
                .GroupBy(s => s.Name)
                .Select(g => new StatStudent
                {
                    Name = g.Key,
                    Avg = Math.Round(g.Average(s => s.Mark), 1),
                    Mark = g.Select(x => x.Mark).ToList()
                });

            // Act
            pageModel.OnGetAsync("name_desc", gradeId, year, month, studentId);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatStudent>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderByDescending(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public async Task Gradebooks_StatSubjectModel_OnGetAsync_StatisticsForAllSubjectsReturned()
        {
            // Arrange
            int year = 2021;
            int semester = 1;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatSubjectModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Mark != "0")
                .GroupBy(s => new { s.Subject.Name, s.Subject.Id })
                .Select(g => new StatSubject
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1)
                });

            // Act
            await pageModel.OnGetAsync(string.Empty, year, semester);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatSubject>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderBy(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public async Task Gradebooks_StatSubjectModel_OnGetAsync_StatisticsForAllSubjectsReturned_InDescendingOrder()
        {
            // Arrange
            int year = 2021;
            int semester = 1;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatSubjectModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Mark != "0")
                .GroupBy(s => new { s.Subject.Name, s.Subject.Id })
                .Select(g => new StatSubject
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1)
                });

            // Act
            await pageModel.OnGetAsync("name_desc", year, semester);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatSubject>>(pageModel.subjects);

            Assert.Equal(
                expectedList
                    .OrderByDescending(s => s.Name)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public void Gradebooks_StatSubjectDetailsModel_OnGetAsync_StatisticsForSingleSubjectReturned()
        {
            // Arrange
            int year = 2021;
            int semester = 1;
            int subjectId = 1;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatSubjectDetailsModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate
                        && s.LessonDate <= endDate
                        && s.Mark != "0"
                        && s.SubjectId == subjectId)
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new StatGrade
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                });

            // Act
            pageModel.OnGetAsync(subjectId, string.Empty, year, semester);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGrade>>(pageModel.grades);

            Assert.Equal(
                expectedList
                    .OrderBy(s => s.Number).ThenBy(s => s.Letter)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
        [Fact]
        public void Gradebooks_StatSubjectDetailsModel_OnGetAsync_StatisticsForSingleSubjectReturned_InDescendingOrder()
        {
            // Arrange
            int year = 2021;
            int semester = 1;
            int subjectId = 1;
            DateTime startDate = new DateTime(year, 9, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Register.StatSubjectDetailsModel(context, config);
            var expectedList = context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate
                        && s.LessonDate <= endDate
                        && s.Mark != "0"
                        && s.SubjectId == subjectId)
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new StatGrade
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                });

            // Act
            pageModel.OnGetAsync(subjectId, "name_desc", year, semester);

            // Assert
            var actualList = Assert.IsAssignableFrom<PaginatedList<StatGrade>>(pageModel.grades);

            Assert.Equal(
                expectedList
                    .OrderByDescending(s => s.Number).ThenByDescending(s => s.Letter)
                    .Take(PageSize).Select(s => s.Avg),
                actualList
                    .Select(s => s.Avg));
        }
    }
}
