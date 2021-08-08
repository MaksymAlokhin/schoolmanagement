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
using sms.Data;
using sms.Models;

namespace sms.Pages.Teachers
{
    [Authorize(Roles = "Адміністратор")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CreateModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };

        [BindProperty]
        public Teacher Teacher { get; set; }

        public IActionResult OnGet()
        {
            var subjectsQuery = _context.Subjects.OrderBy(r => r.Name);
            SubjectNameSL = new SelectList(subjectsQuery, "Id", "Name"); //list, id, value

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int[] selectedSubjects)
        {
            var newTeacher = new Teacher();
            newTeacher.Subjects = new List<Subject>();

            if (await TryUpdateModelAsync<Teacher>(
                            newTeacher,
                            "Teacher",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic))
            {
                foreach(var subj in selectedSubjects)
                {
                    newTeacher.Subjects.Add(_context.Subjects.Single(s => s.Id == subj));
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
                        newTeacher.ProfilePicture = trustedFileNameForFileStorage;
                    }
                }

                _context.Teachers.Add(newTeacher);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
