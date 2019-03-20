using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Helpers.Attributes
{
    public class ExistentBoardType : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _ctx = (EFDbContext)validationContext
                .GetService(typeof(EFDbContext));
            if(_ctx.BoardTypes.Any(b => b.Id == (int)value))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Recieved board type doesn`t exist");
        }
    }
}
