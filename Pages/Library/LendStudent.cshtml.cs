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
        public List<Student> students;

        public LendStudentModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, int gradeId)
        {
            selectedGrade = gradeId;

            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);

            students = await _context.Students
                .Include(m => m.Books)
                .Where(m => m.GradeId == gradeId)
                .ToListAsync();

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
