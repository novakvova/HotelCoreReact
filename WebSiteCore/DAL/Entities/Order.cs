using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblOrders")]
    public class Order // замовлення
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public DateTime? From { get; set; } // дата початку бронювання
        public DateTime? To { get; set; } // дата кінця бронювання
        public double Price { get; set; } // ціна за весь час пербування
        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; } // номер
        [ForeignKey("BoardType")]
        public int BoardTypeId { get; set; }
        public virtual BoardType BoardType { get; set; } // тип харчування
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
