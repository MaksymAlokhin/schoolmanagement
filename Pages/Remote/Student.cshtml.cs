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
using Microsoft.Extensions.Configuration;

namespace sms.Pages.Remote
{
    [Authorize(Roles = "Адміністратор, Вчитель, Батьки")]
    public class StudentModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public List<SelectListItem> grades;
        public int selectedGrade;
        public int selectedSubject;
        public string DateSort { get; set; }
        public string CurrentSort { get; set; }
        public List<SelectListItem> SubjectsSL { get; set; }
        public PaginatedList<Assignment> Assignment { get; set; }

        public StudentModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        //public IList<Assignment> Assignment { get;set; }

        public async Task OnGetAsync(int? pageIndex, string sortOrder, int gradeId = 0, int subjectId = 0)
        {
            selectedGrade = gradeId;
            selectedSubject = subjectId;
            CurrentSort = sortOrder;

            DateSort = String.IsNullOrEmpty(sortOrder) ? "date" : "";

            if (gradeId != 0)
            {
                SubjectsSL = _context.Curricula
                    .AsNoTracking()
                    .Include(g => g.Subject)
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.Subject.Name)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.SubjectId.ToString(),
                        Text = g.Subject.Name
                    }).ToList();
            }
            else
            {
                SubjectsSL = new List<SelectListItem>()
                    {
                        new SelectListItem
                        {
                            Value = null,
                            Text = " "
                        }
                    };

            }

            grades = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                grades.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            if (gradeId != 0 && subjectId != 0)
            {

                IQueryable<Assignment> assignmentsIQ = _context.Assignments
                    .Where(a => a.GradeId == gradeId && a.SubjectId == subjectId);

                switch (sortOrder)
                {
                    case "date":
                        assignmentsIQ = assignmentsIQ.OrderBy(s => s.DateOfPost);
                        break;
                    default:
                        assignmentsIQ = assignmentsIQ.OrderByDescending(s => s.DateOfPost);
                        break;
                }

                //var pageSize = Configuration.GetValue("PageSize", 10);
                var pageSize = 2;
                Assignment = await PaginatedList<Assignment>.CreateAsync(
                    assignmentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);


                //Assignment = await assignmentsIQ.AsNoTracking().ToListAsync();
            }
            //give an empty list
            else
            {
                Assignment = await PaginatedList<Assignment>.CreateAsync(
                 _context.Assignments.Where(x => x.DateOfPost == new DateTime(1, 1, 1)).AsNoTracking(), pageIndex ?? 1, 1);
            }
        }
        public JsonResult OnGetSubjects(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {

                IEnumerable<SelectListItem> subjects = _context.Curricula
                    .AsNoTracking()
                    .Include(g => g.Subject)
                    .Where(g => g.GradeId == int.Parse(gradeId))
                    .OrderBy(g => g.Subject.Name)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.SubjectId.ToString(),
                        Text = g.Subject.Name
                    }).ToList();

                //var subj = new SelectList(subjects, "Value", "Text");

                return new JsonResult(subjects);
            }
            return null;
        }
    }
}
