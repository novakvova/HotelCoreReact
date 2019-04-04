using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.ViewModels
{
    public class ApartmentSPViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Equipment { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public int RoomQuantity { get; set; }
        public List<ApartmentImageSPViewModel> Images { get; set; }
        //Serialized as JSON string using HasConversion(...)
        public string ResponseData { get; set; }
    }

    public class ApartmentImageSPViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
