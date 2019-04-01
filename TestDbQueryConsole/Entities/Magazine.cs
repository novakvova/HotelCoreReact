using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDbQueryConsole.Entities
{
    [Table("tblMagazines")]
    public class Magazine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public List<Article> Articles { get; set; }
    }
}
