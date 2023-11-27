using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market.API.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Price = table.Column<string>(type: "NVARCHAR(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Validity = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
