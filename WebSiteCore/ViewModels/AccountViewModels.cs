using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.Helpers;

namespace WebSiteCore.ViewModels
{
    public class RegisterViewModel
    {
        [CustomEmail(ErrorMessage = "Already exist")]
        [Required(ErrorMessage = "Поле є обов'язковим")]
        [EmailAddress(ErrorMessage = "Не валідна пошта")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле є обов'язковим")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Поле є обов'язковим")]
        public string Image { get; set; }

    }
}
