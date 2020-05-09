using DailyLog.Core;
using DailyLog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public User User { get; set; }

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }
       
        public ActionResult OnPostSave()
        {
            if (!ModelState.IsValid)
                return Page();

            _userService.AddUser(User);
            return RedirectToPage("index");
        }
    }
}