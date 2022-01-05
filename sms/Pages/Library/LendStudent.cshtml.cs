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
    public class LendStudentModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public List<SelectListItem> GradesSL;
        public int selectedGrade { get; set; }
        public List<SelectListItem> StudentsSL { get; set; }
        public PaginatedList<Student> Student { get; set; }
        public string NameSort { get; set; }
        public string GradeSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public LendStudentModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, string sortOrder, string currentFilter,
            string searchString, int? gradeId, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            GradeSort = sortOrder == "grade" ? "grade_desc" : "grade";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            if (gradeId != null)
                selectedGrade = (int)gradeId;
            else selectedGrade = 0;

            Book = await _context.Books
                .Include(m => m.Students)
                .Include(m => m.Teachers)
                .FirstOrDefaultAsync(m => m.Id == id);

            //Grades selectlist
            //Випадаючий список класів
            GradesSL = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            GradesSL.Add(new SelectListItem("Всі класи", "0"));
            foreach (Grade g in grad)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            IEnumerable<Student> studentsIE;

            //Only students of a certain grade
            //Лише учні певного класу
            if (selectedGrade > 0)
            {
                studentsIE = _context.Students
                    .Include(m => m.Books)
                    .Include(m => m.Grade)
                    .Where(m => m.GradeId == selectedGrade);
            }
            //All students
            //Усі учні
            else
            {
                studentsIE = _context.Students
                    .Include(m => m.Books)
                    .Include(m => m.Grade);
            }

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIE = studentsIE.AsEnumerable().Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString)
                                       || s.Grade.FullName.Contains(searchString));

            }
            
            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    studentsIE = studentsIE
                        .OrderByDescending(s => s.LastName)
                        .ThenByDescending(s => s.FirstName)
                        .ThenByDescending(s => s.Patronymic);
                    break;
                case "grade":
                    studentsIE = studentsIE
                        .OrderBy(s => s.Grade.Number)
                        .ThenBy(s => s.Grade.Letter);
                    break;
                case "grade_desc":
                    studentsIE = studentsIE
                        .OrderByDescending(s => s.Grade.Number)
                        .ThenByDescending(s => s.Grade.Letter);
                    break;
                default:
                    studentsIE = studentsIE
                        .OrderBy(s => s.LastName)
                        .ThenBy(s => s.FirstName)
                        .ThenBy(s => s.Patronymic);
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            Student = PaginatedList<Student>.CreateFromList(
                studentsIE.ToList(), pageIndex ?? 1, pageSize);

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, int studentId, string sortOrder, 
            string currentFilter, int gradeId, int? pageIndex)
        {
            var student = await _context.Students.Include(m => m.Books).FirstOrDefaultAsync(m => m.Id == studentId);
            Book = await _context.Books.Include(m => m.Students).FirstOrDefaultAsync(m => m.Id == id);
            
            //Take or give book to a student
            //Забрати чи видати книгу учневі
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

            return RedirectToPage("./LendStudent", new
            {
                id = $"{id}",
                gradeId = $"{gradeId}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}",
                pageIndex = $"{pageIndex}"
            });
        }
    }
}
