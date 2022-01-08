using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ganss.XSS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.Remote
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int selectedGrade;
        public int selectedSubject;

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int gradeId, int subjectId)
        {
            selectedGrade = gradeId;
            selectedSubject = subjectId;

            //Initialize assignment with static data
            //Ініціалізація даними, що не редагуються
            Assignment = new Assignment();
            Assignment.GradeId = gradeId;
            Assignment.SubjectId = subjectId;
            Grade grade = _context.Grades.Single(g => g.Id == gradeId);
            Subject subject = _context.Subjects.Single(s => s.Id == subjectId);
            int teacherId = _context.Curricula
                .Where(c => c.GradeId == gradeId && c.SubjectId == subjectId)
                .Select(c => c.TeacherId).Single();
            Teacher teacher = _context.Teachers.Single(t => t.Id == teacherId);
            Assignment.Grade = grade;
            Assignment.Subject = subject;
            Assignment.Teacher = teacher;
            Assignment.TeacherId = teacherId;
            Assignment.DateOfPost = DateTime.Now;

            return Page();
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //HtmlSanitizer – cleans html from constructs that can be used for cross site scripting (XSS)
            //HtmlSanitizer - захист від XSS
            var sanitizer = new HtmlSanitizer();
            var sanitized = sanitizer.Sanitize(Assignment.Post);
            Assignment.Post = sanitized;

            //Save new assignment to DB
            //Збереження даних у БД
            _context.Assignments.Add(Assignment);
            await _context.SaveChangesAsync();

            Log.Information("Користувач створив завдання для дистанційного навчання " +
                "для класу {0} з предмету {1}", Assignment.GradeId, Assignment.SubjectId);

            return RedirectToPage("./Index", new { gradeId = $"{Assignment.GradeId}", subjectId = $"{Assignment.SubjectId}" });
        }
    }
}
