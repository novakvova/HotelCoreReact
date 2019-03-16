using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    public class EFDbContext : IdentityDbContext<User>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<ConvenienceType> ConvenienceTypes { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<BoardType> BoardTypes { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConvenienceType>().HasData(
                new ConvenienceType[]
                {
                    new ConvenienceType { Id=1, Name="Standart"},
                    new ConvenienceType { Id=2, Name="Superior"},
                    new ConvenienceType { Id=3, Name="Junior suite"},
                    new ConvenienceType { Id=4, Name="Suite"}
                });
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType[]
                {
                    new RoomType { Id=1, Name="Single"},
                    new RoomType { Id=2, Name="Twin"},
                    new RoomType { Id=3, Name="Double room"}
                });
            modelBuilder.Entity<BoardType>().HasData(
                new BoardType[]
                {
                    new BoardType { Id=1, Name="Bed and breakfast"},
                    new BoardType { Id=2, Name="Half board"},
                    new BoardType { Id=3, Name="Full board"},
                    new BoardType { Id=4, Name="All inclusive"},
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
