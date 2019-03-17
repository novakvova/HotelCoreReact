using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblOffers")]
    public class Offer : BaseModel<int> // пропозиції(акції)
    {
        public DateTime? From { get; set; } // дата початку дії
        public DateTime? To { get; set; } // дата кінця дії
        public string Description { get; set; } // опис
        public string ImageName { get; set; } // зображення
    }
}
