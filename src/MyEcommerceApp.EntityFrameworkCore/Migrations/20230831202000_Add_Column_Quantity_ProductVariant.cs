using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Quantity_ProductVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductVariants");
        }
    }
}
