using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market.API.Migrations
{
    /// <inheritdoc />
    public partial class DataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Validity",
                table: "Product",
                type: "SMALLDATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Validity",
                table: "Product",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true);
        }
    }
}
