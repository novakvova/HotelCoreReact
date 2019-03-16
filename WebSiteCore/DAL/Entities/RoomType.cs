using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblRoomTypes")]
    public class RoomType : BaseModel<int> // тип номеру за к-стю ліжок(одномісний, двомісний, двоспальне ліжко)
    {
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
