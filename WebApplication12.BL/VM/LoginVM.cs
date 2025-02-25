﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication12.BL.VM
{
    public  class LoginVM
    {
        
        [EmailAddress(ErrorMessage = "Enter valid mail")]
        
        [Required(ErrorMessage = "Email Required")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Min length is 5")]
        public string password { get; set; }

        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }

        public IEnumerable<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
