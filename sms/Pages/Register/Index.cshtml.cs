﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public IList<Gradebook> gradebooks { get; set; }
        public List<SelectListItem> GradesSL;
        public int selectedGrade;
        public int selectedSubject;
        public int selectedMonth;
        public int selectedYear;
        public string selectedMark;
        public List<SelectListItem> SubjectsSL { get; set; }
        public List<Student> students;
        public List<int> weekdays;
        public PaginatedList<int> weekdaysPaginated { get; set; }
        public int? selectedPage;

        public List<SelectListItem> YearSL { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = $"{DateTime.Now.Year-2}", Text = $"{DateTime.Now.Year-2}" },
            new SelectListItem { Value = $"{DateTime.Now.Year-1}", Text = $"{DateTime.Now.Year-1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year}", Text = $"{DateTime.Now.Year}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+1}", Text = $"{DateTime.Now.Year+1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+2}", Text = $"{DateTime.Now.Year+2}" }
        };

        public List<SelectListItem> Months { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Січень" },
            new SelectListItem { Value = "2", Text = "Лютий" },
            new SelectListItem { Value = "3", Text = "Березень" },
            new SelectListItem { Value = "4", Text = "Квітень" },
            new SelectListItem { Value = "5", Text = "Травень" },
            new SelectListItem { Value = "6", Text = "Червень" },
            new SelectListItem { Value = "7", Text = "Липень" },
            new SelectListItem { Value = "8", Text = "Серпень" },
            new SelectListItem { Value = "9", Text = "Вересень" },
            new SelectListItem { Value = "10", Text = "Жовтень" },
            new SelectListItem { Value = "11", Text = "Листопад" },
            new SelectListItem { Value = "12", Text = "Грудень" }
        };

        public List<SelectListItem> Marks { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = null, Text = " " },
            new SelectListItem { Value = "0", Text = "Н" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" },
            new SelectListItem { Value = "4", Text = "4" },
            new SelectListItem { Value = "5", Text = "5" },
            new SelectListItem { Value = "6", Text = "6" },
            new SelectListItem { Value = "7", Text = "7" },
            new SelectListItem { Value = "8", Text = "8" },
            new SelectListItem { Value = "9", Text = "9" },
            new SelectListItem { Value = "10", Text = "10" },
            new SelectListItem { Value = "11", Text = "11" },
            new SelectListItem { Value = "12", Text = "12" }
        };

        public IndexModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public async Task OnGetAsync(int? pageIndex, int gradeId = 0, int subjectId = 0, int year = 2023, int month = 9)
        {
            selectedGrade = gradeId;
            selectedSubject = subjectId;
            selectedMonth = month;
            selectedPage = pageIndex ?? 1;
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;

            //Subject dropdown
            //Випадаючий список предметів
            if (gradeId != 0)
            {
                SubjectsSL = _context.Curricula
                    .AsNoTracking()
                    .Include(g => g.Subject)
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.Subject.Name)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.SubjectId.ToString(),
                        Text = g.Subject.Name
                    }).ToList();
            }
            else
            {
                SubjectsSL = new List<SelectListItem>()
                    {
                        new SelectListItem
                        {
                            Value = null,
                            Text = " "
                        }
                    };

            }

            //Get list of days with lessons
            //Список дат з уроками з певного предмету
            #region get list of days that actually have lessons on them
            List<int> dayNumbers = await _context.Lessons
                .Where(l => l.GradeId == gradeId && l.SubjectId == subjectId)
                .GroupBy(g => g.Day)
                .Select(g => g.Key).ToListAsync(); ;
            List<DayOfWeek> engDays = new List<DayOfWeek>();
            foreach (int d in dayNumbers)
                engDays.Add((DayOfWeek)d);
            weekdays = new List<int>();
            foreach(DayOfWeek d in engDays)
            {
                weekdays.AddRange(AllDatesInMonth(year, month).Where(i => i.DayOfWeek == d).Select(i => i.Day).ToList());
            }
            weekdays.Sort();
            #endregion

            //var pageSize = Configuration.GetValue("PageSize", 7);
            var pageSize = 15;
            weekdaysPaginated = PaginatedList<int>.CreateFromList(weekdays, pageIndex ?? 1, pageSize);

            //List of students
            //Список учнів
            if (gradeId != 0)
            {
                students = await _context.Students
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .ToListAsync();
            }
            else { students = new List<Student>(); }

            //Grades dropdown
            //Ниспадаючий список класів
            GradesSL = new List<SelectListItem>();
            var grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grades)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            //Get mark from gradebook for a date
            //Отримання оцінки на певну дату
            gradebooks = await _context.Gradebooks
                .Include(g => g.Student)
                .Where(g => g.LessonDate.Month == month && g.LessonDate.Year == year && g.SubjectId == subjectId && g.Student.GradeId == gradeId)
                .ToListAsync();

            Log.Information("Користувач переглядає сторінку {0} класного журналу", pageIndex ?? 1);
        }
        public async Task<IActionResult> OnPostAsync(int year, int month, int day,
             int gradeId, int studentId, int subjectId, string mark, int pageIndex)
        {
            var existingGradebook = _context.Gradebooks
                .SingleOrDefault(g => g.LessonDate == new DateTime(year, month, day)
                && g.StudentId == studentId && g.SubjectId == subjectId);
            if (existingGradebook == null && mark != null)
            {
                //Create a new record in the gradebook
                //Створення нового запису у журналі
                var newGradebook = new Gradebook
                {
                    LessonDate = new DateTime(year, month, day),
                    Mark = mark,
                    StudentId = studentId,
                    SubjectId = subjectId,
                    TeacherId = _context.Curricula.Single(c => c.GradeId == gradeId && c.SubjectId == subjectId).TeacherId
                };
                _context.Gradebooks.Add(newGradebook);
                await _context.SaveChangesAsync();
            }
            else
            {
                //Remove a record from gradebook if the cell is empty
                //Видалення запису з журналу, якщо комірка пуста
                if (mark == null)
                {
                    _context.Remove(existingGradebook);
                }
                //Change record
                //Коригування запису
                else existingGradebook.Mark = mark;
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new
            {
                pageIndex = $"{ pageIndex }",
                gradeId = $"{ gradeId }",
                subjectId = $"{ subjectId }",
                year = $"{ year }",
                month = $"{ month }"
            });
        }

        //Get list of subjects for dropdown
        //Отримання списку предметів для випадаючого списку
        public JsonResult OnGetSubjects(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {

                IEnumerable<SelectListItem> subjects = _context.Curricula
                    .AsNoTracking()
                    .Include(g => g.Subject)
                    .Where(g => g.GradeId == int.Parse(gradeId))
                    .OrderBy(g => g.Subject.Name)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.SubjectId.ToString(),
                        Text = g.Subject.Name
                    }).ToList();

                //var subj = new SelectList(subjects, "Value", "Text");

                return new JsonResult(subjects);
            }
            return null;
        }

        //Get all dates in a month
        //Отримання всіх дат у певний місяць
        public IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }
        }
    }
}
