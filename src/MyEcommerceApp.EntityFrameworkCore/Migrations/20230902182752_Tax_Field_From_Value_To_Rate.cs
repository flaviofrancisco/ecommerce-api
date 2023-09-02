using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class Tax_Field_From_Value_To_Rate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Taxes");

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "Taxes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Taxes");

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "Taxes",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
