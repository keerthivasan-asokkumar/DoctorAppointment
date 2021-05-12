using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndApp.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the Confirm password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Please enter the Email ID")]
        [Display(Name = "Email ID")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter the DOB")]
        [Display(Name = "DOB")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please enter the Role ID")]
        [Display(Name = "Enter the Role")]
        public int UserRoleId { get; set; }

        public DateTime CreatedDatetime { get; set; }
    }
}
