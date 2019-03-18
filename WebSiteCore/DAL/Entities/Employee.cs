using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblEmployees")]
    public class Employee
    {
        [ForeignKey("User")]
        public string Id { get; set; }
        public DateTime? HiringDate { get; set; } // дата найняття на роботу
        public virtual DbUser User { get; set; }
    }
}
