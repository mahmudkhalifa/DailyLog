using System.ComponentModel.DataAnnotations;


namespace DailyLog.Core
{
    public class AppUser
    {
        public string Id { get; set; }

        [Required, EmailAddress,Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required, DataType(DataType.Password), StringLength(14, MinimumLength = 3)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
