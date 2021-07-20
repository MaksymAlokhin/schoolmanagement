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
        public day selectedDay;

        public TimeTableModel(ApplicationDbContext context)
        {
            _context = context;
            lessons = _context.Lessons
                .Where(i => i.day == day.Пн)
                .Include(i => i.Teacher)
                    .ThenInclude(c => c.Subjects)
                .Include(i => i.Subject)
                    .ThenInclude(g => g.Teachers)
                .Include(i => i.Grade)
                .OrderBy(i => i.Teacher.LastName)
                .ToList();
        }
        public async Task OnGetAsync(day ttday = day.Пн)
        {
            teachers = await _context.Teachers
                .OrderBy(i => i.LastName)
                .ToListAsync();
            lessons = await _context.Lessons
                .Where(i=>i.day == ttday)
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
