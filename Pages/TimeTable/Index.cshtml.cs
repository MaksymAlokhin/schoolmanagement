using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Data;
using sms.Models;

namespace sms.Pages.TimeTable
{
    [Authorize(Roles = "јдм≥н≥стратор, ¬читель")]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<sms.Models.Lesson> lessons;
        public List<sms.Models.Teacher> teachers;
        public string selectedDay;
        public List<SelectListItem> Days { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ѕн", Text = "ѕн" },
            new SelectListItem { Value = "¬т", Text = "¬т" },
            new SelectListItem { Value = "—р", Text = "—р" },
            new SelectListItem { Value = "„т", Text = "„т" },
            new SelectListItem { Value = "ѕт", Text = "ѕт" }
        };

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task OnGetAsync(string day = "ѕн")
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

        public void OnGetGenerateAsync()
        {
            Generator gen = new Generator(_context, _logger);
            gen.Generate();
            gen.RemoveGaps();
            var x = gen.lessons;

            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Lessons]");

            _context.Lessons.AddRange(x);
            _context.SaveChanges();

            teachers = _context.Teachers
                .OrderBy(i => i.LastName)
                .ToList();
            lessons = _context.Lessons
                .Where(i => i.Day == "ѕн")
                .Include(i => i.Grade)
                .ToList();
            selectedDay = "ѕн";


            //RedirectToPage("./Index", new { day = $"{selectedDay}" });
            //Page();
        }
    }
}
