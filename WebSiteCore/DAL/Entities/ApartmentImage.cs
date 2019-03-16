using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    public class ApartmentImage : BaseModel<int>
    {
        [ForeignKey("Apartment")]
        public int AppartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}