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
using sms;
using sms.Data;

namespace sms.Pages.Students
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
        public SelectList GradeNumbersSL { get; set; }
        public int GradeNumber { get; set; }
        public SelectList GradeLettersSL { get; set; }
        public string GradeLetter { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };
        public string Gender { get; set; } = "Не вказано";
        public string[] Genders = new[] { "Жіноча", "Чоловіча", "Не вказано" };


        public IActionResult OnGet()
        {
            GradeNumbersSL = new SelectList(_context.Grades.OrderBy(x => x.Number).Select(x => x.Number).Distinct());
            GradeLettersSL = new SelectList(_context.Grades.OrderBy(x => x.Letter).Select(x => x.Letter).Distinct());
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int? id, int GradeNumber, string GradeLetter, string Gender)
        {
            var newStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                                            newStudent,
                                            "Student",
                                            i => i.LastName, i => i.FirstName, i => i.Patronymic,
                                            i => i.DateOfBirth, i => i.Address))
            {
                newStudent.Grade = _context.Grades.Where(x => x.Number == GradeNumber).Where(x => x.Letter == GradeLetter).Single();
                if (Gender == "Не вказано") newStudent.Gender = null;
                else newStudent.Gender = Gender;
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
                        newStudent.ProfilePicture = trustedFileNameForFileStorage;
                    }
                }

                _context.Students.Add(newStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");
        }
    }
}
