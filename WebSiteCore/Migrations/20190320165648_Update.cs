using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSiteCore.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 20, 18, 56, 47, 960, DateTimeKind.Local), new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 20, 18, 56, 47, 961, DateTimeKind.Local), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 20, 18, 56, 47, 961, DateTimeKind.Local), new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 17, 23, 50, 11, 286, DateTimeKind.Local), new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 17, 23, 50, 11, 290, DateTimeKind.Local), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "tblOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2019, 3, 17, 23, 50, 11, 290, DateTimeKind.Local), new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
