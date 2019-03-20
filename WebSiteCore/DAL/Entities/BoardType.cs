using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblBoardTypes")]
    public class BoardType : BaseModel<int> // тип харчування(із сніданком, сніданок вечеря, ...)
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
