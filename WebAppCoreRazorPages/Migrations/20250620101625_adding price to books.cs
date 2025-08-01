﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCoreRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class addingpricetobooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "tbl_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "tbl_Books");
        }
    }
}
