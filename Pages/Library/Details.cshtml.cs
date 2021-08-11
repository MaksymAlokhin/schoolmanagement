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

namespace sms.Pages.Library
{
    [Authorize(Roles = "Адміністратор, Бібліотекар")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> grades;
        public int selectedGrade;
        public int selectedStudent;
        public int selectedTeacher;
        public List<SelectListItem> StudentsSL { get; set; }
        public List<SelectListItem> TeachersSL { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, int gradeId = 0)
        {
            selectedGrade = gradeId;

            if (id == null)
            {
                return NotFound();
            }

            if (gradeId != 0)
            {
                StudentsSL = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == gradeId)
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();
            }
            else
            {
                StudentsSL = new List<SelectListItem>()
                {
                    new SelectListItem
                    {
                        Value = null,
                        Text = " "
                    }
                };
            }

            TeachersSL = _context.Teachers
                .AsNoTracking()
                .Select(g =>
                new SelectListItem
                {
                    Value = g.Id.ToString(),
                    Text = g.FullName
                }).ToList();

            grades = new List<SelectListItem>();
            var grad = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grad)
            {
                grades.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            Book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }

            return RedirectToPage("./Details", new { id = id });
        }

        public JsonResult OnGetStudents(string gradeId)
        {
            if (!string.IsNullOrWhiteSpace(gradeId))
            {
                IEnumerable<SelectListItem> students = _context.Students
                    .AsNoTracking()
                    .Where(g => g.GradeId == int.Parse(gradeId))
                    .OrderBy(g => g.LastName)
                    .ThenBy(g => g.FirstName)
                    .Select(g =>
                    new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.ShortName
                    }).ToList();

                //return new JsonResult(new[] { subjects, students });

                return new JsonResult(students);
            }
            return null;
        }
    }
}
