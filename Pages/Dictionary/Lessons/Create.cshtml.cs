using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sms.Data;
using sms.Models;

namespace sms.Pages.Lessons
{
    [Authorize(Roles = "Адміністратор")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GradeId"] = new SelectList(_context.Grades, "Id", "Id");
        ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name");
        ViewData["TeacherId"] = new SelectList(_context.Teachers, "Id", "FirstName");
            return Page();
        }

        [BindProperty]
        public Lesson Lesson { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lessons.Add(Lesson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
