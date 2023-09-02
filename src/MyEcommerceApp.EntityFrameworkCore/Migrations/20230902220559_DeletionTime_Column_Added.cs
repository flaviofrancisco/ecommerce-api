using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class DeletionTime_Column_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "Volumes",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "Taxes",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "Sizes",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "ProductVariants",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "Products",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "DeletedDateTime",
                table: "Categories",
                newName: "DeletionTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Volumes",
                newName: "DeletedDateTime");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Taxes",
                newName: "DeletedDateTime");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Sizes",
                newName: "DeletedDateTime");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "ProductVariants",
                newName: "DeletedDateTime");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Products",
                newName: "DeletedDateTime");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Categories",
                newName: "DeletedDateTime");
        }
    }
}
