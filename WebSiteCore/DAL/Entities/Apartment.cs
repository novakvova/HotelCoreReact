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
        public string Equipment { get; set; } // оснащення
        public double Area { get; set; } // площа
        public double Price { get; set; } // ціна
        public int RoomQuantity { get; set; } // к-сть кімнат
        [ForeignKey("ConvenienceType")]
        public int ConvenienceTypeId { get; set; }
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        [ForeignKey("Floor")]
        public int FloorId { get; set; }
        public virtual ConvenienceType ConvenienceType { get; set; } // тип номеру за зручностями(стандарт, люкс, ...)
        public virtual RoomType RoomType { get; set; } // тип номеру за к-стю ліжок(одномісний, двомісний, двоспальне ліжко)
        public virtual Floor Floor { get; set; } // поверх
        public virtual ICollection<ApartmentImage> Images { get; set; }
    }
}
