using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Serilog;
using sms.Data;
using sms.Models;

namespace sms.Pages.Equipment
{
    [Authorize(Roles = "Адміністратор, Завгосп")]
    public class CreateModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;

        public CreateModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Inventory Inventory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Add new record to DB
            //Додати новий запис до БД
            _context.Inventories.Add(Inventory);
            await _context.SaveChangesAsync();

            Log.Information("Користувач поставив на облік майно з інвентарним №{0}", 
                Inventory.InventoryNumber);

            return RedirectToPage("./Index");
        }
    }
}
