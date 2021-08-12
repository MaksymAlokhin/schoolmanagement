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
    public class LendTeacherModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<Teacher> teachers;

        public LendTeacherModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _context.Books
                .Include(m => m.Teachers)
                .Include(m => m.Students)
                .FirstOrDefaultAsync(m => m.Id == id);

            teachers = await _context.Teachers
                .Include(m => m.Books)
                .ToListAsync();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, int teacherId)
        {
            var teacher = await _context.Teachers.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == teacherId);
            Book = await _context.Books.Include(m => m.Teachers).FirstOrDefaultAsync(m => m.Id == id);
            if (!teacher.Books.Contains(Book))
            {
                teacher.Books.Add(Book);
                Book.Qty--;
                _context.SaveChanges();
            }
            else
            {
                teacher.Books.Remove(Book);
                Book.Qty++;
                _context.SaveChanges();
            }
            return RedirectToPage("./LendTeacher", new { id = $"{Book.Id}" });
        }
    }
}
