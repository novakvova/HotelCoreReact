using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblClients")]
    public class Client
    {
        [ForeignKey("User")]
        public string Id { get; set; }
        public double Rating { get; set; } // оцінка
        public virtual User User { get; set; }
    }
}
