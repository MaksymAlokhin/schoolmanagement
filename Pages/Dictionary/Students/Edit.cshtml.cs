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
using sms;
using sms.Data;

namespace sms.Pages.Students
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
        public SelectList GradeNumbersSL { get; set; }
        public int GradeNumber { get; set; }
        public SelectList GradeLettersSL { get; set; }
        public string GradeLetter { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };
        public string Gender { get; set; } = "Не вказано";
        public string[] Genders = new[] { "Жіноча", "Чоловіча", "Не вказано" };

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Grade).FirstOrDefaultAsync(m => m.Id == id);
            if(!string.IsNullOrEmpty(Student.Gender)) Gender = Student.Gender;
            if (Student == null)
            {
                return NotFound();
            }
            GradeNumbersSL = new SelectList(_context.Grades.OrderBy(x => x.Number).Select(x => x.Number).Distinct());
            GradeLettersSL = new SelectList(_context.Grades.OrderBy(x => x.Letter).Select(x => x.Letter).Distinct());
            GradeNumber = Student.Grade.Number;
            GradeLetter = Student.Grade.Letter;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, int GradeNumber, string GradeLetter, string Gender)
        {
            var studentToUpdate = _context.Students.Include(t => t.Grade).Single(s => s.Id == id);

            if (await TryUpdateModelAsync<Student>(
                            studentToUpdate,
                            "Student",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic,
                            i => i.DateOfBirth, i => i.Address))
            {
                studentToUpdate.Grade = _context.Grades.Where(x => x.Number == GradeNumber).Where(x => x.Letter == GradeLetter).Single();
                
                if (Gender == "Не вказано") studentToUpdate.Gender = null;
                else studentToUpdate.Gender = Gender;

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

                        var oldFile = studentToUpdate.ProfilePicture;
                        var fileToDelete = string.Empty;
                        if (!string.IsNullOrEmpty(oldFile))
                        {
                            fileToDelete = Path.Combine(uploadsFolder, oldFile);
                        }

                        if (System.IO.File.Exists(fileToDelete))
                        {
                            System.IO.File.Delete(fileToDelete);
                        }

                        studentToUpdate.ProfilePicture = trustedFileNameForFileStorage;
                    }
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Student.Id))
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

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
