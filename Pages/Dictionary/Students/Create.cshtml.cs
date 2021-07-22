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
        public SelectList GradeLettersSL { get; set; }

        public IActionResult OnGet()
        {
            var numbersQuery = _context.Grades.OrderBy(x => x.Number).Select(x => x.Number).Distinct();
            var lettersQuery = _context.Grades.OrderBy(x => x.Letter).Select(x => x.Letter).Distinct();
            GradeNumbersSL = new SelectList(numbersQuery);
            GradeLettersSL = new SelectList(lettersQuery);
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var newStudent = new Student();

            try
            {
                if (await TryUpdateModelAsync<Student>(
                                newStudent,
                                "Student",
                                i => i.LastName, i => i.FirstName, i => i.Patronymic,
                                i => i.DateOfBirth, i => i.Address))
                {
                    var number = Convert.ToInt32(HttpContext.Request.Form["Student.Grade.Number"]);
                    var letter = Convert.ToString(HttpContext.Request.Form["Student.Grade.Letter"]);
                    newStudent.GradeId = _context.Grades.Where(x => x.Number == number).Where(x => x.Letter == letter).FirstOrDefault().Id;

                    _context.Students.Add(newStudent);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
