using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestDbQueryConsole.Migrations
{
    public partial class Addbasetabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMagazines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMagazines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    MagazineId = table.Column<int>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblArticles_tblAuthors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "tblAuthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblArticles_tblMagazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "tblMagazines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticles_AuthorId",
                table: "tblArticles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticles_MagazineId",
                table: "tblArticles",
                column: "MagazineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArticles");

            migrationBuilder.DropTable(
                name: "tblAuthors");

            migrationBuilder.DropTable(
                name: "tblMagazines");
        }
    }
}
