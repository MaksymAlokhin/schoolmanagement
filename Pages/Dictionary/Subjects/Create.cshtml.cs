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

namespace sms.Pages.Subjects
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
            var teachersQuery = _context.Teachers.OrderBy(r => r.LastName);
            TeacherNameSL = new SelectList(teachersQuery, "Id", "FullName"); //list, id, value
            return Page();
        }
        public List<int> selectedTeachers { get; set; }
        public SelectList TeacherNameSL { get; set; }

        [BindProperty]
        public Subject Subject { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int[] selectedTeachers)
        {
            var newSubject = new Subject();
            newSubject.Teachers = new List<Teacher>();

            if (await TryUpdateModelAsync<Subject>(
                            newSubject,
                            "Subject", i => i.Name))
            {
                if (selectedTeachers.Any())
                {
                    foreach (var teacher in selectedTeachers)
                    {
                        newSubject.Teachers.Add(_context.Teachers.Single(s => s.Id == teacher));
                    }
                }

                _context.Subjects.Add(Subject);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
