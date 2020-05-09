using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DailyLog.Core;
using DailyLog.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }
        public string ReturnUrl { get; set; }
        
        [BindProperty]
        public AppUser UserInput { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            returnUrl ??= Url.Content("~/");

            this.ReturnUrl = returnUrl;
        }

        private async Task<AppUser> AuthenticateUser(AppUser user)
        {
            if (string.IsNullOrEmpty(user.LoginEmail) || string.IsNullOrEmpty(user.LoginEmail))
            {
                return null;
            }

            var hasher = new PasswordHasher<string>();

            var userInDbEntity = await _userService.GetUserByEmail(user.LoginEmail);

            var isPasswordMatch = hasher.VerifyHashedPassword(null, userInDbEntity.Password, user.Password);

            return isPasswordMatch == PasswordVerificationResult.Failed ? null : new AppUser() { Id = userInDbEntity.Id.ToString(), LoginEmail = userInDbEntity.Name };
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            this.ReturnUrl = returnUrl;

            var user = await AuthenticateUser(UserInput);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return Page();
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.LoginEmail),
                    new Claim(ClaimTypes.Sid, user.Id),
                    new Claim("Id", user.Id),
                    new Claim(ClaimTypes.Role, "Administrator"),
                };

            var claimsIdentity = 
                new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties
                {
                    IsPersistent = UserInput.RememberMe,
                    AllowRefresh = true,
                });

            if (!Url.IsLocalUrl(returnUrl))
            {
                returnUrl = Url.Content("~/");
            }

            return LocalRedirect(returnUrl);
        }
    }
}