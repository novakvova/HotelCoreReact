using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    public class SeederDB
    {
        public static void SeedUsers(UserManager<DbUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var email = "admin@gmail.com";
            var roleName = "Admin";
            var count = userManager.Users.Count();
            if (count == 0)
            {
                var user = new DbUser
                {
                    Email = email,
                    UserName = email
                };
                var result = userManager.CreateAsync(user, "Qwerty1-").Result;

                var roleresult = roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                }).Result;

                result = userManager.AddToRoleAsync(user, roleName).Result;
            }

        }

        public static void SeedClients(UserManager<DbUser> userManager, EFDbContext context)
        {
            var count = context.Clients.Count();
            if (count == 0)
            {
                var user = userManager.FindByEmailAsync("admin@gmail.com").Result;
                if (user != null)
                {
                    context.Clients.Add(new Client
                    {
                        Rating = 12,
                        Id = user.Id
                    });
                    context.SaveChanges();
                }
            }
        }

        public static void SeedData(UserManager<DbUser> userManager, EFDbContext context)
        {
            if (context.ConvenienceTypes.Count() == 0)
            {
                var user = userManager.FindByEmailAsync("admin@gmail.com").Result;
                context.ConvenienceTypes.AddRange(
                 new ConvenienceType[]
                 {
                    new ConvenienceType { Id=1, Name="Standart"},
                    new ConvenienceType { Id=2, Name="Superior"},
                    new ConvenienceType { Id=3, Name="Junior suite"}
                 });
                context.RoomTypes.AddRange(
                    new RoomType[]
                    {
                    new RoomType { Id=1, Name="Single"},
                    new RoomType { Id=2, Name="Twin"},
                    new RoomType { Id=3, Name="Double room"}
                    });
                context.BoardTypes.AddRange(
                    new BoardType[]
                    {
                    new BoardType { Id=1, Name="Bed and breakfast"},
                    new BoardType { Id=2, Name="Half board"},
                    new BoardType { Id=3, Name="Full board"},
                    new BoardType { Id=4, Name="All inclusive"},
                    });
                context.Floors.AddRange(
                    new Floor[]
                    {
                    new Floor { Id = 1, Number = 1, Description = "Administrative floor"},
                    new Floor { Id = 2, Number = 2, Description = "Standart floor"},
                    new Floor { Id = 3, Number = 3, Description = "Luxurious floor"}
                    });
                context.Apartments.AddRange(
                    new Apartment[]
                    {
                    new Apartment
                    {
                        Id = 1,
                        Name = "Family Standart",
                        Description = "Family Room - a perfect solution for family travel. " +
                        "Room consists of a bedroom with a king-size bed and a living room with a comfortable sofa. " +
                        "This stylish and modern room is designed for those who spend time together but value privacy at the same time.",
                        Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), " +
                        "direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, " +
                        "a set of mini cosmetics, bath accessories, bathrobe, hair dryer.",
                        Area = 43,
                        Price = 230,
                        RoomQuantity = 2,
                        ConvenienceTypeId = 1,
                        RoomTypeId = 3,
                        FloorId = 3,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 2,
                        Name = "Single Standart",
                        Description = "Laconic room with one Single bed. Due to the high ergonomics of interior, " +
                        "this room easily contains all the necessary accessories of comfortable life and leaves enough free space at the same time. " +
                        "Maximum efficiency and everything is tuned for best performance.",
                        Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, " +
                        "mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.",
                        Area = 19,
                        Price = 145,
                        RoomQuantity = 1,
                        ConvenienceTypeId = 1,
                        RoomTypeId = 1,
                        FloorId = 3,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 3,
                        Name = "Studio Double",
                        Description = "Studio Double Room is intended to become a real peace of heaven for all connoisseurs of space and ergonomics in design. " +
                        "Such components as warm colors in the interior, cozy lighting, and comfortable furniture made of environmentally friendly materials " +
                        "for sure will make your business trip more productive in the afternoon, while a luxurious king-size bed and comfortable a fold-out " +
                        "couch will allow you to relax after a busy day.",
                        Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, " +
                        "mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.",
                        Area = 44,
                        Price = 220,
                        RoomQuantity = 2,
                        ConvenienceTypeId = 2,
                        RoomTypeId = 3,
                        FloorId = 2,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 4,
                        Name = "DBL Standart",
                        Description = "If you travel as a couple, the luxurious “king size” bed will become a nice and pleasant surprise for you. " +
                        "You will receive maximum pleasure from your sleep without hindering yourself. " +
                        "Compact working table with the right lighting will work favorably for your business mission. " +
                        "Two cozy armchairs at the coffee table are the great reason for nice communication with the cup of tea or coffee. " +
                        "Romance and business are two things very far from each other. But they go with each other with the great harmony in this room.",
                        Equipment = "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, " +
                        "mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.",
                        Area = 28,
                        Price = 180,
                        RoomQuantity = 1,
                        ConvenienceTypeId = 1,
                        RoomTypeId = 3,
                        FloorId = 3,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 5,
                        Name = "Twin Standart",
                        Description = "Comfortable, cozy and compact room with two single beds. There is also a spacious bathroom unit with the shower with the natural marble decoration here. " +
                        "Soft orthopedic mattresses will help you to relax after hard working day and to gather strength before your new trips and meetings. " +
                        "Original reproductions on the walls accentuate the rhythm of big megapolis’ life. " +
                        "It’s a perfect option for two people who travel together and receive the full independence and freedom of personal space at the same time.",
                        Equipment = "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, " +
                        "mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.",
                        Area = 28,
                        Price = 160,
                        RoomQuantity = 1,
                        ConvenienceTypeId = 1,
                        RoomTypeId = 2,
                        FloorId = 3,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 6,
                        Name = "Superior Double",
                        Description = "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. " +
                        "The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. " +
                        "Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. " +
                        "It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…",
                        Equipment = "bathroom with shower cabin, bath and bidet , luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, " +
                        "mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.",
                        Area = 31,
                        Price = 200,
                        RoomQuantity = 1,
                        ConvenienceTypeId = 2,
                        RoomTypeId = 3,
                        FloorId = 2,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Id = 7,
                        Name = "Junior Suite(with min-kitchen)",
                        Description = "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. " +
                        "The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. " +
                        "Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. " +
                        "It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…",
                        Equipment = "bathroom with shower cabin, bath and bidet , kitchen, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, " +
                        "mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobes.",
                        Area = 54,
                        Price = 250,
                        RoomQuantity = 2,
                        ConvenienceTypeId = 3,
                        RoomTypeId = 3,
                        FloorId = 2,
                        Images = new List<ApartmentImage>()
                    }
                    });
                context.Orders.AddRange(
                    new Order[]
                    {
                    new Order { Id = 1, From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 10), ApartmentId=1, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 2, From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 10), ApartmentId=2, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 3, From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=1, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 4, From=new DateTime(2020, 1, 3), To=new DateTime(2020, 1, 5), ApartmentId=2, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 5, From=new DateTime(2020, 1, 2), To=new DateTime(2020, 1, 11), ApartmentId=3, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 6, From=new DateTime(2020, 1, 4), To=new DateTime(2020, 1, 5), ApartmentId=3, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 7, From=new DateTime(2020, 1, 6), To=new DateTime(2020, 1, 10), ApartmentId=7, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 8, From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=5, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 9, From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 5), ApartmentId=5, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 10, From=new DateTime(2020, 1, 2), To=new DateTime(2020, 1, 11), ApartmentId=6, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 11, From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 10), ApartmentId=7, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 12, From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 10), ApartmentId=5, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 13, From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=6, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 14, From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 9), ApartmentId=4, Price = 500, BoardTypeId=1, ClientId=user.Id},
                    new Order { Id = 15, From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 11), ApartmentId=4, Price = 500, BoardTypeId=1, ClientId=user.Id}
                    });
                context.ApartmentImages.AddRange(
                    new ApartmentImage[]
                    {
                    new ApartmentImage { Id = 1, Name = $"FamilyStandart_1", AppartmentId = 1},
                    new ApartmentImage { Id = 2, Name = $"FamilyStandart_2", AppartmentId = 1},
                    new ApartmentImage { Id = 3, Name = $"FamilyStandart_3", AppartmentId = 1},
                    new ApartmentImage { Id = 4, Name = $"FamilyStandart_4", AppartmentId = 1},
                    new ApartmentImage { Id = 5, Name = "SingleStandart_1", AppartmentId = 2},
                    new ApartmentImage { Id = 6, Name = "SingleStandart_2", AppartmentId = 2},
                    new ApartmentImage { Id = 7, Name = "SingleStandart_3", AppartmentId = 2},
                    new ApartmentImage { Id = 8, Name = "SingleStandart_4", AppartmentId = 2},
                    new ApartmentImage { Id = 9, Name = "StudioDouble_1", AppartmentId = 3},
                    new ApartmentImage { Id = 10, Name = "StudioDouble_2", AppartmentId = 3},
                    new ApartmentImage { Id = 11, Name = "StudioDouble_3", AppartmentId = 3},
                    new ApartmentImage { Id = 12, Name = "StudioDouble_4", AppartmentId = 3},
                    new ApartmentImage { Id = 13, Name = "DBLStandart_1", AppartmentId = 4},
                    new ApartmentImage { Id = 14, Name = "DBLStandart_2", AppartmentId = 4},
                    new ApartmentImage { Id = 15, Name = "DBLStandart_3", AppartmentId = 4},
                    new ApartmentImage { Id = 16, Name = "TwinStandart_1", AppartmentId = 5},
                    new ApartmentImage { Id = 17, Name = "TwinStandart_2", AppartmentId = 5},
                    new ApartmentImage { Id = 18, Name = "TwinStandart_3", AppartmentId = 5},
                    new ApartmentImage { Id = 19, Name = "SuperiorDouble_1", AppartmentId = 6},
                    new ApartmentImage { Id = 20, Name = "SuperiorDouble_2", AppartmentId = 6},
                    new ApartmentImage { Id = 21, Name = "SuperiorDouble_3", AppartmentId = 6},
                    new ApartmentImage { Id = 22, Name = "JuniorSuite_1", AppartmentId = 7},
                    new ApartmentImage { Id = 23, Name = "JuniorSuite_2", AppartmentId = 7},
                    new ApartmentImage { Id = 24, Name = "JuniorSuite_3", AppartmentId = 7},
                    new ApartmentImage { Id = 25, Name = "JuniorSuite_4", AppartmentId = 7},
                    new ApartmentImage { Id = 26, Name = "JuniorSuite_5", AppartmentId = 7}
                    });
                context.Offers.AddRange(
                    new Offer[]
                    {
                    new Offer
                    {
                        Id = 1,
                        Name = "Spring Weekdays",
                        Description = "Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(60),
                        ImageName = "SpringWeekdays_1"
                    },
                     new Offer
                    {
                        Id = 2,
                        Name = "FriSatSun",
                        Description = "Your discount on weekends (Fri - Sun): 1 day 15% OFF; 2-3 days 25% OFF",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(120),
                        ImageName = "FriSatSun_1"
                    },
                    new Offer
                    {
                        Id = 3,
                        Name = "Book at out website",
                        Description = "Book at our website and get an additional 5% discount of the Best Available Rate - Extra 5% OFF",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(360),
                        ImageName = "BookAtSite_1"
                    }
                    });
                context.SaveChanges();
            }
        }

        public static void Seed(IServiceProvider services)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                SeederDB.SeedUsers(manager, managerRole);
                SeederDB.SeedClients(manager, context);
                SeederDB.SeedData(manager, context);
            }
        }
    }
}
