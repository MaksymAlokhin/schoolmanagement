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

namespace sms.Pages.Subjects
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

        public Subject Subject { get; set; }

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
            Subject = await _context.Subjects.Include(x => x.Teachers).FirstOrDefaultAsync(m => m.Id == id);

            if (Subject == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
