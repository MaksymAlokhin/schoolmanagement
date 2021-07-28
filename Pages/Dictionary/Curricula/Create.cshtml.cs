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
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> GradesList { get; set; }
        public List<SelectListItem> SubjectsSL { get; set; }

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int gradeId = 1)
        {
            Curriculum = new Curriculum();
            Curriculum.GradeId = gradeId;
            Curriculum.Quantity = 1;
            var allGrades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            GradesList = new List<SelectListItem>();
            foreach (Grade grade in allGrades)
            {
                GradesList.Add(new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}" });
            }

            SubjectsSL = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };

            ViewData["TeacherId"] = new SelectList(_context.Teachers.OrderBy(t => t.LastName).ThenBy(t => t.FirstName), "Id", "FullName");
            return Page();
        }

        [BindProperty]
        public Curriculum Curriculum { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Curricula.Add(Curriculum);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { gradeId = $"{Curriculum.GradeId}" });
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
