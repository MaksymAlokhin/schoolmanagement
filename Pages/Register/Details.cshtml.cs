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
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Gradebook> gradebooks;
        public int selectedYear;
        public int selectedGrade;
        public string gradeName;
        public int selectedSemester;
        public List<Details> subjects;
        public string NameSort { get; set; }
        public string MarkSort { get; set; }
        public string CurrentSort { get; set; }

        public async Task<IActionResult> OnGetAsync(int gradeId, int year, int semester, string sortOrder)
        {
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;
            selectedSemester = semester;
            selectedGrade = gradeId;
            gradeName = _context.Grades.Where(x => x.Id == gradeId).Select(x=>x.FullName).SingleOrDefault();
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

            var subjectsIQ = _context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Student.GradeId == gradeId && s.Mark != "0")
                .GroupBy(s => s.Subject.Name)
                .Select(g => new Details
                {
                    Name = g.Key,
                    Avg = g.Average(s => Convert.ToInt32(s.Mark))
                });

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            MarkSort = sortOrder == "mark" ? "mark_desc" : "mark";

            switch (sortOrder)
            {
                case "name_desc":
                    subjectsIQ = subjectsIQ.OrderByDescending(s => s.Name);
                    break;
                case "mark":
                    subjectsIQ = subjectsIQ.OrderBy(s => s.Avg);
                    break;
                case "mark_desc":
                    subjectsIQ = subjectsIQ.OrderByDescending(s => s.Avg);
                    break;
                default:
                    subjectsIQ = subjectsIQ.OrderBy(s => s.Name);
                    break;
            }

            subjects = await subjectsIQ.AsNoTracking().ToListAsync();

            return Page();
        }
    }
    public class Details
    {
        public string Name;
        public double Avg;
    }
}
