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
        public string SelectedGrade { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public int SelectedSubject { get; set; }

        public async Task<IActionResult> OnGetAsync(string day, int slot, int teacher)
        {
            Lesson = new Lesson();
            Lesson.Day = day;
            Lesson.Slot = slot;
            Teacher Teacher = _context.Teachers.Single(t => t.Id == teacher);
            Lesson.Teacher = Teacher;
            Lesson.TeacherId = teacher;

            #region Generate Droplist of available Grades for this day and slot
            var LessonsOnThisDayAndSlot = _context.Lessons.Include(l => l.Grade).Where(l => l.Day == day).Where(l => l.Slot == slot).ToList();

            List<string> allGrades = new List<string>();
            List<string> takenGrades = new List<string>();
            List<string> freeGrades = new List<string>();

            foreach (Lesson lesson in LessonsOnThisDayAndSlot)
            {
                takenGrades.Add(lesson.Grade.FullName);
            }

            allGrades = _context.Grades.OrderBy(x => x.Number).ThenBy(x => x.Letter).Select(x => x.FullName).Distinct().ToList();

            GradesList = new List<SelectListItem>();
            foreach (string grade in allGrades)
            {
                if(!takenGrades.Contains(grade))
                {
                    GradesList.Add(new SelectListItem { Value = $"{grade}", Text = $"{grade}" });
                }
            }
            GradesList.OrderBy(g => g.Value);
            #endregion

            var subjectsQuery = _context.Subjects.Include(s => s.Teachers).Where(t => t.Teachers.Any(k => k.Id == teacher)).OrderBy(s => s.Name);
            SubjectNameSL = new SelectList(subjectsQuery.AsNoTracking(), "Id", "Name"); //list, id, value

            return Page();
        }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(string SelectedGrade, string SelectedSubject)
        {
            int gradeId = 0;
            foreach (var x in  _context.Grades)
            {
                if (x.FullName == SelectedGrade)
                {
                    gradeId = x.Id;
                }
            }

            Lesson newLesson = new Lesson();
            if (await TryUpdateModelAsync<Lesson>(
                newLesson,
                "Lesson",
                i => i.Day, i => i.Slot, i=>i.TeacherId, i => i.Room))
            {
                newLesson.Grade = _context.Grades
                    .Where(x => x.Id == gradeId)
                    .Single();
                newLesson.Subject = _context.Subjects
                    .Where(x => x.Id == int.Parse(SelectedSubject))
                    .Single();
                _context.Lessons.Add(newLesson);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
            }
            return RedirectToPage("./Index", new { day = $"{Lesson.Day}" });
        }
    }
}
