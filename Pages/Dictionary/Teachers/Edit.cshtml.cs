using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly IWebHostEnvironment webHostEnvironment;

        public EditModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }
        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };
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

            if (await TryUpdateModelAsync<Teacher>(
                            teacherToUpdate,
                            "Teacher",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic))
            {
                UpdateTeacherSubjects(selectedSubjects, teacherToUpdate);
            }

            if (FormFile != null)
            {
                var ext = Path.GetExtension(FormFile.FileName).ToLowerInvariant();
                if (!string.IsNullOrEmpty(ext) || permittedExtensions.Contains(ext))
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, @"images\avatars"); //webHost adds 'wwwroot'
                    var trustedFileNameForFileStorage = Path.GetRandomFileName();
                    trustedFileNameForFileStorage = trustedFileNameForFileStorage.Substring(0, 8)
                        + trustedFileNameForFileStorage.Substring(9) + ext;
                    var filePath = Path.Combine(uploadsFolder, trustedFileNameForFileStorage);

                    using (var fileStream = System.IO.File.Create(filePath))
                    {
                        await FormFile.CopyToAsync(fileStream);
                    }

                    var oldFile = teacherToUpdate.ProfilePicture;
                    var fileToDelete = string.Empty;
                    if (!string.IsNullOrEmpty(oldFile))
                    {
                        fileToDelete = Path.Combine(uploadsFolder, oldFile);
                    }

                    if (System.IO.File.Exists(fileToDelete))
                    {
                        System.IO.File.Delete(fileToDelete);
                    }

                    teacherToUpdate.ProfilePicture = trustedFileNameForFileStorage;
                }
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
