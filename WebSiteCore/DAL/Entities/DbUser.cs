using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{    
    public class DbUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportSerialNumber { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
    }
}
