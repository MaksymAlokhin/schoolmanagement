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

namespace sms.Pages.Dictionary.Curricula
{
    [Authorize(Roles = "Адміністратор")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Curriculum Curriculum { get; set; }

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
            //Беремо навантаження з БД
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
    }
}
