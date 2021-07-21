using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public IndexModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; }

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teachers.ToListAsync();
        }
    }
}
