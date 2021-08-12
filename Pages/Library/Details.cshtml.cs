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
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> grades;
        public int selectedGrade;
        public int selectedStudent;
        public int selectedTeacher;
        public List<SelectListItem> StudentsSL { get; set; }
        public List<SelectListItem> TeachersSL { get; set; }
        public List<Student> students;
        public List<Teacher> teachers;

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, int gradeId = 0)
        {
            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);

            students = Book.Students.ToList();
            teachers = Book.Teachers.ToList();

            if (Book == null)
            {
                return NotFound();
            }

            selectedGrade = gradeId;

            if (id == null)
            {
                return NotFound();
            }

            if (gradeId != 0)
            {
                StudentsSL = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();
            }
            else
            {
                StudentsSL = new List<SelectListItem>()
                {
                    new SelectListItem
                    {
                        Value = null,
                        Text = " "
                    }
                };
            }

            TeachersSL = _context.Teachers
                .AsNoTracking()
                .Select(g =>
                new SelectListItem
                {
                    Value = g.Id.ToString(),
                    Text = g.FullName
                }).ToList();

            grades = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                grades.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Details", new { id = id });
        }

        public async Task<IActionResult> OnPostBorrowStudent(int id, int studentId)
        {
            var student = await _context.Students.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == studentId);
            Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
            student.Books.Add(Book);
            Book.Qty--;
            _context.SaveChanges();
            return RedirectToPage("./Details", new { id = $"{Book.Id}" });
        }
        public async Task<IActionResult> OnPostBorrowTeacher(int id, int teacherId)
        {
            var teacher = await _context.Teachers.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == teacherId);
            Book = await _context.Books.Include(m => m.Teachers).FirstOrDefaultAsync(m => m.Id == id);
            teacher.Books.Add(Book);
            Book.Qty--;
            _context.SaveChanges();
            return RedirectToPage("./Details", new { id = $"{Book.Id}" });
        }
        public async Task<IActionResult> OnPostReturnStudent(int id, int studentId)
        {
            var student = await _context.Students.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == studentId);
            Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
            student.Books.Remove(Book);
            Book.Qty++;
            _context.SaveChanges();
            return RedirectToPage("./Details", new { id = $"{Book.Id}" });
        }
        public async Task<IActionResult> OnPostReturnTeacher(int id, int teacherId)
        {
            var teacher = await _context.Teachers.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == teacherId);
            Book = await _context.Books.Include(m => m.Teachers).FirstOrDefaultAsync(m => m.Id == id);
            teacher.Books.Remove(Book);
            Book.Qty++;
            _context.SaveChanges();
            return RedirectToPage("./Details", new { id = $"{Book.Id}" });
        }

        public JsonResult OnGetStudents(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {
                IEnumerable<SelectListItem> students = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == int.Parse(gradeId))
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();

                //return new JsonResult(new[] { subjects, students });

                return new JsonResult(students);
            }
            return null;
        }
    }
}
