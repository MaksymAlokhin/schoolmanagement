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

namespace sms.Pages
{
    [Authorize(Roles = "Адміністратор")]
    public class TimeTableModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<sms.Models.Lesson> lessons;
        public List<sms.Models.Teacher> teachers;
        public string selectedDay;

        public TimeTableModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(string ttday = "Пн")
        {
            teachers = await _context.Teachers
                .OrderBy(i => i.LastName)
                .ToListAsync();
            lessons = await _context.Lessons
                .Where(i=>i.day == (day)Enum.Parse(typeof(day), ttday))
                .Include(i => i.Teacher)
                    .ThenInclude(c => c.Subjects)
                .Include(i => i.Subject)
                    .ThenInclude(g => g.Teachers)
                .Include(i => i.Grade)
                .OrderBy(i => i.Teacher.LastName)
                .ToListAsync();
            selectedDay = ttday;
        }
    }
}
