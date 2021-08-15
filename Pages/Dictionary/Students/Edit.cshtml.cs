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
using sms.Models;

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
        public List<SelectListItem> GradesSL { get; set; }
        public int? PageIndex { get; set; }
        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };
        public string Gender { get; set; } = "Не вказано";
        public string[] Genders = new[] { "Жіноча", "Чоловіча", "Не вказано" };

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            
            if (id == null)
            {
                return NotFound();
            }

            //Load data from DB
            //Завантаження даних з БД
            Student = await _context.Students
                .Include(s => s.Grade).FirstOrDefaultAsync(m => m.Id == id);
            if(!string.IsNullOrEmpty(Student.Gender)) Gender = Student.Gender;
            
            if (Student == null)
            {
                return NotFound();
            }

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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? pageIndex, int? id, string Gender)
        {
            //Find item in DB and update it
            //Знаходження запису у БД і оновлення
            var studentToUpdate = _context.Students.Include(t => t.Grade).Single(s => s.Id == id);

            if (await TryUpdateModelAsync<Student>(
                            studentToUpdate,
                            "Student",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic,
                            i => i.DateOfBirth, i => i.Address, i => i.GradeId))
            {
                if (Gender == "Не вказано") studentToUpdate.Gender = null;
                else studentToUpdate.Gender = Gender;

                if (FormFile != null)
                {
                    //Check permitted extensions for photo
                    //Перевірка фото на тип файлу
                    var ext = Path.GetExtension(FormFile.FileName).ToLowerInvariant();
                    if (!string.IsNullOrEmpty(ext) || permittedExtensions.Contains(ext))
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

                        //Delete old photo file
                        //Видалення старого файлу з фото
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

                        //Update student photo
                        //Оновлення фото учня
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
            return RedirectToPage("./Index", new { pageIndex = $"{pageIndex}" });
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
