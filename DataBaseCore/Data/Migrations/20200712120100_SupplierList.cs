using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseCore.Data.Migrations
{
    public partial class SupplierList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PrtoductId",
                table: "SupplierTb",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrtoductId",
                table: "SupplierTb");
        }
    }
}
