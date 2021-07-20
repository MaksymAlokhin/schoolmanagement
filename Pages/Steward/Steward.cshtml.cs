using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sms.Pages
{
    [Authorize(Roles = "Адміністратор, Завгосп")]
    public class StewardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
