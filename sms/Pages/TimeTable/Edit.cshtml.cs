using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.TimeTable
{
    [Authorize(Roles = "Адміністратор")]
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lesson Lesson { get; set; }
        public List<SelectListItem> GradesSL { get; set; }
        public SelectList SubjectNameSL { get; set; }

        public async Task<IActionResult> OnGetAsync(int day, int slot, int teacher)
        {

            Lesson = await _context.Lessons
                .Include(l => l.Grade)
                .Include(l => l.Subject)
                .Include(l => l.Teacher).FirstOrDefaultAsync(m => m.Day == day && m.Slot == slot && m.TeacherId == teacher);

            if (Lesson == null)
            {
                return NotFound();
            }

            //Dropdown list of available Grades (that don't have a lesson on this slot)
            //Випадаючий список класів, у яких зараз немає уроку
            #region Generate Droplist of available Grades for this day and slot
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
            GradesSL = new List<SelectListItem>();
            foreach (Grade grade in allGrades)
            {
                if (!takenGrades.Contains(grade.Id))
                {
                    GradesSL.Add(new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}"});
                }
                else if (grade.Id == Lesson.GradeId)
                {
                    var item = new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}" };
                    item.Selected = true;
                    GradesSL.Add(item);
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Save changed record to DB
            //Зберегти змінений запис у БД
            _context.Attach(Lesson).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(Lesson.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            Log.Information("Користувач відредагував урок - день: {0}, урок№: {1}", Lesson.Day, Lesson.Slot);

            return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}
