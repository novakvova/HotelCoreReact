﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Helpers
{
    public class ExistentClientEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var service = (UserManager<DbUser>)validationContext
                       .GetService(typeof(UserManager<DbUser>));
            var user = service.FindByEmailAsync(value.ToString()).Result;
            if (user != null)
            {
                return new ValidationResult(null);
            }
            return ValidationResult.Success;
        }
    }
}
