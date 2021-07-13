using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace sms.Areas.Identity.Pages.Account.Manage
{
    public class Disable2faModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Disable2faModel> _logger;

        public Disable2faModel(
            UserManager<IdentityUser> userManager,
            ILogger<Disable2faModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Неможливо знайти користувача з ID '{_userManager.GetUserId(User)}'.");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                throw new InvalidOperationException($"Неможливо відключити двофакторну аутентифікацію для користувача з ID '{_userManager.GetUserId(User)}', так як вона зараз не включена.");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Неможливо знайти користувача з ID '{_userManager.GetUserId(User)}'.");
            }

            var disable2faResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
            if (!disable2faResult.Succeeded)
            {
                throw new InvalidOperationException($"Відбулася неочікувана помилка при відключенні двофакторної аутентифікації для користувача з ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("Користувач з ID '{UserId}' відключив двофакторну аутентифікацію.", _userManager.GetUserId(User));
            StatusMessage = "Двофакторна аутентифікація відключена. Ви можете її включити знову під час налаштування застосунку аутентифікації";
            return RedirectToPage("./TwoFactorAuthentication");
        }
    }
}