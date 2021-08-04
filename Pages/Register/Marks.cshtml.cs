using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель, Батьки")]
    public class MarksModel : PageModel
    {
        public MarksModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly sms.Data.ApplicationDbContext _context;
        public IList<Gradebook> gradebook { get; set; }
        public List<SelectListItem> grades;
        public List<Subject> subjects;
        public int selectedGrade;
        public int selectedMonth;
        public int selectedYear;
        public int selectedStudent;
        public string selectedMark;
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


        //string sMonth = DateTime.Now.ToString("MM"); //01
        //string sMonth = DateTime.Now.ToString(); //1

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

        public async Task OnGetAsync(int gradeId = 0, int year = 0, int month = 9, int studentId = 0)
        {
            selectedGrade = gradeId;
            selectedMonth = month;
            selectedStudent = studentId;
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;

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

            if (gradeId != 0)
            {
                students = await _context.Students
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .ToListAsync();
            }
            else { students = new List<Student>(); }

            grades = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                grades.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            gradebook = await _context.Gradebooks
                .Include(g => g.Student)
                .Where(g => g.LessonDate.Month == month && g.LessonDate.Year == year 
                        && g.Student.GradeId == gradeId && g.StudentId == studentId)
                .ToListAsync();

            subjects = _context.Curricula
                    .AsNoTracking()
                    .Include(g => g.Subject)
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.Subject.Name)
                    .Select(g => g.Subject)
                    .ToList();

            //days = gradebook.Select(g => g.LessonDate.Day).ToList();
            //days.Sort();
        }
        public JsonResult OnGetStudents(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {
                IEnumerable <SelectListItem> students = _context.Students
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
    }
}
