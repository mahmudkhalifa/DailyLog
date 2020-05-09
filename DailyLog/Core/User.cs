using Data.DailyLog.EntityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyLog.Core
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Your Name"), StringLength(255)]
        public string Name { get; set; }
        [Required, EmailAddress, Display(Name = "Email")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), StringLength(14, MinimumLength = 3)]
        public string Password { get; set; }
        [Required,DataType(DataType.PhoneNumber),Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } 
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public UserEntity ToEntity()
        {
            var userEntity = new UserEntity
            {
                Id = Id,
                Name = Name,
                Email = Email,
                Password = Password,
                PhoneNmber = PhoneNumber,
                JobTitle = JobTitle
            };
            return userEntity;
        } 
    }
}
