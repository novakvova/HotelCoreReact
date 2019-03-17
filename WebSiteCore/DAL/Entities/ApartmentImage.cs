using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblApartmentImages")]
    public class ApartmentImage : BaseModel<int>
    {
        [ForeignKey("Apartment")]
        public int AppartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}