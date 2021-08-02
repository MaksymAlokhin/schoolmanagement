using System;
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

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public IList<Gradebook> Gradebook { get; set; }
        public List<SelectListItem> grades;
        public int? selectedGrade;
        public int? selectedSubject;
        public int? selectedMonth;
        public int? selectedYear;
        public List<SelectListItem> SubjectsSL { get; set; }
        public List<Student> students;
        public int days;

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

        public IndexModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int? gradeId, int? subjectId, int? yearId, int? monthId)
        {
            selectedGrade = gradeId;
            selectedSubject = subjectId;
            selectedMonth = monthId;

            if (yearId == null) selectedYear = DateTime.Now.Year;
            else selectedYear = yearId;

            if (gradeId != null)
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
            if (monthId != null && yearId != null)
            {
                days = DateTime.DaysInMonth((int)selectedYear, (int)monthId);
            }
            else { days = 31; }
            
            if (gradeId != null)
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

            Gradebook = await _context.Gradebooks
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .Include(g => g.Teacher)
                .Where(g => g.LessonDate.Month == monthId && g.LessonDate.Year == yearId && g.SubjectId == subjectId && g.Student.GradeId == gradeId)
                .ToListAsync();
        }
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
    }
}
