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
        public async Task OnGetAsync(bool noRoles, int? pageIndex)
        {
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

            //Dropdown for roles
            var rolesQuery = _context.Roles.OrderBy(r => r.Name);
            RoleNameSL = new SelectList(rolesQuery.AsNoTracking(),
                        "Name", "Name");
            
            //Pagination
            var pageSize = Configuration.GetValue("PageSize", 5);
            userRolesPaginated = PaginatedList<UserRoles>.CreateFromList(
                userRoles, pageIndex ?? 1, pageSize);
        }

        public async Task<IActionResult> OnPostAsync(string mainid, string rolename, bool noRoles, int? pageIndex)
        {
            //Save checkbox state
            NoRolesCheckbox = noRoles;
            //Get all roles
            var rolesQuery = _context.Roles.OrderBy(r => r.Name).ToList();
            string allroles = string.Join(",", rolesQuery);

            //Get user and his role by id
            var user = await _usermanager.FindByIdAsync(mainid);
            var roles = await _usermanager.GetRolesAsync(user);

            //Remove old role before adding new one
            await _usermanager.RemoveFromRolesAsync(user, roles);

            //Check if there is an existing role befor assigning it.
            //Без повноважень is not added (or you get error)
            if (allroles.Contains(rolename)) await _usermanager.AddToRoleAsync(user, rolename);

            return RedirectToPage("/TimeTable", new { noRoles = noRoles, pageIndex = pageIndex });
        }

    }
    public class UserRoles
    {
        public string UserId { get; set; }
        [Display(Name = "Користувач")]
        public string UserName { get; set; }
        [Display(Name = "Повноваження")]
        public string RoleName { get; set; }
    }
}
