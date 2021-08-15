using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Dictionary.Curricula
{
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }

        public DeleteModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curriculum Curriculum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex; 
            
            if (id == null)
            {
                return NotFound();
            }

            //Load data from DB
            //Завантаження даних з БД
            Curriculum = await _context.Curricula
                .Include(c => c.Grade)
                .Include(c => c.Subject)
                .Include(c => c.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Curriculum == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            //Find and delete from DB
            //Знаходимо вказане навантаження та видаляємо з БД
            Curriculum = await _context.Curricula.FindAsync(id);

            if (Curriculum != null)
            {
                _context.Curricula.Remove(Curriculum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new { gradeId = $"{Curriculum.GradeId}", pageIndex = $"{pageIndex}" });
        }
    }
}
