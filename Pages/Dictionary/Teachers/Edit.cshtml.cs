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

namespace sms.Pages.Teachers
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
        public Teacher Teacher { get; set; }
        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjectsQuery = _context.Subjects.OrderBy(r => r.Name);
            SubjectNameSL = new SelectList(subjectsQuery.AsNoTracking(), "Id", "Name"); //list, id, value

            Teacher = await _context.Teachers.Include(t => t.Subjects).FirstOrDefaultAsync(m => m.Id == id);

            //To make items preselected:
            //https://docs.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-select-tag-helper
            //https://www.learnrazorpages.com/razor-pages/tag-helpers/select-tag-helper

            //Generate selected items
            selectedSubjects = new List<int>();
            foreach (var subject in Teacher.Subjects)
            {
                selectedSubjects.Add(subject.Id);
            }

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }

        
        
        
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, int[] selectedSubjects)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var teacherToUpdate = _context.Teachers.Include(t => t.Subjects).Single(t => t.Id == id);
            //Teacher.Subjects = new List<Subject>();

            if (await TryUpdateModelAsync<Teacher>(
                            teacherToUpdate,
                            "Teacher",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic))
            {
                UpdateTeacherSubjects(selectedSubjects, teacherToUpdate);
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(Teacher.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index");
        }

        private bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.Id == id);
        }

        private void UpdateTeacherSubjects(int[] selectedSubjects, Teacher teacherToUpdate)
        {
            {
                if (selectedSubjects == null)
                {
                    teacherToUpdate.Subjects = new List<Subject>();
                    return;
                }

                var selectedSubjectsHS = new HashSet<int>(selectedSubjects);
                var teacherSubjects = new HashSet<int>
                    (teacherToUpdate.Subjects.Select(s => s.Id));
                foreach (var subject in _context.Subjects)
                {
                    if (selectedSubjectsHS.Contains(subject.Id))
                    {
                        if (!teacherSubjects.Contains(subject.Id))
                        {
                            teacherToUpdate.Subjects.Add(subject);
                        }
                    }
                    else
                    {
                        if (teacherSubjects.Contains(subject.Id))
                        {
                            var subjectToRemove = teacherToUpdate.Subjects.Single(
                                                            s => s.Id == subject.Id);
                            teacherToUpdate.Subjects.Remove(subjectToRemove);
                        }
                    }
                }
            }
        }
    }
}
