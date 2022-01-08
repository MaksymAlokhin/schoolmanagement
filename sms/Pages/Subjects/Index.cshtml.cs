using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace sms.Pages.Subjects
{
    [Authorize(Roles = "Адміністратор")]
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Subject> Subject { get; set; }

        public IndexModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public async Task OnGetAsync(string sortOrder,
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

            IQueryable<Subject> subjectsIQ = _context.Subjects;
            
            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                subjectsIQ = subjectsIQ.Where(s => s.Name.Contains(searchString));
            }

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    subjectsIQ = subjectsIQ.OrderByDescending(s => s.Name);
                    break;
                default:
                    subjectsIQ = subjectsIQ.OrderBy(s => s.Name);
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            Subject = await PaginatedList<Subject>.CreateAsync(
                subjectsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

            Log.Information("Користувач переглядає сторінку {0} списку предметів", pageIndex ?? 1);
        }
    }
}
