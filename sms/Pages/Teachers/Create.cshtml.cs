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
        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };

        public CreateModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }

        public IActionResult OnGet()
        {
            //Subjects multiple select list
            //Список множинного вибору предметів
            var subjectsQuery = _context.Subjects.OrderBy(r => r.Name);
            SubjectNameSL = new SelectList(subjectsQuery, "Id", "Name"); //list, id, value

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int[] selectedSubjects)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Create a record and fill it with data
            //Створення запису і заповнення даними
            var newTeacher = new Teacher();
            newTeacher.Subjects = new List<Subject>();

            //Refactored because TryUpdateModelAsync fails while unit testing:
            //https://github.com/dotnet/AspNetCore.Docs/issues/14009
            //if (await TryUpdateModelAsync<Teacher>(
            //                newTeacher,
            //                "Teacher",
            //                i => i.LastName, i => i.FirstName, i => i.Patronymic))

            newTeacher.LastName = Teacher.LastName;
            newTeacher.FirstName = Teacher.FirstName;
            newTeacher.Patronymic = Teacher.Patronymic;

            if (selectedSubjects != null)
            {
                foreach (var subj in selectedSubjects)
                {
                    newTeacher.Subjects.Add(_context.Subjects.Single(s => s.Id == subj));
                }
            }

            if (FormFile != null)
            {
                //Check permitted extensions for photo
                //Перевірка фото на тип файлу
                var ext = Path.GetExtension(FormFile.FileName).ToLowerInvariant();
                if (!string.IsNullOrEmpty(ext) || permittedExtensions.Contains(ext))
                {
                    if (webHostEnvironment != null)
                    {
                        //Get random filename for server storage
                        //Формування випадкового імені файлу для збереження на сервері
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, @"images\avatars"); //webHost adds 'wwwroot'
                        var trustedFileNameForFileStorage = Path.GetRandomFileName();
                        trustedFileNameForFileStorage = trustedFileNameForFileStorage.Substring(0, 8)
                            + trustedFileNameForFileStorage.Substring(9) + ext;
                        var filePath = Path.Combine(uploadsFolder, trustedFileNameForFileStorage);

                        //Copy data to a new file
                        //Копіювання даних у новий файл
                        using (var fileStream = System.IO.File.Create(filePath))
                        {
                            await FormFile.CopyToAsync(fileStream);
                        }

                        //Update student photo
                        //Оновлення фото
                        newTeacher.ProfilePicture = trustedFileNameForFileStorage;
                    }
                }
            }

            //Save new teacher to DB
            //Збереження нового вчителя у БД
            _context.Teachers.Add(newTeacher);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
