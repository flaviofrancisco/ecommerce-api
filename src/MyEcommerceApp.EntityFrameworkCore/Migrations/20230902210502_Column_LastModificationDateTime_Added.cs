using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class Column_LastModificationDateTime_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "Volumes",
                newName: "LastModificationDateTime");

            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "Taxes",
                newName: "LastModificationDateTime");

            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "Sizes",
                newName: "LastModificationDateTime");

            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "ProductVariants",
                newName: "LastModificationDateTime");

            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "Products",
                newName: "LastModificationDateTime");

            migrationBuilder.RenameColumn(
                name: "LastUpateDateTime",
                table: "Categories",
                newName: "LastModificationDateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Taxes",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acronym",
                table: "Taxes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "Volumes",
                newName: "LastUpateDateTime");

            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "Taxes",
                newName: "LastUpateDateTime");

            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "Sizes",
                newName: "LastUpateDateTime");

            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "ProductVariants",
                newName: "LastUpateDateTime");

            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "Products",
                newName: "LastUpateDateTime");

            migrationBuilder.RenameColumn(
                name: "LastModificationDateTime",
                table: "Categories",
                newName: "LastUpateDateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Taxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Acronym",
                table: "Taxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}
