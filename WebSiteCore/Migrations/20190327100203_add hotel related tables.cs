using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteCore.Migrations
{
    public partial class addhotelrelatedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "tblApartmentImages");

            migrationBuilder.DropTable(
                name: "tblOffers");

            migrationBuilder.DropTable(
                name: "tblOrders");

            migrationBuilder.DropTable(
                name: "tblApartments");

            migrationBuilder.DropTable(
                name: "tblBoardTypes");

            migrationBuilder.DropTable(
                name: "tblConvenienceTypes");

            migrationBuilder.DropTable(
                name: "tblFloors");

            migrationBuilder.DropTable(
                name: "tblRoomTypes");
        }
    }
}
