using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sms.Data;
using sms.Models;

namespace sms.Pages.Equipment
{
    public class IndexModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string NumberSort { get; set; }
        public string QtySort { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Inventory> Inventory { get; set; }

        public IndexModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        //public IList<Inventory> Inventory { get;set; }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder; 
            
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "date" ? "date_desc" : "date";
            NumberSort = sortOrder == "number" ? "number_desc" : "number";
            QtySort = sortOrder == "qty" ? "qty_desc" : "qty";
            PriceSort = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Inventory> inventoryIQ = _context.Inventories;

            if (!String.IsNullOrEmpty(searchString))
            {
                inventoryIQ = inventoryIQ.Where(s => s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    inventoryIQ = inventoryIQ.OrderByDescending(s => s.Name);
                    break;
                case "date":
                    inventoryIQ = inventoryIQ.OrderBy(s => s.InventoryDate);
                    break;
                case "date_desc":
                    inventoryIQ = inventoryIQ.OrderByDescending(s => s.InventoryDate);
                    break;
                case "number":
                    inventoryIQ = inventoryIQ.OrderBy(s => s.InventoryNumber);
                    break;
                case "number_desc":
                    inventoryIQ = inventoryIQ.OrderByDescending(s => s.InventoryNumber);
                    break;
                case "qty":
                    inventoryIQ = inventoryIQ.OrderBy(s => s.Quantity);
                    break;
                case "qty_desc":
                    inventoryIQ = inventoryIQ.OrderByDescending(s => s.Quantity);
                    break;
                case "price":
                    inventoryIQ = inventoryIQ.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    inventoryIQ = inventoryIQ.OrderByDescending(s => s.Price);
                    break;
                default:
                    inventoryIQ = inventoryIQ.OrderBy(s => s.Name);
                    break;
            }
            var pageSize = Configuration.GetValue("PageSize", 10);
            Inventory = await PaginatedList<Inventory>.CreateAsync(
                inventoryIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
