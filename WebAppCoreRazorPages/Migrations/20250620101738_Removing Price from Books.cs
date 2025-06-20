using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCoreRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class RemovingPricefromBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "tbl_Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "tbl_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
