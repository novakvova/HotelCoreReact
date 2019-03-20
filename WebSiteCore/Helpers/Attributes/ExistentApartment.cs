using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Helpers.Attributes
{
    public class ExistentApartment : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _ctx = (EFDbContext)validationContext
                 .GetService(typeof(EFDbContext));
            if(_ctx.Apartments.Any(a => a.Id == (int)value))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Recieved apartment doesn`t exist");
        }
    }
}
