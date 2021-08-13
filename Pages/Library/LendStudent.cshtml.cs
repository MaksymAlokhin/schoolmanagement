using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Library
{
    [Authorize(Roles = "Адміністратор, Бібліотекар")]
    public class LendStudentModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> GradesSL;
        public int selectedGrade { get; set; }
        public List<SelectListItem> StudentsSL { get; set; }
        public IList<Student> students;
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public LendStudentModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder, string searchString, int id, int gradeId)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CurrentFilter = searchString;

            selectedGrade = gradeId;

            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);

            IQueryable<Student>studentsIQ = _context.Students
                .Include(m => m.Books)
                .Where(m => m.GradeId == gradeId);

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ
                        .OrderByDescending(s => s.LastName)
                        .ThenByDescending(s => s.FirstName)
                        .ThenByDescending(s => s.Patronymic);
                    break;
                default:
                    studentsIQ = studentsIQ
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic);
                    break;
            }

            students = await studentsIQ.ToListAsync();

            GradesSL = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, int studentId)
        {
            var student = await _context.Students.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == studentId);
            Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
            if (!student.Books.Contains(Book))
            {
                student.Books.Add(Book);
                Book.Qty--;
                _context.SaveChanges();
            }
            else
            {
                student.Books.Remove(Book);
                Book.Qty++;
                _context.SaveChanges();
            }
            return RedirectToPage("./LendStudent", new { id = $"{Book.Id}", gradeId = $"{student.GradeId}" });
        }
    }
}
