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
    [Authorize(Roles = "�����������, �������, ������")]
    public class StudentsMarksModel : PageModel
    {
        public StudentsMarksModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly sms.Data.ApplicationDbContext _context;
        public IList<Gradebook> gradebook { get; set; }
        public List<SelectListItem> grades;
        public int selectedGrade;
        public int selectedSubject;
        public int selectedMonth;
        public int selectedYear;
        public string selectedMark;
        public int NowYear = DateTime.Now.Year;
        public List<SelectListItem> SubjectsSL { get; set; }
        public List<Student> students;
        public List<int> weekdays;
        public PaginatedList<int> pages { get; set; }
        public int? selectedPage;

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
            new SelectListItem { Value = "1", Text = "ѳ����" },
            new SelectListItem { Value = "2", Text = "�����" },
            new SelectListItem { Value = "3", Text = "��������" },
            new SelectListItem { Value = "4", Text = "������" },
            new SelectListItem { Value = "5", Text = "�������" },
            new SelectListItem { Value = "6", Text = "�������" },
            new SelectListItem { Value = "7", Text = "������" },
            new SelectListItem { Value = "8", Text = "�������" },
            new SelectListItem { Value = "9", Text = "��������" },
            new SelectListItem { Value = "10", Text = "�������" },
            new SelectListItem { Value = "11", Text = "��������" },
            new SelectListItem { Value = "12", Text = "�������" }
        };

        public async Task OnGetAsync(int? pageIndex, int gradeId = 0, int subjectId = 0, int year = 0, int month = 9)
        {
            selectedGrade = gradeId;
            selectedSubject = subjectId;
            selectedMonth = month;
            selectedPage = pageIndex;
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;

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

            #region get list of days that actually have lessons on them
            var ukrDays = await _context.Lessons
                .Where(l => l.GradeId == gradeId && l.SubjectId == subjectId)
                .GroupBy(g => g.Day)
                .Select(g => g.Key).ToListAsync();
            List<int> dayNumbers = new List<int>();
            foreach(string d in ukrDays)
            {
                dayNumbers.Add((int)Enum.Parse(typeof(UkrDay), d));
            }
            List<DayOfWeek> engDays = new List<DayOfWeek>();
            foreach (int d in dayNumbers)
            {
                engDays.Add(((DayOfWeek)d));
            }
            weekdays = new List<int>();
            foreach(DayOfWeek d in engDays)
            {
                weekdays.AddRange(AllDatesInMonth(year, month).Where(i => i.DayOfWeek == d).Select(i => i.Day).ToList());
            }
            weekdays.Sort();
            #endregion

            var pageSize = 11;
            pages = PaginatedList<int>.CreateFromList(weekdays, pageIndex ?? 1, pageSize);


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
                .Include(g => g.Subject)
                .Include(g => g.Teacher)
                .Where(g => g.LessonDate.Month == month && g.LessonDate.Year == year && g.SubjectId == subjectId && g.Student.GradeId == gradeId)
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
