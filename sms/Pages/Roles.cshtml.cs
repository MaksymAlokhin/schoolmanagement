using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace sms.Pages
{
    [Authorize(Roles = "Адміністратор")]
    public class RolesModel : PageModel
    {
        public SelectList RoleNameSL { get; set; }
        private readonly Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _usermanager;
        public string NameSort { get; set; }
        public string RoleSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        //private readonly RoleManager<IdentityUser> _rolemanager;
        private readonly IConfiguration Configuration;
        public PaginatedList<UserRoles> userRolesPaginated { get; set; }
        public bool NoRolesCheckbox { get; set; }

        public RolesModel(sms.Data.ApplicationDbContext context, 
            UserManager<IdentityUser> usermanager, 
            IConfiguration configuration)
        {
            _context = context;
            _usermanager = usermanager;
            Configuration = configuration;
        }
        //public UserRolesData userRolesData { get; set; }
        public IList<UserRoles> userRoles { get; set; }

        public IList<IdentityUser> users { get; set; }
        public async Task OnGetAsync(string sortOrder, string currentFilter, 
            string searchString, bool noRoles, int? pageIndex)
        {
            //Dropdown for roles
            //Випадаючий список ролей
            var rolesQuery = _context.Roles.OrderBy(r => r.Name);
            RoleNameSL = new SelectList(rolesQuery.AsNoTracking(), "Name", "Name");

            CurrentSort = sortOrder; 
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            RoleSort = sortOrder == "role" ? "role_desc" : "role";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            NoRolesCheckbox = noRoles;
            userRoles = new List<UserRoles>();
            users = await _context.Users
                .OrderBy(u => u.UserName)
                .ToListAsync();

            foreach (var u in users)
            {
                string role;
                var user = await _usermanager.FindByIdAsync(u.Id);
                var roles = await _usermanager.GetRolesAsync(user);
                if (NoRolesCheckbox && roles.Count == 0)
                {
                    role = "Без повноважень";
                    userRoles.Add(new UserRoles { RoleName = role, UserId = u.Id, UserName = u.UserName });
                }
                else if (!NoRolesCheckbox && !(roles.Count == 0))
                {
                    role = roles[0];
                    userRoles.Add(new UserRoles { RoleName = role, UserId = u.Id, UserName = u.UserName });
                }
                else if (!NoRolesCheckbox && roles.Count == 0)
                {
                    role = "Без повноважень";
                    userRoles.Add(new UserRoles { RoleName = role, UserId = u.Id, UserName = u.UserName });
                }
            }

            //Search filter
            //Фільтр пошуку
            if (!String.IsNullOrEmpty(searchString))
            {
                userRoles = userRoles.Where(s => s.UserName.Contains(searchString)).ToList();
            }

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    userRoles = userRoles.OrderByDescending(s => s.UserName).ToList();
                    break;
                case "role":
                    userRoles = userRoles.OrderBy(s => s.RoleName).ToList();
                    break;
                case "role_desc":
                    userRoles = userRoles.OrderByDescending(s => s.RoleName).ToList();
                    break;
                default:
                    userRoles = userRoles.OrderBy(s => s.UserName).ToList();
                    break;
            }

            //Pagination
            //Розподіл на сторінки
            var pageSize = Configuration.GetValue("PageSize", 7);
            userRolesPaginated = PaginatedList<UserRoles>.CreateFromList(
                userRoles, pageIndex ?? 1, pageSize);
        }

        public async Task<IActionResult> OnPostAsync(string mainid, string rolename, bool noRoles, int? pageIndex)
        {
            NoRolesCheckbox = noRoles;
            
            //Get all roles
            //Отримання всіх ролей
            var rolesQuery = _context.Roles.OrderBy(r => r.Name).ToList();
            string allroles = string.Join(",", rolesQuery);

            //Get user and his role by id
            //Визначення користувача і ролі за id
            var user = await _usermanager.FindByIdAsync(mainid);
            var roles = await _usermanager.GetRolesAsync(user);

            //Remove old role before adding new one
            //Видалення старої ролі перед додаванням нової
            await _usermanager.RemoveFromRolesAsync(user, roles);

            //Check if role actually exists, before assigning it
            //Без повноважень is a ficticious role that should not be added
            //
            //Перевірка, чи роль дійсно існує, перш ніж додавати її користувачеві
            //Без повноважень не можна додавати як роль
            if (allroles.Contains(rolename)) await _usermanager.AddToRoleAsync(user, rolename);

            return RedirectToPage("/Roles", new { noRoles = noRoles, pageIndex = pageIndex });
        }

    }
    
    //Data structure for page model
    //Структура даних для представлення користувача на сторінці
    public class UserRoles
    {
        public string UserId { get; set; }
        [Display(Name = "Користувач")]
        public string UserName { get; set; }
        [Display(Name = "Повноваження")]
        public string RoleName { get; set; }
    }
}
