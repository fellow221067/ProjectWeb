using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Models
{
    public class AuthorizationModel
    {
        [EmailAddress(ErrorMessage = "Invalid E-mail format.")]
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Password")]
        public string TempPassword { get; set; }
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
    public class UserAuthorizationModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "E-mail is required.")]
        [EmailAddress(ErrorMessage = "Invalid E-mail format.")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
