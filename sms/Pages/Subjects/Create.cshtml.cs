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
        public List<int> selectedTeachers { get; set; }
        public SelectList TeacherNameSL { get; set; }

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var teachersQuery = _context.Teachers
                .OrderBy(r => r.LastName)
                .ThenBy(r => r.FirstName)
                .ThenBy(r => r.Patronymic);

            //Teachers dropdown
            //Випадаючий список вчителів
            TeacherNameSL = new SelectList(teachersQuery, "Id", "FullName"); //list, id, value
            return Page();
        }

        [BindProperty]
        public Subject Subject { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int[] selectedTeachers)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Create record and fill properties with data
            //Створення запису і заповнення полів даними
            var newSubject = new Subject();
            newSubject.Teachers = new List<Teacher>();

            //Refactored because TryUpdateModelAsync fails while unit testing:
            //https://github.com/dotnet/AspNetCore.Docs/issues/14009
            //if (await TryUpdateModelAsync<Subject>(
            //                newSubject,
            //                "Subject", i => i.Name))

            newSubject.Name = Subject.Name;

            if (selectedTeachers != null && selectedTeachers.Any())
            {
                foreach (var teacher in selectedTeachers)
                {
                    newSubject.Teachers.Add(_context.Teachers.Single(s => s.Id == teacher));
                }
            }

            //Save record to DB
            //Збереження запису у БД
            _context.Subjects.Add(newSubject);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
