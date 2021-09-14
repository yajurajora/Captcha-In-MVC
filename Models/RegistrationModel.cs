using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CapthaInMvc.Models
{
    public class RegistrationModel
    {
        [Display(Name ="User Name")]
        public string  UserName { get; set; }

        [Display(Name = "Password")]
        public string  UserPassword { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}