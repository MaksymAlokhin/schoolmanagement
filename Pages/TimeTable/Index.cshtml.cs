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
    [Authorize(Roles = "Àäì³í³ñòðàòîð")]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<sms.Models.Lesson> lessons;
        public List<sms.Models.Teacher> teachers;
        public string selectedDay;
        public List<SelectListItem> Days { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Ïí", Text = "Ïí" },
            new SelectListItem { Value = "Âò", Text = "Âò" },
            new SelectListItem { Value = "Ñð", Text = "Ñð" },
            new SelectListItem { Value = "×ò", Text = "×ò" },
            new SelectListItem { Value = "Ïò", Text = "Ïò" }
        };

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(string day = "Ïí")
        {
            teachers = await _context.Teachers
                .OrderBy(i => i.LastName)
                .ToListAsync();
            lessons = await _context.Lessons
                .Where(i => i.Day == day)
                .Include(i => i.Grade)
                .ToListAsync();
            selectedDay = day;
        }
    }
}
