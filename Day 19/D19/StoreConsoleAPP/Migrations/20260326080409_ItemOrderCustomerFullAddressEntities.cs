using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreConsoleAPP.Migrations
{
    /// <inheritdoc />
    public partial class ItemOrderCustomerFullAddressEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITemName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Address_ApNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    Address_City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address_Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address_FirstLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address_FloorNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    Address_SecondLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address_ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastVisit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTotal = table.Column<decimal>(type: "money", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BillingAddress_ApNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    BillingAddress_City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BillingAddress_Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BillingAddress_FirstLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BillingAddress_FloorNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    BillingAddress_SecondLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BillingAddress_ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ShippingAddress_ApNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    ShippingAddress_City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ShippingAddress_Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShippingAddress_FirstLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShippingAddress_FloorNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    ShippingAddress_SecondLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippingAddress_ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_People_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrder",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrder", x => new { x.ItemsId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_ItemOrder_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrder_OrdersId",
                table: "ItemOrder",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOrder");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
