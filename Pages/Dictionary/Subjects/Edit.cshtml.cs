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

namespace sms.Pages.Subjects
{
    [Authorize(Roles = "Адміністратор")]
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Subject Subject { get; set; }
        public List<int> selectedTeachers { get; set; }
        public SelectList TeacherNameSL { get; set; }
        public int? PageIndex { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            
            if (id == null)
            {
                return NotFound();
            }

            var teachersQuery = _context.Teachers.OrderBy(r => r.LastName);
            TeacherNameSL = new SelectList(teachersQuery.AsNoTracking(), "Id", "FullName"); //list, id, value


            Subject = await _context.Subjects.Include(s => s.Teachers).FirstOrDefaultAsync(m => m.Id == id);

            //Generate selected items
            selectedTeachers = new List<int>();
            foreach (var teacher in Subject.Teachers)
            {
                selectedTeachers.Add(teacher.Id);
            }

            if (Subject == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? pageIndex, int? id, int[] selectedTeachers)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var subjectToUpdate = _context.Subjects.Include(t => t.Teachers).Single(t => t.Id == id);

            if (await TryUpdateModelAsync<Subject>(
                            subjectToUpdate,
                            "Subject", i => i.Name))
            {
                UpdateSubjectTeachers(selectedTeachers, subjectToUpdate);
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectExists(Subject.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index", new { pageIndex = $"{pageIndex}" });
        }

        private bool SubjectExists(int id)
        {
            return _context.Subjects.Any(e => e.Id == id);
        }

        private void UpdateSubjectTeachers(int[] selectedTeachers, Subject subjectToUpdate)
        {
            {
                if (selectedTeachers == null)
                {
                    subjectToUpdate.Teachers = new List<Teacher>();
                    return;
                }

                var selectedTeachersHS = new HashSet<int>(selectedTeachers);
                var subjectTeachers = new HashSet<int>
                    (subjectToUpdate.Teachers.Select(s => s.Id));
                foreach (var teacher in _context.Teachers)
                {
                    if (selectedTeachersHS.Contains(teacher.Id))
                    {
                        if (!subjectTeachers.Contains(teacher.Id))
                        {
                            subjectToUpdate.Teachers.Add(teacher);
                        }
                    }
                    else
                    {
                        if (subjectTeachers.Contains(teacher.Id))
                        {
                            var subjectToRemove = subjectToUpdate.Teachers.Single(
                                                            s => s.Id == teacher.Id);
                            subjectToUpdate.Teachers.Remove(subjectToRemove);
                        }
                    }
                }
            }
        }

    }
}
