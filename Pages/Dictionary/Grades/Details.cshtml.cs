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

namespace sms.Pages.Grades
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Grade Grade { get; set; }
        public List<Student> Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            
            if (id == null)
            {
                return NotFound();
            }

            Grade = await _context.Grades.FirstOrDefaultAsync(m => m.Id == id);
            Student = await _context.Students
                .Where(s => s.GradeId == id)
                .OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ThenBy(s => s.Patronymic)
                .ToListAsync();

            if (Grade == null)
            {
                return NotFound();
            }
            return Page();
        }
        public JsonResult OnPostGender(int id)
        {
            var gender = _context.Students
                .Where(s => s.GradeId == id && s.Gender != null)
                .GroupBy(s => s.Gender)
                .Select(g => new Gender
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .OrderBy(s => s.Name)
                .AsNoTracking();

            return new JsonResult(gender);
        }
        public JsonResult OnPostAge(int id)
        {
            var age = _context.Students
                .Where(s => s.GradeId == id)
                .AsEnumerable()
                .GroupBy(s => s.Age)
                .Select(g => new Age
                {
                    Years = g.Key,
                    Count = g.Count()
                })
                .OrderBy(s => s.Years);

            return new JsonResult(age);
        }

    }
    public class Gender
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public class Age
    {
        public int Years { get; set; }
        public int Count { get; set; }
    }
}
