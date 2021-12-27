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
        public int selectedDay;
        public List<SelectListItem> Days { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Пн" },
            new SelectListItem { Value = "2", Text = "Вт" },
            new SelectListItem { Value = "3", Text = "Ср" },
            new SelectListItem { Value = "4", Text = "Чт" },
            new SelectListItem { Value = "5", Text = "Пт" }
        };

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task OnGetAsync(int day = 1)
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
            var newLessons = gen.lessons;

            //Delete all rows from Lessons table
            //Видалення усіх рядків з таблиці уроків
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Lessons]");

            //Save generated lessons to DB
            //Збереження згенерованих уроків у БД
            _context.Lessons.AddRange(newLessons);
            _context.SaveChanges();

            //Get data from DB
            //Завантаження даних з БД
            teachers = _context.Teachers
                .OrderBy(i => i.LastName)
                .ToList();
            lessons = _context.Lessons
                .Where(i => i.Day == 1)
                .Include(i => i.Grade)
                .ToList();
            selectedDay = 1;
        }

        public void OnGetGeneticAsync()
        {
            //Generate timetable
            //Генерація розкладу
            Scheduler scheduler = new Scheduler(_context, _logger);

            //Delete all rows from Lessons table
            //Видалення усіх рядків з таблиці уроків
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Lessons]");

            //Save generated lessons to DB
            //Збереження згенерованих уроків у БД
            foreach (Gene gene in scheduler.finalson.genes)
            {
                _context.Lessons.AddRange(gene.geneLessons);
            }
            _context.SaveChanges();

            //Get data from DB
            //Завантаження даних з БД
            teachers = _context.Teachers
                .OrderBy(i => i.LastName)
                .ToList();
            lessons = _context.Lessons
                .Where(i => i.Day == 1)
                .Include(i => i.Grade)
                .ToList();
            selectedDay = 1;
        }

    }
}
