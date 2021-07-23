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

namespace sms.Pages.Teachers
{
    [Authorize(Roles = "Адміністратор")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        [BindProperty]
        public Teacher Teacher { get; set; }

        public IActionResult OnGet()
        {
            var subjectsQuery = _context.Subjects.OrderBy(r => r.Name);
            SubjectNameSL = new SelectList(subjectsQuery, "Id", "Name"); //list, id, value

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int[] selectedSubjects)
        {
            var newTeacher = new Teacher();
            newTeacher.Subjects = new List<Subject>();

            if (await TryUpdateModelAsync<Teacher>(
                            newTeacher,
                            "Teacher",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic))
            {
                foreach(var subj in selectedSubjects)
                {
                    newTeacher.Subjects.Add(_context.Subjects.Single(s => s.Id == subj));
                }

                _context.Teachers.Add(newTeacher);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
