using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sms.Data;
using sms.Models;

namespace sms.Pages.Dictionary.Curricula
{
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> GradesList { get; set; }

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

            ViewData["SubjectId"] = new SelectList(_context.Subjects.OrderBy(s => s.Name), "Id", "Name");
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
    }
}
