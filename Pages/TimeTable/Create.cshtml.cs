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
    [Authorize(Roles = "Адміністратор")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Lesson Lesson { get; set; }

        public List<SelectListItem> GradesList { get; set; }
        public SelectList SubjectNameSL { get; set; }

        public IActionResult OnGetAsync(string day, int slot, int teacher)
        {
            //Initialize new record with static data
            //Ініціалізація нового запису даними, що незмінюються
            Lesson = new Lesson();
            Lesson.Day = day;
            Lesson.Slot = slot;
            Teacher Teacher = _context.Teachers.Single(t => t.Id == teacher);
            Lesson.Teacher = Teacher;
            Lesson.TeacherId = teacher;

            //Dropdown list of available Grades (that don't have a lesson on this slot)
            //Випадаючий список класів, у яких зараз немає уроку
            #region Generate Dropdown list of available Grades for this day and slot
            var LessonsOnThisDayAndSlot = _context.Lessons
                .Include(l => l.Grade)
                .Where(l => l.Day == day)
                .Where(l => l.Slot == slot)
                .ToList();

            List<int> takenGrades = new List<int>();

            foreach (Lesson lesson in LessonsOnThisDayAndSlot)
            {
                takenGrades.Add(lesson.GradeId);
            }

            var allGrades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);

            GradesList = new List<SelectListItem>();
            foreach (Grade grade in allGrades)
            {
                if(!takenGrades.Contains(grade.Id))
                {
                    GradesList.Add(new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}" });
                }
            }
            #endregion

            //Subjects dropdown list
            //Випадаючий список предметів
            var subjectsQuery = _context.Subjects
                .Include(s => s.Teachers)
                .Where(t => t.Teachers.Any(k => k.Id == teacher))
                .OrderBy(s => s.Name);
            SubjectNameSL = new SelectList(subjectsQuery.AsNoTracking(), "Id", "Name"); //list, id, value

            return Page();
        }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //Create a new record and fill its properties
            //Створення нового запису і заповнення властивостей даними
            Lesson newLesson = new Lesson();
            if (await TryUpdateModelAsync<Lesson>(
                newLesson,
                "Lesson",
                i => i.Day, i => i.Slot, i=>i.TeacherId, 
                i => i.Room, i => i.GradeId, i => i.SubjectId))
            {
                //Save new record to the DB
                //Збереження нового запису у БД
                _context.Lessons.Add(newLesson);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
            }
            return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
        }
    }
}
