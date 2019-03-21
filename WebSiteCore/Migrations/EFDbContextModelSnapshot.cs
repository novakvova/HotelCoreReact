﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Migrations
{
    [DbContext(typeof(EFDbContext))]
    partial class EFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Area");

                    b.Property<int>("ConvenienceTypeId");

                    b.Property<string>("Description");

                    b.Property<string>("Equipment");

                    b.Property<int>("FloorId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<double>("Price");

                    b.Property<int>("RoomQuantity");

                    b.Property<int>("RoomTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ConvenienceTypeId");

                    b.HasIndex("FloorId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("tblApartments");

                    b.HasData(
                        new { Id = 1, Area = 43.0, ConvenienceTypeId = 1, Description = "Family Room - a perfect solution for family travel. Room consists of a bedroom with a king-size bed and a living room with a comfortable sofa. This stylish and modern room is designed for those who spend time together but value privacy at the same time.", Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", FloorId = 3, Name = "Family Standart", Price = 230.0, RoomQuantity = 2, RoomTypeId = 3 },
                        new { Id = 2, Area = 19.0, ConvenienceTypeId = 1, Description = "Laconic room with one Single bed. Due to the high ergonomics of interior, this room easily contains all the necessary accessories of comfortable life and leaves enough free space at the same time. Maximum efficiency and everything is tuned for best performance.", Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", FloorId = 3, Name = "Single Standart", Price = 145.0, RoomQuantity = 1, RoomTypeId = 1 },
                        new { Id = 3, Area = 44.0, ConvenienceTypeId = 2, Description = "Studio Double Room is intended to become a real peace of heaven for all connoisseurs of space and ergonomics in design. Such components as warm colors in the interior, cozy lighting, and comfortable furniture made of environmentally friendly materials for sure will make your business trip more productive in the afternoon, while a luxurious king-size bed and comfortable a fold-out couch will allow you to relax after a busy day.", Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", FloorId = 2, Name = "Studio Double", Price = 220.0, RoomQuantity = 2, RoomTypeId = 3 },
                        new { Id = 4, Area = 28.0, ConvenienceTypeId = 1, Description = "If you travel as a couple, the luxurious “king size” bed will become a nice and pleasant surprise for you. You will receive maximum pleasure from your sleep without hindering yourself. Compact working table with the right lighting will work favorably for your business mission. Two cozy armchairs at the coffee table are the great reason for nice communication with the cup of tea or coffee. Romance and business are two things very far from each other. But they go with each other with the great harmony in this room.", Equipment = "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", FloorId = 3, Name = "DBL Standart", Price = 180.0, RoomQuantity = 1, RoomTypeId = 3 },
                        new { Id = 5, Area = 28.0, ConvenienceTypeId = 1, Description = "Comfortable, cozy and compact room with two single beds. There is also a spacious bathroom unit with the shower with the natural marble decoration here. Soft orthopedic mattresses will help you to relax after hard working day and to gather strength before your new trips and meetings. Original reproductions on the walls accentuate the rhythm of big megapolis’ life. It’s a perfect option for two people who travel together and receive the full independence and freedom of personal space at the same time.", Equipment = "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", FloorId = 3, Name = "Twin Standart", Price = 160.0, RoomQuantity = 1, RoomTypeId = 2 },
                        new { Id = 6, Area = 31.0, ConvenienceTypeId = 2, Description = "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…", Equipment = "bathroom with shower cabin, bath and bidet , luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", FloorId = 2, Name = "Superior Double", Price = 200.0, RoomQuantity = 1, RoomTypeId = 3 },
                        new { Id = 7, Area = 54.0, ConvenienceTypeId = 3, Description = "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…", Equipment = "bathroom with shower cabin, bath and bidet , kitchen, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobes.", FloorId = 2, Name = "Junior Suite(with min-kitchen)", Price = 250.0, RoomQuantity = 2, RoomTypeId = 3 }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.ApartmentImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppartmentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AppartmentId");

                    b.ToTable("tblApartmentImages");

                    b.HasData(
                        new { Id = 1, AppartmentId = 1, Name = "FamilyStandart_1" },
                        new { Id = 2, AppartmentId = 1, Name = "FamilyStandart_2" },
                        new { Id = 3, AppartmentId = 1, Name = "FamilyStandart_3" },
                        new { Id = 4, AppartmentId = 1, Name = "FamilyStandart_4" },
                        new { Id = 5, AppartmentId = 2, Name = "SingleStandart_1" },
                        new { Id = 6, AppartmentId = 2, Name = "SingleStandart_2" },
                        new { Id = 7, AppartmentId = 2, Name = "SingleStandart_3" },
                        new { Id = 8, AppartmentId = 2, Name = "SingleStandart_4" },
                        new { Id = 9, AppartmentId = 3, Name = "StudioDouble_1" },
                        new { Id = 10, AppartmentId = 3, Name = "StudioDouble_2" },
                        new { Id = 11, AppartmentId = 3, Name = "StudioDouble_3" },
                        new { Id = 12, AppartmentId = 3, Name = "StudioDouble_4" },
                        new { Id = 13, AppartmentId = 4, Name = "DBLStandart_1" },
                        new { Id = 14, AppartmentId = 4, Name = "DBLStandart_2" },
                        new { Id = 15, AppartmentId = 4, Name = "DBLStandart_3" },
                        new { Id = 16, AppartmentId = 5, Name = "TwinStandart_1" },
                        new { Id = 17, AppartmentId = 5, Name = "TwinStandart_2" },
                        new { Id = 18, AppartmentId = 5, Name = "TwinStandart_3" },
                        new { Id = 19, AppartmentId = 6, Name = "SuperiorDouble_1" },
                        new { Id = 20, AppartmentId = 6, Name = "SuperiorDouble_2" },
                        new { Id = 21, AppartmentId = 6, Name = "SuperiorDouble_3" },
                        new { Id = 22, AppartmentId = 7, Name = "JuniorSuite_1" },
                        new { Id = 23, AppartmentId = 7, Name = "JuniorSuite_2" },
                        new { Id = 24, AppartmentId = 7, Name = "JuniorSuite_3" },
                        new { Id = 25, AppartmentId = 7, Name = "JuniorSuite_4" },
                        new { Id = 26, AppartmentId = 7, Name = "JuniorSuite_5" }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.BoardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("tblBoardTypes");

                    b.HasData(
                        new { Id = 1, Name = "Bed and breakfast" },
                        new { Id = 2, Name = "Half board" },
                        new { Id = 3, Name = "Full board" },
                        new { Id = 4, Name = "All inclusive" }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Client", b =>
                {
                    b.Property<string>("Id");

                    b.Property<double>("Rating");

                    b.HasKey("Id");

                    b.ToTable("tblClients");
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.ConvenienceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("tblConvenienceTypes");

                    b.HasData(
                        new { Id = 1, Name = "Standart" },
                        new { Id = 2, Name = "Superior" },
                        new { Id = 3, Name = "Junior suite" }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.DbUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("Gender");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PassportSerialNumber");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Employee", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime?>("HiringDate");

                    b.HasKey("Id");

                    b.ToTable("tblEmployees");
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("tblFloors");

                    b.HasData(
                        new { Id = 1, Description = "Administrative floor", Number = 1 },
                        new { Id = 2, Description = "Standart floor", Number = 2 },
                        new { Id = 3, Description = "Luxurious floor", Number = 3 }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime?>("From");

                    b.Property<string>("ImageName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.ToTable("tblOffers");

                    b.HasData(
                        new { Id = 1, Description = "Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!", From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local), ImageName = "SpringWeekdays_1", Name = "Spring Weekdays", To = new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                        new { Id = 2, Description = "Your discount on weekends (Fri - Sun): 1 day 15% OFF; 2-3 days 25% OFF", From = new DateTime(2019, 3, 20, 11, 17, 17, 721, DateTimeKind.Local), ImageName = "FriSatSun_1", Name = "FriSatSun", To = new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                        new { Id = 3, Description = "Book at our website and get an additional 5% discount of the Best Available Rate - Extra 5% OFF", From = new DateTime(2019, 3, 20, 11, 17, 17, 721, DateTimeKind.Local), ImageName = "BookAtSite_1", Name = "Book at out website", To = new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId");

                    b.Property<int>("BoardTypeId");

                    b.Property<string>("ClientId");

                    b.Property<DateTime?>("From");

                    b.Property<double>("Price");

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("BoardTypeId");

                    b.HasIndex("ClientId");

                    b.ToTable("tblOrders");
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("tblRoomTypes");

                    b.HasData(
                        new { Id = 1, Name = "Single" },
                        new { Id = 2, Name = "Twin" },
                        new { Id = 3, Name = "Double room" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.DbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.DbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebSiteCore.DAL.Entities.DbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.DbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Apartment", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.ConvenienceType", "ConvenienceType")
                        .WithMany("Apartments")
                        .HasForeignKey("ConvenienceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebSiteCore.DAL.Entities.Floor", "Floor")
                        .WithMany("Apartments")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebSiteCore.DAL.Entities.RoomType", "RoomType")
                        .WithMany("Apartments")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.ApartmentImage", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.Apartment", "Apartment")
                        .WithMany("Images")
                        .HasForeignKey("AppartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Client", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.DbUser", "User")
                        .WithOne("Client")
                        .HasForeignKey("WebSiteCore.DAL.Entities.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Employee", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.DbUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("WebSiteCore.DAL.Entities.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebSiteCore.DAL.Entities.Order", b =>
                {
                    b.HasOne("WebSiteCore.DAL.Entities.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebSiteCore.DAL.Entities.BoardType", "BoardType")
                        .WithMany("Orders")
                        .HasForeignKey("BoardTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebSiteCore.DAL.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");
                });
#pragma warning restore 612, 618
        }
    }
}
