using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities.SqlViews
{
    public class VApartApartImg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Equipment { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public int RoomQuantity { get; set; }
        public int ConvenienceTypeId { get; set; }
        public string ConvenienceTypeName { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public int FloorId { get; set; }
        public int FloorNumber { get; set; }
        public string FloorDescription { get; set; }
        public int AprtImageId { get; set; }
        public string AprtImageName { get; set; }
    }
}
