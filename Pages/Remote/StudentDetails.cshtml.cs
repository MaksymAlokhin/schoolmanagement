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

namespace sms.Pages.Remote
{
    [Authorize(Roles = "�����������, �������")]
    public class StudentDetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }

        public StudentDetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageIndex, int? id)
        {
            PageIndex = pageIndex;

            if (id == null)
            {
                return NotFound();
            }

            //Get data from DB
            //������������ ����� � ��
            Assignment = await _context.Assignments
                .Include(a => a.Grade)
                .Include(a => a.Subject)
                .Include(a => a.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
