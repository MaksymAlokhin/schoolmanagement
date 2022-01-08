using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Батьки")]
    public class StatStudentModel : PageModel
    {
        public StatStudentModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public List<SelectListItem> GradesSL;
        public PaginatedList<StatStudent> subjects;
        public int selectedGrade;
        public int selectedMonth;
        public int selectedYear;
        public int selectedStudent;
        public string selectedMark;
        public string NameSort { get; set; }
        public string MarkSort { get; set; }
        public string CurrentSort { get; set; }
        public List<SelectListItem> StudentsSL { get; set; }
        public List<Student> students;
        public List<int> days;

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

        public void OnGetAsync(string sortOrder, int gradeId = 0, int year = 2021, int month = 9, int studentId = 0, int? pageIndex = 1)
        {
            CurrentSort = sortOrder; 
            selectedGrade = gradeId;
            selectedMonth = month;
            selectedStudent = studentId;
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;

            //Students dropdown
            //Випадаючий список учнів
            if (gradeId != 0)
            {
                StudentsSL = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();
            }
            else
            {
                StudentsSL = new List<SelectListItem>()
                    {
                        new SelectListItem
                        {
                            Value = null,
                            Text = " "
                        }
                    };
            }

            //Grades dropdown
            //Випадаючий список класів
            GradesSL = new List<SelectListItem>();
            var grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grades)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            //Data for student academic awards table
            //Дані для таблиці успішності учнів
            var SubjectsIQ = _context.Gradebooks
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

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            MarkSort = sortOrder == "mark" ? "mark_desc" : "mark";

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    SubjectsIQ = SubjectsIQ.OrderByDescending(s => s.Name);
                    break;
                case "mark":
                    SubjectsIQ = SubjectsIQ.OrderBy(s => s.Avg);
                    break;
                case "mark_desc":
                    SubjectsIQ = SubjectsIQ.OrderByDescending(s => s.Avg);
                    break;
                default:
                    SubjectsIQ = SubjectsIQ.OrderBy(s => s.Name);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 7);
            subjects = PaginatedList<StatStudent>.CreateFromList(
                SubjectsIQ.ToList(), pageIndex ?? 1, pageSize);

            //String of all student's marks
            //Рядок з усіма оцінками учня
            foreach (var subj in subjects)
            {
                string concat = String.Join(", ", subj.Mark);
                subj.ConcatenatedMarks = concat;
            }

            Log.Information("Користувач переглядає сторінку {0} навчальних досягнень учня", pageIndex ?? 1);
        }

        //Get students names for dropdown
        //Отримання списку учнів для випадаючого списку
        public JsonResult OnGetStudents(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {
                IEnumerable<SelectListItem> students = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == int.Parse(gradeId))
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();

                //return new JsonResult(new[] { subjects, students });

                return new JsonResult(students);
            }
            return null;
        }
        //Generate data for student academic performance bar chart
        //Генерувати дані для діаграми успішності учнів
        public JsonResult OnPostData(int year, int month, int gradeId, int studentId)
        {
            var subjects = _context.Gradebooks
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
                                })
                                .OrderBy(s => s.Name);

            return new JsonResult(subjects);
        }
    }
    //Student academic performance table data
    //Дані для таблиці успішності учнів
    public class StatStudent
    {
        public string Name { get; set; }
        public List<int> Mark { get; set; }
        public double Avg { get; set; }
        public string ConcatenatedMarks { get; set; }
    }
}
