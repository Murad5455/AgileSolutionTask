﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetIdentityDemo.Shared
{
    public class RegisterViewModel
    {

        //[Required]
        //public string FullName { get; set; }


        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]

        public string Password { get; set; }
         
        [Required]
        [StringLength(50, MinimumLength = 5)]

        public string ConfirmPassword { get; set; }

      

    }
}
