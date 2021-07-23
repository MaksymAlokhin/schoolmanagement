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

namespace sms.Pages.Grades
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
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
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Grade> Grade { get; set; }
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

            IQueryable<Grade> gradesIQ = from s in _context.Grades
                                         select s;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                gradesIQ = gradesIQ.Where(s => s.Number.ToString().Contains(searchString)
                                       || s.Letter.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    gradesIQ = gradesIQ.OrderByDescending(s => s.Number).ThenBy(s => s.Letter);
                    break;
                default:
                    gradesIQ = gradesIQ.OrderBy(s => s.Number).ThenBy(s => s.Letter);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 5);
            Grade = await PaginatedList<Grade>.CreateAsync(
                gradesIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
