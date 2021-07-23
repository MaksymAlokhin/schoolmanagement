using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sms;
using sms.Data;

namespace sms.Pages.Students
{
    [Authorize(Roles = "Адміністратор")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList GradeNumbersSL { get; set; }
        public int GradeNumber { get; set; }
        public SelectList GradeLettersSL { get; set; }
        public string GradeLetter { get; set; }

        public IActionResult OnGet()
        {
            GradeNumbersSL = new SelectList(_context.Grades.OrderBy(x => x.Number).Select(x => x.Number).Distinct());
            GradeLettersSL = new SelectList(_context.Grades.OrderBy(x => x.Letter).Select(x => x.Letter).Distinct());
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int? id, int GradeNumber, string GradeLetter)
        {
            var newStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                                            newStudent,
                                            "Student",
                                            i => i.LastName, i => i.FirstName, i => i.Patronymic,
                                            i => i.DateOfBirth, i => i.Address))
            {
                newStudent.Grade = _context.Grades.Where(x => x.Number == GradeNumber).Where(x => x.Letter == GradeLetter).Single();

                _context.Students.Add(newStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
