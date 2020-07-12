using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseCore.Data.Migrations
{
    public partial class initBase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrtoductId",
                table: "SupplierTb");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "SupplierTb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "SupplierTb");

            migrationBuilder.AddColumn<Guid>(
                name: "PrtoductId",
                table: "SupplierTb",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
