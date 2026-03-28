using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreConsoleAPP.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeandEmployeeCustomerTipsandCategoryEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "People",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ItemCategory",
                table: "Items",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "EmployeeCustomerTips",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCustomerTips", x => new { x.EmployeeID, x.CustomerID });
                    table.ForeignKey(
                        name: "FK_EmployeeCustomerTips_People_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeeCustomerTips_People_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCustomerTips_CustomerID",
                table: "EmployeeCustomerTips",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCustomerTips");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ItemCategory",
                table: "Items");
        }
    }
}
