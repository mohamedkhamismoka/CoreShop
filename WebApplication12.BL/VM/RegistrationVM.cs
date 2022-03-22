using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication12.BL.VM
{
    public class RegistrationVM
    {[EmailAddress(ErrorMessage ="Enter valid mail")]
    [Required(ErrorMessage ="Email Required")]
        public string mail { get; set; }
        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        [MinLength(5,ErrorMessage ="Min length is 5")]
        public string password { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Min length is 5")]
        [Compare("password",ErrorMessage ="not matched password")]
        public string ConfirmPassword { get; set; }
    }
}
