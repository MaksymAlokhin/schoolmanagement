using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sms.Data;
using sms.Models;

namespace sms.Pages.TimeTable
{
    public class StudentsTTModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        int[] slots;
        string[] days;
        List<SelectListItem> grades;
        public StudentsTTModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int gradeId = 1)
        {
            slots = new int[8];
            slots = Enumerable.Range(1, 8).ToArray();
            days = new string[] { "Ïí", "Âò", "Ñð", "×ò", "Ïò" };

            grades = new List<SelectListItem>();
            var grad = _context.Grades;
            foreach (Grade g in grad)
            {
                new SelectListItem { Value = $"{g.Id}", Text = $"{g.FullName}" };
            }


        }
    }
}
