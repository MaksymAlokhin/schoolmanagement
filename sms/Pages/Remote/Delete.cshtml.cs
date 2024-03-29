﻿using System;
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
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentSort { get; set; }

        public DeleteModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string sortOrder, int? pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Find and remove record from DB
            //Знаходження та видалення запису у БД
            Assignment = await _context.Assignments.FindAsync(id);

            if (Assignment != null)
            {
                Log.Information("Користувач видалив завдання для дистанційного навчання " +
                    "для класу {0} з предмету {1}", Assignment.GradeId, Assignment.SubjectId);

                _context.Assignments.Remove(Assignment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new
            {
                gradeId = $"{Assignment?.GradeId}",
                subjectId = $"{Assignment?.SubjectId}",
                pageIndex = $"{pageIndex}",
                sortOrder = $"{sortOrder}"
            });
        }
    }
}
