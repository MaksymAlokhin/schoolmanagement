﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Grade> grades;
        public List<Gradebook> gradebooks;
        public List<Subject> subjects;
        public int selectedYear;
        public int selectedGrade;
        public int selectedSemester;

        public async Task<IActionResult> OnGetAsync(int gradeId, int year, int semester)
        {
            grades = _context.Grades.OrderBy(g => g.Number).ThenBy(g => g.Letter).ToList();
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;
            selectedSemester = semester;
            selectedGrade = gradeId;
            DateTime startDate1 = new DateTime(selectedYear, 9, 1);
            DateTime startDate2 = new DateTime(selectedYear, 1, 1);
            DateTime endDate1 = new DateTime(selectedYear, 12, 31);
            DateTime endDate2 = new DateTime(selectedYear, 5, 31);
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            switch (selectedSemester)
            {
                case 1:
                    startDate = startDate1;
                    endDate = endDate1;
                    break;
                case 2:
                    startDate = startDate2;
                    endDate = endDate2;
                    break;
            }
            gradebooks = _context.Gradebooks
                .Include(g => g.Student)
                .Where(g => g.LessonDate >= startDate && g.LessonDate <= endDate && g.Student.GradeId == gradeId)
                .ToList();

            subjects = _context.Curricula
                .AsNoTracking()
                .Include(g => g.Subject)
                .Where(g => g.GradeId == gradeId)
                .OrderBy(g => g.Subject.Name)
                .Select(g => g.Subject)
                .ToList();

            return Page();
        }
    }
}
