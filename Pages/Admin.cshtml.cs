using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace sms.Pages
{
    [Authorize(Roles = "Administrators")]
    public class AdminModel : PageModel
    {
        public SelectList RoleNameSL { get; set; }
        private readonly Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _usermanager;
        public AdminModel(sms.Data.ApplicationDbContext context, UserManager<IdentityUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
        }
        //public UserRolesData userRolesData { get; set; }
        public IList<UserRoles> userRoles { get; set; }

        public IList<IdentityUser> users { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            userRoles = new List<UserRoles>();
            users = await _context.Users
                .OrderBy(u => u.UserName)
                .ToListAsync();

            foreach(var u in users)
            {
                var user = await _usermanager.FindByIdAsync(u.Id);
                var roles = await _usermanager.GetRolesAsync(user);
                userRoles.Add(new UserRoles { RoleName = roles[0], UserId = u.Id, UserName = u.UserName });
            }

            var rolesQuery = _context.Roles.OrderBy(r=>r.Name);

            RoleNameSL = new SelectList(rolesQuery.AsNoTracking(),
                        "Name", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string mainid, string rolename)
        {
            //IEnumerable<string> roles = _context.Roles.Select(x => x.Name).OrderBy(x=>x).ToList();
            var user = await _usermanager.FindByIdAsync(mainid);
            var roles = await _usermanager.GetRolesAsync(user);
            await _usermanager.RemoveFromRolesAsync(user, roles);
            await _usermanager.AddToRoleAsync(user, rolename);
            return RedirectToPage("./Admin");
        }

    }
    public class UserRoles
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        //public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
