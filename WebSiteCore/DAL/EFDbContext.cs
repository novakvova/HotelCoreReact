using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities.SqlViews;

namespace WebSiteCore.DAL.Entities
{
    public class EFDbContext : IdentityDbContext<DbUser>
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
        public virtual DbSet<ApartmentImage> ApartmentImages { get; set; }

        public virtual DbQuery<VApartmentData> VApartmentsData { get; set; }
        public virtual DbQuery<VApartment> VApartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<VApartmentData>().ToView("vApartmentsData");
            modelBuilder.Query<VApartment>().ToView("vApartments");
            base.OnModelCreating(modelBuilder);
        }
    }
}
