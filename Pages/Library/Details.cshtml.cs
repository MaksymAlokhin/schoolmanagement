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
        public List<Reader> readers { get; set; } = new List<Reader>();
        public string NameSort { get; set; }
        public string PositionSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder, string searchString, int id)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PositionSort = sortOrder == "position" ? "position_desc" : "position";
            CurrentFilter = searchString;

            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);

            var students = Book.Students.ToList();
            var teachers = Book.Teachers.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString))
                                    .ToList();
                teachers = teachers.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString))
                                    .ToList();
            }

            foreach (var student in students)
            {
                readers.Add(new Reader { Id = student.Id, Name = student.FullName, Type = Type.Учень });
            }
            foreach (var teacher in teachers)
            {
                readers.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = Type.Вчитель });
            }

            switch (sortOrder)
            {
                case "name_desc":
                    readers = readers
                        .OrderByDescending(s => s.Name)
                        .ToList();
                    break;
                case "position":
                    readers = readers
                        .OrderBy(s => s.Type)
                        .ToList();
                    break;
                case "position_desc":
                    readers = readers
                        .OrderByDescending(s => s.Type)
                        .ToList();
                    break;
                default:
                    readers = readers
                        .OrderByDescending(s => s.Name)
                        .ToList();
                    break;
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, int? studentId, int? teacherId)
        {            
            Book = await _context.Books.Include(m => m.Teachers).Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);

            if (studentId.HasValue)
            {
                var student = await _context.Students.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == studentId);
                Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
                if (student.Books.Contains(Book))
                {
                    student.Books.Remove(Book);
                    Book.Qty++;
                    _context.SaveChanges();
                }
            }
            if (teacherId.HasValue)
            {
                var teacher = await _context.Teachers.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == teacherId);
                Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
                if (teacher.Books.Contains(Book))
                {
                    teacher.Books.Remove(Book);
                    Book.Qty++;
                    _context.SaveChanges();
                }
            }
            return RedirectToPage("./Details", new { id = id });
        }
    }
    public class Reader
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int Id { get; set; }
    }
    public enum Type
    {
        Учень,
        Вчитель
    }
}
