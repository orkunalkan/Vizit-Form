using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VizitForm.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string login_name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string login_password { get; set; }

        [Display(Name = "Remember Me")]
        public bool login_remember { get; set; }
    }
}
