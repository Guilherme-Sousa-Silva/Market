using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market.API.Migrations
{
    /// <inheritdoc />
    public partial class DataUpdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Validity",
                table: "Product",
                newName: "Modified");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "Product",
                newName: "Validity");
        }
    }
}
