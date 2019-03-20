using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblFloors")]
    public class Floor // поверх
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; } // опис
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
