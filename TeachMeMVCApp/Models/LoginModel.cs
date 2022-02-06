using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeMVCApp.Models
{
    using static TeachMeMVCApp.Data.Constants.Common;
    using static TeachMeMVCApp.Data.Constants.Login;

    public class LoginModel
    {
        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxEmailLength, MinimumLength = minEmailLength)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = requiredFieldMessage)]
        [StringLength(maxPasswordLength, MinimumLength = maxPasswordLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public string LoginInValid { get; set; }
    }
}
