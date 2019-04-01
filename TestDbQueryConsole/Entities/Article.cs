using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDbQueryConsole.Entities
{
    [Table("tblArticles")]
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int MagazineId { get; set; }
        public DateTime PublishDate { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
