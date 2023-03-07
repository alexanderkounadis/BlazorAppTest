using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "Country", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { new Guid("1956f1d9-1187-4aed-a840-b95899d5d9fa"), "King str", "NY", "Mars", "Irene Hunt", "USA", "123-45678", "12345", "NY" },
                    { new Guid("4a1b9a46-0a5c-47df-b13f-5d65e3f85e1e"), "Oxford str", "London", "Microsoft", "Andrew McDonald", "UK", "123-45678", "12345", "West" },
                    { new Guid("896b1368-5b4e-4f9f-bd2d-a2c8e13916a0"), "Ag Georgiou 45", "Patras", "Epsilon", "George Papanikos", "Greece", "123-45678", "12345", "West" },
                    { new Guid("fde440f7-f329-4802-9e6c-2ba1173fa817"), "Wisconsin str", "Madison", "Oracle", "Chris Konor", "USA", "123-45678", "12345", "Milwaukee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
