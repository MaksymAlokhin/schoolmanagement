﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms;
using sms.Data;

namespace sms.Pages.Students
{
    [Authorize(Roles = "Адміністратор")]
    public class EditModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public EditModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList GradeNumbersSL { get; set; }
        public int GradeNumber { get; set; }
        public SelectList GradeLettersSL { get; set; }
        public string GradeLetter { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Grade).FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            var numbersQuery = _context.Grades.OrderBy(x => x.Number).Select(x => x.Number).Distinct();
            var lettersQuery = _context.Grades.OrderBy(x => x.Letter).Select(x => x.Letter).Distinct();
            GradeNumbersSL = new SelectList(numbersQuery);
            GradeLettersSL = new SelectList(lettersQuery);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, int GradeNumber, string GradeLetter)
        {
            var studentToUpdate = _context.Students.Include(t => t.Grade).Single(s => s.Id == id);

            if (await TryUpdateModelAsync<Student>(
                            studentToUpdate,
                            "Student",
                            i => i.LastName, i => i.FirstName, i => i.Patronymic,
                            i => i.DateOfBirth, i => i.Address))
            {
                studentToUpdate.Grade = _context.Grades.Where(x => x.Number == GradeNumber).Where(x => x.Letter == GradeLetter).Single();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Student.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index");
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
