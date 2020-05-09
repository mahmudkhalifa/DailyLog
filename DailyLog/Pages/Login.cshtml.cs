using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DailyLog.Services;
using Data.DailyLog.DatabaseSpecific;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace DailyLog
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public UserEntity user{ get; set; }
        public string Msg{ get; set; }

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> OnPostTask()
        {
            var hasher = new PasswordHasher<string>();
            
            var UserInDbEntity = _userService.GetUserByEmail(user.Email);

            var isPasswordMatch = hasher.VerifyHashedPassword(null, UserInDbEntity.Password, user.Password);

            if (isPasswordMatch == PasswordVerificationResult.Success)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Name)
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToPage("/user/userDetails");

                //HttpContext.Session.SetString("username", user.Name);
                //return RedirectToPage("Privacy");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }

        

        public void OnGetWelcome()
        {
            user.Name = HttpContext.Session.GetString("username");
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }

    }
}