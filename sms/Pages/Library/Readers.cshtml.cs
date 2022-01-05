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
using sms.Data;
using sms.Models;

namespace sms.Pages.Library
{
    [Authorize(Roles = "Адміністратор, Бібліотекар")]
    public class ReadersModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public PaginatedList<Reader> Reader { get; set; }
        public IList<Reader> readersList { get; set; } = new List<Reader>();
        public string NameSort { get; set; }
        public string PositionSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public ReadersModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
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
            PositionSort = sortOrder == "position" ? "position_desc" : "position";
            
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            //Get data from DB
            //Отримання даних з БД
            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);
            var students = await _context.Students.Include(s => s.Books).Include(s => s.Grade).Where(s => s.Books.Any(b => b.Id == id)).ToListAsync();
            var teachers = await _context.Teachers.Include(s => s.Books).Where(s => s.Books.Any(b => b.Id == id)).ToListAsync();

            //Create a list of readers from students and teachers
            //Створення списку читачів з вчителів і учнів
            foreach (var student in students)
            {
                readersList.Add(new Reader { Id = student.Id, Name = student.FullName, Type = Type.Учень, Grade = student.Grade.FullName });
            }
            foreach (var teacher in teachers)
            {
                readersList.Add(new Reader { Id = teacher.Id, Name = teacher.FullName, Type = Type.Персонал, Grade = "" });
            }

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                readersList = readersList.Where(s => s.Name.ToLowerInvariant().Contains(searchString.ToLowerInvariant())
                                       || s.Grade.ToLowerInvariant().Contains(searchString.ToLowerInvariant())
                                       || s.Type.ToString().ToLowerInvariant().ToString().Contains(searchString.ToLowerInvariant()))
                                    .ToList();
            }
            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    readersList = readersList
                        .OrderByDescending(s => s.Name)
                        .ToList();
                    break;
                case "position":
                    readersList = readersList
                        .OrderBy(s => s.Type)
                        .ThenBy(s => s.Grade)
                        .ToList();
                    break;
                case "position_desc":
                    readersList = readersList
                        .OrderByDescending(s => s.Type)
                        .ThenByDescending(s => s.Grade)
                        .ToList();
                    break;
                default:
                    readersList = readersList
                        .OrderBy(s => s.Name)
                        .ToList();
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            Reader = PaginatedList<Reader>.CreateFromList(
                readersList, pageIndex ?? 1, pageSize);

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, int? studentId, int? teacherId, string sortOrder, 
            string currentFilter, int? pageIndex)
        {            
            Book = await _context.Books
                .Include(m => m.Teachers)
                .Include(m => m.Students)
                .FirstOrDefaultAsync(m => m.Id == id);

            //Take book from student
            //Забрати книгу в учня
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

            //Take book from teacher
            //Забрати книгу у вчителя
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

            return RedirectToPage("./Readers", new
            {
                id = $"{id}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}",
                pageIndex = $"{pageIndex}"
            });
        }
    }
    public class Reader
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int Id { get; set; }
        public string Grade { get; set; }
    }
    public enum Type
    {
        Учень,
        Персонал
    }
}
