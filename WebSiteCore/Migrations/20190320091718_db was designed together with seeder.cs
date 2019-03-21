using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteCore.Migrations
{
    public partial class dbwasdesignedtogetherwithseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    PassportSerialNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblBoardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBoardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblConvenienceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblConvenienceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblFloors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFloors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    From = table.Column<DateTime>(nullable: true),
                    To = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblRoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblClients_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    HiringDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployees_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblApartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    RoomQuantity = table.Column<int>(nullable: false),
                    ConvenienceTypeId = table.Column<int>(nullable: false),
                    RoomTypeId = table.Column<int>(nullable: false),
                    FloorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblApartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblApartments_tblConvenienceTypes_ConvenienceTypeId",
                        column: x => x.ConvenienceTypeId,
                        principalTable: "tblConvenienceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblApartments_tblFloors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "tblFloors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblApartments_tblRoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "tblRoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblApartmentImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    AppartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblApartmentImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblApartmentImages_tblApartments_AppartmentId",
                        column: x => x.AppartmentId,
                        principalTable: "tblApartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    From = table.Column<DateTime>(nullable: true),
                    To = table.Column<DateTime>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false),
                    BoardTypeId = table.Column<int>(nullable: false),
                    ClientId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblApartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "tblApartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblBoardTypes_BoardTypeId",
                        column: x => x.BoardTypeId,
                        principalTable: "tblBoardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblClients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tblClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblBoardTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bed and breakfast" },
                    { 2, "Half board" },
                    { 3, "Full board" },
                    { 4, "All inclusive" }
                });

            migrationBuilder.InsertData(
                table: "tblConvenienceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Standart" },
                    { 2, "Superior" },
                    { 3, "Junior suite" }
                });

            migrationBuilder.InsertData(
                table: "tblFloors",
                columns: new[] { "Id", "Description", "Number" },
                values: new object[,]
                {
                    { 1, "Administrative floor", 1 },
                    { 2, "Standart floor", 2 },
                    { 3, "Luxurious floor", 3 }
                });

            migrationBuilder.InsertData(
                table: "tblOffers",
                columns: new[] { "Id", "Description", "From", "ImageName", "Name", "To" },
                values: new object[,]
                {
                    { 1, "Great offer in CITYHOTEL! 15% OFF for accommodation on weekdays!", new DateTime(2019, 3, 20, 11, 17, 17, 720, DateTimeKind.Local), "SpringWeekdays_1", "Spring Weekdays", new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Your discount on weekends (Fri - Sun): 1 day 15% OFF; 2-3 days 25% OFF", new DateTime(2019, 3, 20, 11, 17, 17, 721, DateTimeKind.Local), "FriSatSun_1", "FriSatSun", new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Book at our website and get an additional 5% discount of the Best Available Rate - Extra 5% OFF", new DateTime(2019, 3, 20, 11, 17, 17, 721, DateTimeKind.Local), "BookAtSite_1", "Book at out website", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "tblRoomTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Single" },
                    { 2, "Twin" },
                    { 3, "Double room" }
                });

            migrationBuilder.InsertData(
                table: "tblApartments",
                columns: new[] { "Id", "Area", "ConvenienceTypeId", "Description", "Equipment", "FloorId", "Name", "Price", "RoomQuantity", "RoomTypeId" },
                values: new object[,]
                {
                    { 2, 19.0, 1, "Laconic room with one Single bed. Due to the high ergonomics of interior, this room easily contains all the necessary accessories of comfortable life and leaves enough free space at the same time. Maximum efficiency and everything is tuned for best performance.", "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", 3, "Single Standart", 145.0, 1, 1 },
                    { 5, 28.0, 1, "Comfortable, cozy and compact room with two single beds. There is also a spacious bathroom unit with the shower with the natural marble decoration here. Soft orthopedic mattresses will help you to relax after hard working day and to gather strength before your new trips and meetings. Original reproductions on the walls accentuate the rhythm of big megapolis’ life. It’s a perfect option for two people who travel together and receive the full independence and freedom of personal space at the same time.", "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", 3, "Twin Standart", 160.0, 1, 2 },
                    { 1, 43.0, 1, "Family Room - a perfect solution for family travel. Room consists of a bedroom with a king-size bed and a living room with a comfortable sofa. This stylish and modern room is designed for those who spend time together but value privacy at the same time.", "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", 3, "Family Standart", 230.0, 2, 3 },
                    { 3, 44.0, 2, "Studio Double Room is intended to become a real peace of heaven for all connoisseurs of space and ergonomics in design. Such components as warm colors in the interior, cozy lighting, and comfortable furniture made of environmentally friendly materials for sure will make your business trip more productive in the afternoon, while a luxurious king-size bed and comfortable a fold-out couch will allow you to relax after a busy day.", "bathroom with shower, luggage stand, central air conditioning, WI-FI (free of charge), direct local/international connection, mini-safe, mini bar, LED TV, kettle, tea/coffee sets, mineral water, a set of mini cosmetics, bath accessories, bathrobe, hair dryer.", 2, "Studio Double", 220.0, 2, 3 },
                    { 4, 28.0, 1, "If you travel as a couple, the luxurious “king size” bed will become a nice and pleasant surprise for you. You will receive maximum pleasure from your sleep without hindering yourself. Compact working table with the right lighting will work favorably for your business mission. Two cozy armchairs at the coffee table are the great reason for nice communication with the cup of tea or coffee. Romance and business are two things very far from each other. But they go with each other with the great harmony in this room.", "bathroom with shower cabin, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", 3, "DBL Standart", 180.0, 1, 3 },
                    { 6, 31.0, 2, "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…", "bathroom with shower cabin, bath and bidet , luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobe.", 2, "Superior Double", 200.0, 1, 3 },
                    { 7, 54.0, 3, "It’s a choice for the sophisticated travelers for whom the comfortable business always goes inseparably with the comfortable rest. The room is divided into a relaxation zone and another for business activity. There is an ergonomic desk made from the natural wood. Comfortable armchairs near the big picture windows ensure the real relax of high quality. The bathroom unit with the natural marble decoration evokes special emotions. It’s a huge space with the bath, shower and bidet; it has two big windows with the picturesque Kyiv view. It’s natural that bath time can last extremely long…", "bathroom with shower cabin, bath and bidet , kitchen, luggage stand, central air-conditioning system, Wi-Fi (free of charge), direct local/international connection, mini-safe, mini-bar, LED-TV, tea-pot, tea/coffee sets, tableware, mineral water, mini-perfume set, hairdryer, bathrobes.", 2, "Junior Suite(with min-kitchen)", 250.0, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "tblApartmentImages",
                columns: new[] { "Id", "AppartmentId", "Name" },
                values: new object[,]
                {
                    { 5, 2, "SingleStandart_1" },
                    { 24, 7, "JuniorSuite_3" },
                    { 23, 7, "JuniorSuite_2" },
                    { 22, 7, "JuniorSuite_1" },
                    { 21, 6, "SuperiorDouble_3" },
                    { 20, 6, "SuperiorDouble_2" },
                    { 19, 6, "SuperiorDouble_1" },
                    { 15, 4, "DBLStandart_3" },
                    { 14, 4, "DBLStandart_2" },
                    { 13, 4, "DBLStandart_1" },
                    { 12, 3, "StudioDouble_4" },
                    { 11, 3, "StudioDouble_3" },
                    { 10, 3, "StudioDouble_2" },
                    { 9, 3, "StudioDouble_1" },
                    { 4, 1, "FamilyStandart_4" },
                    { 3, 1, "FamilyStandart_3" },
                    { 2, 1, "FamilyStandart_2" },
                    { 1, 1, "FamilyStandart_1" },
                    { 18, 5, "TwinStandart_3" },
                    { 17, 5, "TwinStandart_2" },
                    { 16, 5, "TwinStandart_1" },
                    { 8, 2, "SingleStandart_4" },
                    { 7, 2, "SingleStandart_3" },
                    { 6, 2, "SingleStandart_2" },
                    { 25, 7, "JuniorSuite_4" },
                    { 26, 7, "JuniorSuite_5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblApartmentImages_AppartmentId",
                table: "tblApartmentImages",
                column: "AppartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblApartments_ConvenienceTypeId",
                table: "tblApartments",
                column: "ConvenienceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblApartments_FloorId",
                table: "tblApartments",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblApartments_RoomTypeId",
                table: "tblApartments",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_ApartmentId",
                table: "tblOrders",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_BoardTypeId",
                table: "tblOrders",
                column: "BoardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_ClientId",
                table: "tblOrders",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblApartmentImages");

            migrationBuilder.DropTable(
                name: "tblEmployees");

            migrationBuilder.DropTable(
                name: "tblOffers");

            migrationBuilder.DropTable(
                name: "tblOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tblApartments");

            migrationBuilder.DropTable(
                name: "tblBoardTypes");

            migrationBuilder.DropTable(
                name: "tblClients");

            migrationBuilder.DropTable(
                name: "tblConvenienceTypes");

            migrationBuilder.DropTable(
                name: "tblFloors");

            migrationBuilder.DropTable(
                name: "tblRoomTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
