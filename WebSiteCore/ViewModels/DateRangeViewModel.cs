using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.ViewModels
{
    public class DateRangeViewModel
    {
        //[ActualDate(ErrorMessage = "Starting date isn`t valid")]
        //[Required(ErrorMessage = "Starting date of renting is required")]
        public DateTime From { get; set; }

        //[ActualDate(ErrorMessage = "End date isn`t valid")]
        //[Required(ErrorMessage = "End date of renting is required")]
        public DateTime To { get; set; }
    }
}
