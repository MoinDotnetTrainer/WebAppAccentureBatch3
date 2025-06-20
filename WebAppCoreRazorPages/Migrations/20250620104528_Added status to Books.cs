using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCoreRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class AddedstatustoBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_Books");
        }
    }
}
