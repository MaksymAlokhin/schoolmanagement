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

namespace sms.Pages.Teachers
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
        public string SubjectSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Teacher> Teacher { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder; 
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            SubjectSort = sortOrder == "subj" ? "subj_desc" : "subj";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            
            CurrentFilter = searchString;

            IQueryable<Teacher> teachersIQ = _context.Teachers
                .Include(t => t.Subjects);

            if (!String.IsNullOrEmpty(searchString))
            {
                teachersIQ = teachersIQ.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.Patronymic.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    teachersIQ = teachersIQ.OrderByDescending(s => s.LastName);
                    break;
                case "subj":
                    teachersIQ = teachersIQ.OrderBy(s => s.Subjects.First().Name);
                    break;
                case "subj_desc":
                    teachersIQ = teachersIQ.OrderByDescending(s => s.Subjects.First().Name);
                    break;
                default:
                    teachersIQ = teachersIQ.OrderBy(s => s.LastName);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 5);
            Teacher = await PaginatedList<Teacher>.CreateAsync(
                teachersIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
