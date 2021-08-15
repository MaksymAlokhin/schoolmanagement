using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Dictionary.Curricula
{
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> GradesList { get; set; }
        public List<SelectListItem> SubjectsSL { get; set; }
        public int? PageIndex { get; set; }

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curriculum Curriculum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            
            if (id == null)
            {
                return NotFound();
            }

            Curriculum = await _context.Curricula
                .Include(c => c.Grade)
                .Include(c => c.Subject)
                .Include(c => c.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Curriculum == null)
            {
                return NotFound();
            }

            var allGrades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            GradesList = new List<SelectListItem>();
            foreach (Grade grade in allGrades)
            {
                GradesList.Add(new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}" });
            }

            var allSubjects = _context.Subjects.OrderBy(s => s.Name).Where(s => s.Teachers.Any(t => t.Id == Curriculum.TeacherId));
            SubjectsSL = new List<SelectListItem>();

            foreach (var subj in allSubjects)
            {

                SubjectsSL.Add(new SelectListItem
                {
                    Value = subj.Id.ToString(),
                    Text = subj.Name
                });
            }


            //ViewData["SubjectId"] = new SelectList(_context.Subjects.OrderBy(s => s.Name), "Id", "Name");
            ViewData["TeacherId"] = new SelectList(_context.Teachers.OrderBy(t => t.LastName).ThenBy(t => t.FirstName), "Id", "FullName");
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

            _context.Attach(Curriculum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumExists(Curriculum.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index", new { gradeId = $"{Curriculum.GradeId}", pageIndex = $"{pageIndex}" });
        }

        private bool CurriculumExists(int id)
        {
            return _context.Curricula.Any(e => e.Id == id);
        }
        public JsonResult OnGetSubjects(string teacherId)
        {
            if (!string.IsNullOrWhiteSpace(teacherId))
            {

                IEnumerable<SelectListItem> subjects = _context.Subjects.AsNoTracking()
                        .OrderBy(n => n.Name)
                        .Where(n => n.Teachers.Any(t => t.Id == int.Parse(teacherId)))
                        .Select(n =>
                           new SelectListItem
                           {
                               Value = n.Id.ToString(),
                               Text = n.Name
                           }).ToList();
                //var subj = new SelectList(subjects, "Value", "Text");

                return new JsonResult(subjects);
            }
            return null;
        }
    }
}
