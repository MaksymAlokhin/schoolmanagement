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
using sms.Data;
using sms.Models;

namespace sms.Pages.Teachers
{
    [Authorize(Roles = "Адміністратор")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public DeleteModel(sms.Data.ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teachers.Include(t => t.Subjects).FirstOrDefaultAsync(m => m.Id == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teachers.FindAsync(id);

            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, @"images/avatars"); //webHost adds 'wwwroot'
            var oldFile = Teacher.ProfilePicture;
            var fileToDelete = string.Empty;
            if (!string.IsNullOrEmpty(oldFile))
            {
                fileToDelete = Path.Combine(uploadsFolder, oldFile);
            }

            if (Teacher != null)
            {
                _context.Teachers.Remove(Teacher);
                await _context.SaveChangesAsync();

                if (System.IO.File.Exists(fileToDelete))
                {
                    System.IO.File.Delete(fileToDelete);
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
