using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.Remote
{
    [Authorize(Roles = "Адміністратор, Вчитель, Батьки")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentSort { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder, int? pageIndex, int? id)
        {
            PageIndex = pageIndex;
            CurrentSort = sortOrder;

            if (id == null)
            {
                return NotFound();
            }

            //Get data from DB
            //Завантаження даних з БД
            Assignment = await _context.Assignments
                .Include(a => a.Grade)
                .Include(a => a.Subject)
                .Include(a => a.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Assignment == null)
            {
                return NotFound();
            }

            Log.Information("Користувач переглядає завдання для дистанційного навчання " +
                "для класу {0} з предмету {1}", Assignment.GradeId, Assignment.SubjectId);

            return Page();
        }
    }
}
