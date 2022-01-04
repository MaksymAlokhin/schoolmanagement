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

namespace sms.Pages.Curricula
{
    [Authorize(Roles = "Адміністратор")]
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public List<SelectListItem> GradesList { get; set; }
        public List<SelectListItem> SubjectsSL { get; set; }
        public int? PageIndex { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curriculum Curriculum { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder,
            string currentFilter, int? pageIndex, int? id)
        {
            PageIndex = pageIndex;
            CurrentSort = sortOrder;
            CurrentFilter = currentFilter;

            if (id == null)
            {
                return NotFound();
            }

            //Load data from DB
            //Беремо навантаження з БД
            Curriculum = await _context.Curricula
                .Include(c => c.Grade)
                .Include(c => c.Subject)
                .Include(c => c.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Curriculum == null)
            {
                return NotFound();
            }

            //Grades dropdown
            //Випадаючий список класів
            var allGrades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            GradesList = new List<SelectListItem>();
            foreach (Grade grade in allGrades)
            {
                GradesList.Add(new SelectListItem { Value = $"{grade.Id}", Text = $"{grade.FullName}" });
            }

            //Subjects dropdown
            //Випадаючий список предметів
            var allSubjects = _context.Subjects.OrderBy(s => s.Name).Where(s => s.Teachers.Any(t => t.Id == Curriculum.TeacherId));
            SubjectsSL = new List<SelectListItem>();

            foreach (var subj in allSubjects)
            {

                SubjectsSL.Add(new SelectListItem
                {
                    Value = subj.Id.ToString(),
                    Text = subj.Name
                });
            }

            //Teachers dropdown
            //Випадачний список вчителів
            ViewData["TeacherId"] = new SelectList(_context.Teachers.OrderBy(t => t.LastName).ThenBy(t => t.FirstName), "Id", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string sortOrder,
            string currentFilter, int? pageIndex)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Save changes to DB
            //Збереження відредагованих змін у БД
            _context.Attach(Curriculum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumExists(Curriculum.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index", new
            {
                gradeId = $"{Curriculum.GradeId}",
                pageIndex = $"{pageIndex}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}"
            });
        }

        private bool CurriculumExists(int id)
        {
            return _context.Curricula.Any(e => e.Id == id);
        }
        
        //Load list of subjects from DB
        //Отримання даних про предмети для випадаючого списку
        public JsonResult OnGetSubjects(string teacherId)
        {
            if (!string.IsNullOrWhiteSpace(teacherId))
            {

                IEnumerable<SelectListItem> subjects = _context.Subjects.AsNoTracking()
                        .OrderBy(n => n.Name)
                        .Where(n => n.Teachers.Any(t => t.Id == int.Parse(teacherId)))
                        .Select(n =>
                           new SelectListItem
                           {
                               Value = n.Id.ToString(),
                               Text = n.Name
                           }).ToList();

                return new JsonResult(subjects);
            }
            return null;
        }
    }
}
