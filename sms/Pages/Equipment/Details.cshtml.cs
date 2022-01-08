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

namespace sms.Pages.Equipment
{
    [Authorize(Roles = "Адміністратор, Завгосп")]
    public class DetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        public int? PageIndex { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }

        public DetailsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
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

            Log.Information("Користувач переглядає детальну інформацію про майно з інвентарним №{0}",
                Inventory.InventoryNumber);

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string sortOrder,
            string currentFilter, int? pageIndex, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventory = await _context.Inventories.FindAsync(id);

            //Decommission or reverse decommission
            //Списання або постановка на облік
            if (Inventory != null)
            {
                if (Inventory.DecommissionDate.HasValue)
                {
                    Inventory.DecommissionDate = null;
                    await _context.SaveChangesAsync();
                    Log.Information("Користувач повторно поставив майно з інвентарним №{0} на облік",
                        Inventory.InventoryNumber);

                    return RedirectToPage("./Decommissioned", new
                    {
                        pageIndex = $"{pageIndex}",
                        sortOrder = $"{sortOrder}",
                        currentFilter = $"{currentFilter}"
                    });
                }
                else
                {
                    Inventory.DecommissionDate = DateTime.Now;
                    await _context.SaveChangesAsync();

                    Log.Information("Користувач списав майно з інвентарним №{0}",
                        Inventory.InventoryNumber);

                    return RedirectToPage("./Index", new
                    {
                        pageIndex = $"{pageIndex}",
                        sortOrder = $"{sortOrder}",
                        currentFilter = $"{currentFilter}"
                    });
                }
            }
            return RedirectToPage("./Index", new { pageIndex = $"{pageIndex}" });
        }
    }
}
