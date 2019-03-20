using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Helpers.Attributes
{
    public class ExistentClientId : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var service = (UserManager<DbUser>)validationContext
                       .GetService(typeof(UserManager<DbUser>));
            var user = service.FindByIdAsync(value.ToString()).Result;
            if (user == null)
            {
                return new ValidationResult("Recieved client doesn`t exist");
            }
            return ValidationResult.Success;
        }
    }
}
