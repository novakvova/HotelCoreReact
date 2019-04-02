using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                var convenienceTypes = new ConvenienceType[]
                {
                    new ConvenienceType { Name="Standart"},
                    new ConvenienceType { Name="Superior"},
                    new ConvenienceType { Name="Junior suite"}
                };
                context.ConvenienceTypes.AddRange(convenienceTypes);
                var roomTypes = new RoomType[]
                {
                    new RoomType { Name="Single"},
                    new RoomType { Name="Twin"},
                    new RoomType { Name="Double room"}
                };
                context.RoomTypes.AddRange(roomTypes);
                var boardTypes = new BoardType[]
                {
                    new BoardType { Name="Bed and breakfast"},
                    new BoardType { Name="Half board"},
                    new BoardType { Name="Full board"},
                    new BoardType { Name="All inclusive"},
                };
                context.BoardTypes.AddRange(boardTypes);
                var floors = new Floor[]
                {
                    new Floor { Number = 1, Description = "Administrative floor"},
                    new Floor { Number = 2, Description = "Standart floor"},
                    new Floor { Number = 3, Description = "Luxurious floor"}
                };
                context.Floors.AddRange(floors);
                var apartments = new Apartment[]
                {
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[0].Id,
                        RoomTypeId = roomTypes[2].Id,
                        FloorId = floors[2].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
                        Name = "Single Standart",
                        Description = "Laconic room with one Single bed. Due to the high ergonomics of interior, " +
                        "this room easily contains all the necessary accessories of comfortable life and leaves enough free space at the same time. " +
                        "Maximum efficiency and everything is tuned for best performance.",
                        Equipment = "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, " +
                        "mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.",
                        Area = 19,
                        Price = 145,
                        RoomQuantity = 1,
                        ConvenienceTypeId = convenienceTypes[0].Id,
                        RoomTypeId = roomTypes[0].Id,
                        FloorId = floors[2].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[1].Id,
                        RoomTypeId = roomTypes[2].Id,
                        FloorId = floors[1].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[0].Id,
                        RoomTypeId = roomTypes[2].Id,
                        FloorId = floors[2].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[0].Id,
                        RoomTypeId = roomTypes[1].Id,
                        FloorId = floors[2].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[1].Id,
                        RoomTypeId = roomTypes[2].Id,
                        FloorId = floors[1].Id,
                        Images = new List<ApartmentImage>()
                    },
                    new Apartment
                    {
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
                        ConvenienceTypeId = convenienceTypes[2].Id,
                        RoomTypeId = roomTypes[2].Id,
                        FloorId = floors[1].Id,
                        Images = new List<ApartmentImage>()
                    }
                };
                context.Apartments.AddRange(apartments);
                var orders = new Order[]
                {
                    new Order { From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 10), ApartmentId=apartments[0].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 10), ApartmentId=apartments[1].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=apartments[0].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 3), To=new DateTime(2020, 1, 5), ApartmentId=apartments[1].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 2), To=new DateTime(2020, 1, 11), ApartmentId=apartments[2].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 4), To=new DateTime(2020, 1, 5), ApartmentId=apartments[2].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 6), To=new DateTime(2020, 1, 10), ApartmentId=apartments[6].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=apartments[4].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 5), ApartmentId=apartments[4].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 2), To=new DateTime(2020, 1, 11), ApartmentId=apartments[5].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 1), To=new DateTime(2020, 1, 10), ApartmentId=apartments[6].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 10), ApartmentId=apartments[4].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 12), ApartmentId=apartments[5].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 8), To=new DateTime(2020, 1, 9), ApartmentId=apartments[3].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id},
                    new Order { From=new DateTime(2020, 1, 7), To=new DateTime(2020, 1, 11), ApartmentId=apartments[3].Id, Price = 500, BoardTypeId=boardTypes[0].Id, ClientId=user.Id}
                };
                context.Orders.AddRange(orders);
                var apartmentImages = new ApartmentImage[]
                {
                    new ApartmentImage { Name = "FamilyStandart_1.jpg", AppartmentId = apartments[0].Id},
                    new ApartmentImage { Name = "FamilyStandart_2.jpg", AppartmentId = apartments[0].Id},
                    new ApartmentImage { Name = "FamilyStandart_3.jpg", AppartmentId = apartments[0].Id},
                    new ApartmentImage { Name = "FamilyStandart_4.jpg", AppartmentId = apartments[0].Id},
                    new ApartmentImage { Name = "SingleStandart_1.jpg", AppartmentId = apartments[1].Id},
                    new ApartmentImage { Name = "SingleStandart_2.jpg", AppartmentId = apartments[1].Id},
                    new ApartmentImage { Name = "SingleStandart_3.jpg", AppartmentId = apartments[1].Id},
                    new ApartmentImage { Name = "SingleStandart_4.jpg", AppartmentId = apartments[1].Id},
                    new ApartmentImage { Name = "StudioDouble_1.jpg", AppartmentId = apartments[2].Id},
                    new ApartmentImage { Name = "StudioDouble_2.jpg", AppartmentId = apartments[2].Id},
                    new ApartmentImage { Name = "StudioDouble_3.jpg", AppartmentId = apartments[2].Id},
                    new ApartmentImage { Name = "StudioDouble_4.jpg", AppartmentId = apartments[2].Id},
                    new ApartmentImage { Name = "DBLStandart_1.jpg", AppartmentId = apartments[3].Id},
                    new ApartmentImage { Name = "DBLStandart_2.jpg", AppartmentId = apartments[3].Id},
                    new ApartmentImage { Name = "DBLStandart_3.jpg", AppartmentId = apartments[3].Id},
                    new ApartmentImage { Name = "TwinStandart_1.jpg", AppartmentId = apartments[4].Id},
                    new ApartmentImage { Name = "TwinStandart_2.jpg", AppartmentId = apartments[4].Id},
                    new ApartmentImage { Name = "TwinStandart_3.jpg", AppartmentId = apartments[4].Id},
                    new ApartmentImage { Name = "SuperiorDouble_1.jpg", AppartmentId = apartments[5].Id},
                    new ApartmentImage { Name = "SuperiorDouble_2.jpg", AppartmentId = apartments[5].Id},
                    new ApartmentImage { Name = "SuperiorDouble_3.jpg", AppartmentId = apartments[5].Id},
                    new ApartmentImage { Name = "JuniorSuite_1.jpg", AppartmentId = apartments[6].Id},
                    new ApartmentImage { Name = "JuniorSuite_2.jpg", AppartmentId = apartments[6].Id},
                    new ApartmentImage { Name = "JuniorSuite_3.jpg", AppartmentId = apartments[6].Id},
                    new ApartmentImage { Name = "JuniorSuite_4.jpg", AppartmentId = apartments[6].Id},
                    new ApartmentImage { Name = "JuniorSuite_5.jpg", AppartmentId = apartments[6].Id}
                };
                context.ApartmentImages.AddRange(apartmentImages);
                var offers = new Offer[]
                {
                    new Offer
                    {
                        Name = "Spring Weekdays",
                        Description = "Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(60),
                        ImageName = "SpringWeekdays_1.jpeg"
                    },
                     new Offer
                    {
                        Name = "FriSatSun",
                        Description = "Your discount on weekends (Fri - Sun): 1 day 15% OFF; 2-3 days 25% OFF",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(120),
                        ImageName = "FriSatSun_1.jpeg"
                    },
                    new Offer
                    {
                        Name = "Book at out website",
                        Description = "Book at our website and get an additional 5% discount of the Best Available Rate - Extra 5% OFF",
                        From = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local),
                        To = new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local).AddDays(360),
                        ImageName = "BookAtSite_1.jpg"
                    }
                };
                context.Offers.AddRange(offers);
                context.SaveChanges();
            }

            //var conviences = new List<ConvenienceType>();
            //var faker = new Faker("en");
            //context.ConvenienceTypes.AddRange(
            //    new ConvenienceType { Name = "Standart" },
            //    new ConvenienceType { Name = "Superior" },
            //    new ConvenienceType { Name = "Junior suite" }
            //);
            //context.RoomTypes.AddRange(
            //    new RoomType { Name = "Single" },
            //    new RoomType { Name = "Twin" },
            //    new RoomType { Name = "Double room" }
            //);
            //context.Floors.AddRange(
            //    new Floor { Number = 1, Description = "Administrative floor" },
            //    new Floor { Number = 2, Description = "Standart floor" },
            //    new Floor { Number = 3, Description = "Luxurious floor" }
            //);
            //context.SaveChanges();

            ////var apartIds = 1;
            //var apartmentsName = new[] { "Family Standart", "Single Standart", "Studio Double", "DBL Standart", "Twin Standart", "Superior Double", "Junior Suite(with min-kitchen)" };
            //var apartGenerator = new Faker<Apartment>()
            //                        .StrictMode(false)
            //                        //.RuleFor(a => a.Id, f => apartIds++)
            //                        .RuleFor(a => a.Name, f => f.PickRandom(apartmentsName))
            //                        .RuleFor(a => a.Description, f => f.Lorem.Sentence())
            //                        .RuleFor(a => a.Equipment, f => f.Lorem.Sentence())
            //                        .RuleFor(a => a.Area, f => f.Random.Number(20, 80))
            //                        .RuleFor(a => a.Price, f => f.Random.Number(120, 250))
            //                        .RuleFor(a => a.RoomQuantity, f => f.Random.Number(1, 2))
            //                        .RuleFor(a => a.ConvenienceTypeId, f => f.Random.Number(1, 3))
            //                        .RuleFor(a => a.RoomTypeId, f => f.Random.Number(1, 3))
            //                        .RuleFor(a => a.FloorId, f => f.Random.Number(2, 3));
            //var data = apartGenerator.Generate(20);

            //context.AddRange(data);
            //context.SaveChanges();
            //context.AddRange(apartGenerator.Generate(200000).ToArray());
            //context.SaveChanges();
            //Debug.WriteLine("Bingo1!");
            ////apartIds = 1;
            ////var imageId = 1;
            //var imageGenerator = new Faker<ApartmentImage>()
            //                        .StrictMode(false)
            //                        .RuleFor(i => i.Name, f => f.Lorem.Sentence())
            //                        //.RuleFor(i => i.Id, f => imageId++)
            //                        .RuleFor(i => i.AppartmentId, f => f.Random.Number(1, 200000));
            //context.ApartmentImages.AddRange(imageGenerator.Generate(600000).ToArray());
            //Debug.WriteLine("Bingo2!");
            //context.SaveChanges();
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
