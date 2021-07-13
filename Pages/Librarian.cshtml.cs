using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sms.Pages
{
    [Authorize(Roles = "Адміністратор, Бібліотекар")]
    public class LibrarianModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
