using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    public abstract class BaseModel<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual T Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
    }
}
