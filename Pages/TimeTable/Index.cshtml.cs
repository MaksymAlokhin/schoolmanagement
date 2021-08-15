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
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<sms.Models.Lesson> lessons;
        public List<sms.Models.Teacher> teachers;
        public string selectedDay;
        public List<SelectListItem> Days { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Пн", Text = "Пн" },
            new SelectListItem { Value = "Вт", Text = "Вт" },
            new SelectListItem { Value = "Ср", Text = "Ср" },
            new SelectListItem { Value = "Чт", Text = "Чт" },
            new SelectListItem { Value = "Пт", Text = "Пт" }
        };

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task OnGetAsync(string day = "Пн")
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
            //Generate timetable
            //Генерація розкладу
            Generator gen = new Generator(_context, _logger);
            gen.Generate();
            gen.RemoveGaps();
            var x = gen.lessons;

            //Delete all rows from Lessons table
            //Видалення усіх рядків з таблиці уроків
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Lessons]");

            //Save generated lessons to DB
            //Збереження згенерованих уроків у БД
            _context.Lessons.AddRange(x);
            _context.SaveChanges();

            //Get data from DB
            //Завантаження даних з БД
            teachers = _context.Teachers
                .OrderBy(i => i.LastName)
                .ToList();
            lessons = _context.Lessons
                .Where(i => i.Day == "Пн")
                .Include(i => i.Grade)
                .ToList();
            selectedDay = "Пн";
        }
    }
}
