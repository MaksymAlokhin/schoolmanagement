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

namespace sms.Pages.Equipment
{
    [Authorize(Roles = "Адміністратор, Завгосп")]
    public class DeleteModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }

        public DeleteModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inventory Inventory { get; set; }

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
            Inventory = await _context.Inventories.FirstOrDefaultAsync(m => m.Id == id);

            if (Inventory == null)
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

            //Find and delete the record
            //Знаходження і видалення запису
            Inventory = await _context.Inventories.FindAsync(id);

            if (Inventory != null)
            {
                _context.Inventories.Remove(Inventory);
                await _context.SaveChangesAsync();
            }

            if (Inventory.DecommissionDate.HasValue)
            {
                return RedirectToPage("./Decommissioned", new
                {
                    pageIndex = $"{pageIndex}",
                    sortOrder = $"{sortOrder}",
                    currentFilter = $"{currentFilter}"
                });
            }
            else
            {
                return RedirectToPage("./Index", new
                {
                    pageIndex = $"{pageIndex}",
                    sortOrder = $"{sortOrder}",
                    currentFilter = $"{currentFilter}"
                });
            }
        }
    }
}
