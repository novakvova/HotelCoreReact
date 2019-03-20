using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblConvenienceTypes")]
    public class ConvenienceType : BaseModel<int> // тип номеру за зручностями(стандарт, люкс, ...)
    {
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
