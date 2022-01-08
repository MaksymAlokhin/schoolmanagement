using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Serilog;

namespace sms.Pages.Curricula
{
    [Authorize(Roles = "Адміністратор")]
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public List<SelectListItem> grades;
        public int selectedGrade;
        public string NameSort { get; set; }
        public string SubjSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Curriculum> Curriculum { get; set; }

        public IndexModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, int gradeId = 1)
        {
            selectedGrade = gradeId;

            CurrentSort = sortOrder;

            SubjSort = String.IsNullOrEmpty(sortOrder) ? "subj_desc" : "";
            NameSort = sortOrder == "name" ? "name_desc" : "name";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Curriculum> curriculaIQ = _context.Curricula.Include(c => c.Subject).Include(c => c.Teacher);

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                curriculaIQ = curriculaIQ.Where(s => s.Teacher.LastName.Contains(searchString)
                                       || s.Teacher.FirstName.Contains(searchString)
                                       || s.Teacher.Patronymic.Contains(searchString)
                                       || s.Subject.Name.Contains(searchString));
            }

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "subj_desc":
                    curriculaIQ = curriculaIQ.OrderByDescending(s => s.Subject.Name);
                    break;
                case "name":
                    curriculaIQ = curriculaIQ.OrderBy(s => s.Teacher.LastName);
                    break;
                case "name_desc":
                    curriculaIQ = curriculaIQ.OrderByDescending(s => s.Teacher.LastName);
                    break;
                default:
                    curriculaIQ = curriculaIQ.OrderBy(s => s.Subject.Name);
                    break;
            }

            //Grades dropdown
            //Випадаючий список класу
            grades = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                grades.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            Curriculum = await PaginatedList<Curriculum>.CreateAsync(
                curriculaIQ.Where(с => с.GradeId == gradeId).AsNoTracking(), pageIndex ?? 1, pageSize);

            Log.Information("Користувач переглядає сторінку {0} навчального плану", pageIndex ?? 1);
        }
    }
}
