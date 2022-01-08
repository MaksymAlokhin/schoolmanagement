using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Models;
using sms.Data;
using Serilog;

namespace sms.Pages.Students
{
    [Authorize(Roles = "Адміністратор")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public int? PageIndex { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public DeleteModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Student Student { get; set; }

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
            Student = await _context.Students
                .Include(s => s.Grade).FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }

            if (string.IsNullOrEmpty(Student.Gender)) Student.Gender = "Не вказано";

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string sortOrder,
            string currentFilter, int? pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Find the record in DB
            //Знаходження даних у БД
            Student = await _context.Students.FindAsync(id);

            //Delete photo file
            //Видалення файлу фото
            if (webHostEnvironment != null)
            {
                bool isProduction = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production";
                if (isProduction)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, @"images/avatars"); //webHost adds 'wwwroot'
                    var oldFile = Student.ProfilePicture;
                    var fileToDelete = string.Empty;
                    if (!string.IsNullOrEmpty(oldFile))
                    {
                        fileToDelete = Path.Combine(uploadsFolder, oldFile);
                    }
                    if (System.IO.File.Exists(fileToDelete))
                    {
                        System.IO.File.Delete(fileToDelete);
                    }
                }

            }

            //Delete student from DB
            //Видалення учня з БД
            if (Student != null)
            {
                Log.Information("Користувач видалив запис про учня {0}", Student.FullName);

                _context.Students.Remove(Student);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new
            {
                pageIndex = $"{pageIndex}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}"
            });
        }
    }
}
