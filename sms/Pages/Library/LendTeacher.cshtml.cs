using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.Library
{
    [Authorize(Roles = "Адміністратор, Бібліотекар")]
    public class LendTeacherModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public PaginatedList<Teacher> Teacher { get; set; }
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public LendTeacherModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, string sortOrder, 
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            Book = await _context.Books
                .Include(m => m.Teachers)
                .Include(m => m.Students)
                .FirstOrDefaultAsync(m => m.Id == id);

            IQueryable<Teacher> teachersIQ = _context.Teachers.Include(m => m.Books);

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                teachersIQ = teachersIQ.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    teachersIQ = teachersIQ
                        .OrderByDescending(s => s.LastName)
                        .ThenByDescending(s => s.FirstName)
                        .ThenByDescending(s => s.Patronymic);
                    break;
                default:
                    teachersIQ = teachersIQ
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic);
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            Teacher = await PaginatedList<Teacher>.CreateAsync(
                teachersIQ, pageIndex ?? 1, pageSize);

            Log.Information("Користувач переглядає сторінку {0} видачі книг вчителю", pageIndex ?? 1);

            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(int id, int teacherId, 
            string sortOrder, string currentFilter, int? pageIndex)
        {
            var teacher = await _context.Teachers.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == teacherId);
            Book = await _context.Books.Include(m => m.Teachers).FirstOrDefaultAsync(m => m.Id == id);
            
            //Take or give book to a teacher
            //Забрати чи видати книгу вчителю
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

            return RedirectToPage("./LendTeacher", new
            {
                id = $"{id}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}",
                pageIndex = $"{pageIndex}"
            });
        }
    }
}
