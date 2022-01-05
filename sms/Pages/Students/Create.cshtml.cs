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
using sms.Models;

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
        public List<SelectListItem> GradesSL { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };
        public string Gender { get; set; } = "Не вказано";
        public string[] Genders = new[] { "Жіноча", "Чоловіча", "Не вказано" };


        public IActionResult OnGet()
        {
            //Grade dropdown
            //Випадаючий список класу
            GradesSL = new List<SelectListItem>();
            var grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter);
            foreach (Grade g in grades)
            {
                GradesSL.Add(new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" });
            }

            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(string Gender)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Create student and fill data
            //Створення учня і заповнення даними
            var newStudent = new Student();

            //Refactored because TryUpdateModelAsync fails while unit testing:
            //https://github.com/dotnet/AspNetCore.Docs/issues/14009
            //if (await TryUpdateModelAsync<Student>(
            //                                newStudent,
            //                                "Student",
            //                                i => i.LastName, i => i.FirstName, i => i.Patronymic,
            //                                i => i.DateOfBirth, i => i.Address, i => i.GradeId))
            
            newStudent.LastName = Student.LastName;
            newStudent.FirstName = Student.FirstName;
            newStudent.Patronymic = Student.Patronymic;
            newStudent.DateOfBirth = Student.DateOfBirth;
            newStudent.Address = Student.Address;
            newStudent.GradeId = Student.GradeId;

            if (Gender == "Не вказано") newStudent.Gender = null;
            else newStudent.Gender = Gender;

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
                        //Оновлення фото учня
                        newStudent.ProfilePicture = trustedFileNameForFileStorage;
                    }
                }
            }

            //Save new student to DB
            //Збереження нового учня у БД
            _context.Students.Add(newStudent);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
