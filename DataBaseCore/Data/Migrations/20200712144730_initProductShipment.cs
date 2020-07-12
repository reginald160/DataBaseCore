using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseCore.Data.Migrations
{
    public partial class initProductShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipperName = table.Column<string>(nullable: true),
                    StartCity = table.Column<string>(nullable: true),
                    EndCity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductShipmentJunctionsTb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductsId = table.Column<Guid>(nullable: true),
                    Product = table.Column<Guid>(nullable: false),
                    ShipmentsId = table.Column<long>(nullable: true),
                    Shipment = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShipmentJunctionsTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductShipmentJunctionsTb_ProductTb_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "ProductTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductShipmentJunctionsTb_Shipment_ShipmentsId",
                        column: x => x.ShipmentsId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductShipmentJunctionsTb_ProductsId",
                table: "ProductShipmentJunctionsTb",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShipmentJunctionsTb_ShipmentsId",
                table: "ProductShipmentJunctionsTb",
                column: "ShipmentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductShipmentJunctionsTb");

            migrationBuilder.DropTable(
                name: "Shipment");
        }
    }
}
