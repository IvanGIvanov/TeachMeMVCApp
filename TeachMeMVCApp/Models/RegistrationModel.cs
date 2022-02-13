using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeMVCApp.Models
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Register;

    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "User Name")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(maxNameLength, MinimumLength = minNameLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(maxNameLength, MinimumLength = minNameLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        //[RegularExpression("^\\d{4}$")]
        public string PostCode { get; set; }

        [Required]
        //[RegularExpression(@"/08[789]\d{7}/")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public bool AcceptUserAgreement { get; set; }

        public string RegistrationInValid { get; set; }

    }
}
