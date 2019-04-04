using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;
using System.Reflection;

namespace WebSiteCore.Migrations
{
    public partial class addspFetchApartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;

            UriBuilder uri = new UriBuilder(codeBase);

            string path = Uri.UnescapeDataString(uri.Path);

            string baseDir = Path.GetDirectoryName(path) + "\\Migrations\\SqlQuery\\SpFetchApartments.sql";

            migrationBuilder.Sql(File.ReadAllText(baseDir));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
