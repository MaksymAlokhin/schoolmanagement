using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms;
using sms.Data;

namespace sms.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public IndexModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students
                .Include(s => s.Grade).ToListAsync();
        }
    }
}
