using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sms;
using sms.Data;

namespace sms.Pages.Students
{
    [Authorize(Roles = "Адміністратор")]
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;

        public IndexModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string GradeSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Student> Student { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            GradeSort = sortOrder == "Grade" ? "grade_desc" : "Grade";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Student> studentsIQ = _context.Students.Include(i => i.Grade);

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.DateOfBirth);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.DateOfBirth);
                    break;
                case "Grade":
                    studentsIQ = studentsIQ.OrderBy(s => s.Grade.Number).ThenBy(s=>s.Grade.Letter);
                    break;
                case "grade_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Grade.Number).ThenBy(s => s.Grade.Letter);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.LastName);
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 10);
            Student = await PaginatedList<Student>.CreateAsync(
                studentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
