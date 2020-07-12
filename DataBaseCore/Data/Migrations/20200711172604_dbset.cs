using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseCore.Data.Migrations
{
    public partial class dbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorTab",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTab", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PrtoductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ColorId = table.Column<Guid>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    Instock = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTb_ColorTab_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ColorTab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTb_SupplierTb_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SupplierTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTb_ColorId",
                table: "ProductTb",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTb_SupplierId",
                table: "ProductTb",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTb");

            migrationBuilder.DropTable(
                name: "ColorTab");

            migrationBuilder.DropTable(
                name: "SupplierTb");
        }
    }
}
