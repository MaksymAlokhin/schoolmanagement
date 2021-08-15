using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ganss.XSS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Remote
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments
                .Include(a => a.Grade)
                .Include(a => a.Subject)
                .Include(a => a.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            Grade grade = _context.Grades.Single(g => g.Id == Assignment.GradeId);
            Subject subject = _context.Subjects.Single(s => s.Id == Assignment.SubjectId);
            int teacherId = _context.Curricula
                .Where(c => c.GradeId == Assignment.GradeId && c.SubjectId == Assignment.SubjectId)
                .Select(c => c.TeacherId).Single();
            Teacher teacher = _context.Teachers.Single(t => t.Id == teacherId);
            Assignment.Grade = grade;
            Assignment.Subject = subject;
            Assignment.Teacher = teacher;

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? pageIndex)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //HtmlSanitizer – cleans html from constructs that can be used for cross site scripting (XSS)
            var sanitizer = new HtmlSanitizer();
            var sanitized = sanitizer.Sanitize(Assignment.Post);
            Assignment.Post = sanitized;

            _context.Attach(Assignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignmentExists(Assignment.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index", new
            {
                gradeId = $"{Assignment.GradeId}",
                subjectId = $"{Assignment.SubjectId}",
                pageIndex = $"{pageIndex}"
            });
        }

        private bool AssignmentExists(int id)
        {
            return _context.Assignments.Any(e => e.Id == id);
        }
    }
}
