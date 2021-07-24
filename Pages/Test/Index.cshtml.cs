using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Test
{
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public IndexModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Lesson> Lesson { get;set; }

        public async Task OnGetAsync()
        {
            Lesson = await _context.Lessons
                .Include(l => l.Grade)
                .Include(l => l.Subject)
                .Include(l => l.Teacher).ToListAsync();
        }
    }
}
