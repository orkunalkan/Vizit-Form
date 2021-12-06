
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VizitForm.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string register_name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string register_password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("register_password", ErrorMessage = "Password and confirmation password not match.")]
        public string register_passwordcheck { get; set; }
    }
}
