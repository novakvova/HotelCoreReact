using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblApartments")]
    public class Apartment : BaseModel<int> // готельний номер
    {
        public string Description { get; set; } // опис
        public double Area { get; set; } // площа
        public double Price { get; set; } // ціна
        [ForeignKey("ConvenienceType")]
        public int ConvenienceTypeId { get; set; }
        public virtual ConvenienceType ConvenienceType { get; set; } // тип номеру за зручностями(стандарт, люкс, ...)
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; } // тип номеру за к-стю ліжок(одномісний, двомісний, двоспальне ліжко)
        [ForeignKey("Floor")]
        public int FloorId { get; set; }
        public virtual Floor Floor { get; set; } // поверх
        public virtual ICollection<ApartmentImage> Images { get; set; }
    }
}
