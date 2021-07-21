using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Grades
{
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Grade Grade { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grade = await _context.Grades.FirstOrDefaultAsync(m => m.Id == id);

            if (Grade == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
