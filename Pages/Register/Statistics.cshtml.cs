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
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class StatisticsModel : PageModel
    {
        public StatisticsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> YearSL { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = $"{DateTime.Now.Year-2}", Text = $"{DateTime.Now.Year-2}" },
            new SelectListItem { Value = $"{DateTime.Now.Year-1}", Text = $"{DateTime.Now.Year-1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year}", Text = $"{DateTime.Now.Year}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+1}", Text = $"{DateTime.Now.Year+1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+2}", Text = $"{DateTime.Now.Year+2}" }
        };
        public List<SelectListItem> SemesterSL { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "І семестр" },
            new SelectListItem { Value = "2", Text = "ІІ семестр" }
        };
        public SelectList YearList;
        public List<Grade> grades;
        public List<Gradebook> gradebooks;
        public List<Curriculum> curricula;
        public int selectedYear;
        public int selectedSemester;
        public async Task OnGetAsync(int year = 0, int semester = 1)
        {
            YearList = new SelectList(YearSL, "Value", "Text", $"{DateTime.Now.Year}");
            grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter).ToList();
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;
            selectedSemester = semester;
            DateTime startDate1 = new DateTime(selectedYear, 9, 1);
            DateTime startDate2 = new DateTime(selectedYear, 1, 1);
            DateTime endDate1 = new DateTime(selectedYear, 12, 31);
            DateTime endDate2 = new DateTime(selectedYear, 5, 31);
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            switch (selectedSemester)
            {
                case 1:
                    startDate = startDate1;
                    endDate = endDate1;
                    break;
                case 2:
                    startDate = startDate2;
                    endDate = endDate2;
                    break;
            }
            gradebooks = _context.Gradebooks
                .Include(g => g.Student)
                .Where(g => g.LessonDate >= startDate && g.LessonDate <= endDate)
                .ToList();
            
            curricula = _context.Curricula
                .AsNoTracking()
                .Include(g => g.Subject)
                .ToList();
        }
    }
}
