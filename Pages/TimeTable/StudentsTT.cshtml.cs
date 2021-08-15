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

namespace sms.Pages.TimeTable
{
    [Authorize(Roles = "Адміністратор, Вчитель, Батьки")]
    public class StudentsTTModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public int[] slots;
        public string[] days;
        public List<SelectListItem> GradesSL;
        public int selectedGrade;
        public List<Lesson> lessons;
        public StudentsTTModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int gradeId = 1)
        {
            selectedGrade = gradeId;
            slots = new int[8];
            slots = Enumerable.Range(1, 8).ToArray();
            days = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт" };

            GradesSL = new List<SelectListItem>();
            var grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grades)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            lessons = await _context.Lessons.Where(l => l.GradeId == gradeId).Include(l => l.Grade).Include(l => l.Subject).ToListAsync();
        }
    }
}
