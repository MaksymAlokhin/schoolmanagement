using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public DeleteModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gradebook Gradebook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gradebook = await _context.Gradebooks
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .Include(g => g.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Gradebook == null)
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

            Gradebook = await _context.Gradebooks.FindAsync(id);

            if (Gradebook != null)
            {
                _context.Gradebooks.Remove(Gradebook);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
