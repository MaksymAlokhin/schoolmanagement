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
        public List<int> selectedSubjects { get; set; }
        public SelectList SubjectNameSL { get; set; }
        public int? PageIndex { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IFormFile FormFile { get; set; }
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" };

        public EditModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }
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
            //Завантаження даних з БД
            Teacher = await _context.Teachers.Include(t => t.Subjects).FirstOrDefaultAsync(m => m.Id == id);

            if (Teacher == null)
            {
                return NotFound();
            }

            //Subjects multiple select list
            //Список множинного вибору предметів
            var subjectsQuery = _context.Subjects.OrderBy(r => r.Name);
            SubjectNameSL = new SelectList(subjectsQuery.AsNoTracking(), "Id", "Name"); //list, id, value


            //To make items preselected:
            //https://docs.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-select-tag-helper
            //https://www.learnrazorpages.com/razor-pages/tag-helpers/select-tag-helper

            //Generate selected items in multiple select list
            //Обрані предмети у списку множинного вибору
            selectedSubjects = new List<int>();
            foreach (var subject in Teacher.Subjects)
            {
                selectedSubjects.Add(subject.Id);
            }

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string sortOrder,
            string currentFilter, int? pageIndex, int? id, int[] selectedSubjects)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Find record in DB and update its fields
            //Знаходження запису у БД і оновлення полів
            var teacherToUpdate = _context.Teachers.Include(t => t.Subjects).Single(t => t.Id == id);

            if (await TryUpdateModelAsync<Teacher>(
                            teacherToUpdate,
                            "Teacher",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic))
            {
                //Populate list of subjects for the selected teacher
                //Заповнення списку предметів обраного вчителя
                UpdateTeacherSubjects(selectedSubjects, teacherToUpdate);
            }

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

                    //Update teacher's photo
                    //Оновлення фото вчителя
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
            return RedirectToPage("./Index", new
            {
                pageIndex = $"{pageIndex}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}"
            });
        }

        private bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.Id == id);
        }

        //Populate list of subjects for the selected teacher
        //Заповнення списку предметів обраного вчителя
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
                    //If the user selected a subject
                    //Коли користувач обрав пердмет
                    if (selectedSubjectsHS.Contains(subject.Id))
                    {
                        //If there is currently no such subject for teacher, add it
                        //Якщо предмета немає у поточному списку вчителя, додати предмет
                        if (!teacherSubjects.Contains(subject.Id))
                        {
                            teacherToUpdate.Subjects.Add(subject);
                        }
                    }
                    //If the user didn't select a subject
                    //Коли користувач не обрав пердмет
                    else
                    {
                        //If the subject is present in the list, remove it
                        //Якщо предмет був у списку вчителя, видалити предмет
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
