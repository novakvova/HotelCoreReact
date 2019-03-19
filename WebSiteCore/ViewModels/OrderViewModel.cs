using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.ViewModels
{
    public class OrderViewModel
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double Price { get; set; } 
        public int ApartmentId { get; set; }
        public int BoardTypeId { get; set; }
        public string ClientId { get; set; }
    }
}
