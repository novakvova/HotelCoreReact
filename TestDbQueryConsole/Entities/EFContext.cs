using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDbQueryConsole.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\v11.0;Database=SchoolDB;Trusted_Connection=True;");
        }

        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbQuery<AuthorArticleCount> AuthorArticleCounts { get; set; }
    }
}
