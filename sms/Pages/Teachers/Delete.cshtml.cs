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
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.Teachers
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
            //Знаходження запису у БД
            Teacher = await _context.Teachers.FindAsync(id);

            if (webHostEnvironment != null)
            {
                bool isProduction = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production";
                if (isProduction)
                {
                    //Delete photo file
                    //Видалення файлу фото
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, @"images/avatars"); //webHost adds 'wwwroot'
                    var oldFile = Teacher.ProfilePicture;
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

            //Delete teacher from DB
            //Видалення вчителя з БД
            if (Teacher != null)
            {
                Log.Information("Користувач видалив запис про вчителя {0}", Teacher.FullName);

                _context.Teachers.Remove(Teacher);
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
