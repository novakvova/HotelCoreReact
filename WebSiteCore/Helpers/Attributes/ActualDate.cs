using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.Helpers.Attributes
{
    public class ActualDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if((DateTime)value >= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
