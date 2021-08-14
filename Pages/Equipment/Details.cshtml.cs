using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sms.Data;
using sms.Models;

namespace sms.Pages.Equipment
{
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public string PageIndex { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Inventory Inventory { get; set; }

        public async Task<IActionResult> OnGetAsync(string pageIndex, int? id)
        {
            PageIndex = pageIndex;

            if (id == null)
            {
                return NotFound();
            }

            Inventory = await _context.Inventories.FirstOrDefaultAsync(m => m.Id == id);

            if (Inventory == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventory = await _context.Inventories.FindAsync(id);

            if (Inventory != null)
            {
                if(Inventory.DecommissionDate.HasValue)
                {
                    Inventory.DecommissionDate = null;
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Decommissioned", new { pageIndex = $"{pageIndex}" });
                }
                else
                {
                    Inventory.DecommissionDate = DateTime.Now; 
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index", new { pageIndex = $"{pageIndex}" });
                }
            }
            return RedirectToPage("./Index", new { pageIndex = $"{pageIndex}" });
        }
    }
}
