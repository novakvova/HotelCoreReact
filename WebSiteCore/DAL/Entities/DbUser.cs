 using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    [Table("tblUsers")]
    public class DbUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportSerialNumber { get; set; } // серійний номер паспорта
        public bool Gender { get; set; }
        public int Age { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
