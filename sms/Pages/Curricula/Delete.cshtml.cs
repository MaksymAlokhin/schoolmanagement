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

namespace sms.Pages.Curricula
{
    [Authorize(Roles = "Адміністратор")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public DeleteModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            //Завантаження даних з БД
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

        public async Task<IActionResult> OnPostAsync(string sortOrder,
            string currentFilter, int? pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Find and delete from DB
            //Знаходимо вказане навантаження та видаляємо з БД
            Curriculum = await _context.Curricula.FindAsync(id);

            if (Curriculum != null)
            {
                Log.Information("Користувач видалив навчальне навантаження - " +
                    "Quantity: {0}, GradeId: {1}, SubjectId: {2}, TeacherId: {3}",
                    Curriculum.Quantity, Curriculum.GradeId, Curriculum.SubjectId, Curriculum.TeacherId);

                _context.Curricula.Remove(Curriculum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new
            {
                gradeId = $"{Curriculum?.GradeId}",
                pageIndex = $"{pageIndex}",
                sortOrder = $"{sortOrder}",
                currentFilter = $"{currentFilter}"
            });
        }
    }
}
