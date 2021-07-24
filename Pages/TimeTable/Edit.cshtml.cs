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
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lesson Lesson { get; set; }
        public List<SelectListItem> GradesList { get; set; }
        public string SelectedGrade { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public int SelectedSubject { get; set; }

        public async Task<IActionResult> OnGetAsync(string day, int slot, int teacher)
        {

            Lesson = await _context.Lessons
                .Include(l => l.Grade)
                .Include(l => l.Subject)
                .Include(l => l.Teacher).FirstOrDefaultAsync(m => m.Day == day && m.Slot == slot && m.TeacherId == teacher);

            SelectedGrade = Lesson.Grade.FullName;

            if (Lesson == null)
            {
                return NotFound();
            }

            #region Generate Droplist of available Grades for this day and slot
            var LessonsOnThisDayAndSlot = _context.Lessons.Include(l => l.Grade).Where(l => l.Day == day).Where(l => l.Slot == slot).ToList();

            List<string> allGrades = new List<string>();
            List<string> takenGrades = new List<string>();
            List<string> freeGrades = new List<string>();

            foreach (Lesson lesson in LessonsOnThisDayAndSlot)
            {
                takenGrades.Add(lesson.Grade.FullName);
            }

            allGrades = _context.Grades.Select(x => x.FullName).Distinct().ToList();
            allGrades.Sort();
            GradesList = new List<SelectListItem>();
            foreach (string grade in allGrades)
            {
                if (!takenGrades.Contains(grade))
                {
                    GradesList.Add(new SelectListItem { Value = $"{grade}", Text = $"{grade}" });
                }
            }
            #endregion

            var subjectsQuery = _context.Subjects.Include(s => s.Teachers).Where(t => t.Teachers.Any(k => k.Id == teacher)).OrderBy(s => s.Name);
            SubjectNameSL = new SelectList(subjectsQuery.AsNoTracking(), "Id", "Name"); //list, id, value

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string SelectedGrade, string SelectedSubject)
        {
            int gradeId = 0;
            foreach (var x in _context.Grades)
            {
                if (x.FullName == SelectedGrade)
                {
                    gradeId = x.Id;
                }
            }
            
            if (await TryUpdateModelAsync<Lesson>(
                Lesson,
                "Lesson",
                i => i.Room, i => i.Subject))
            {
                Lesson.Grade = _context.Grades
                    .Where(x => x.Id == gradeId)
                    .Single();
                Lesson.Subject = _context.Subjects
                    .Where(x => x.Id == int.Parse(SelectedSubject))
                    .Single();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

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
            return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}
