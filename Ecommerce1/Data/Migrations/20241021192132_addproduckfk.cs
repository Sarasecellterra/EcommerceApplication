using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class addproduckfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Id_product",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId_product",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId_product",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Id_product",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductId_product",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Id_product",
                table: "OrderDetails");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_product",
                table: "Orders",
                column: "Id_product");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Id_product",
                table: "Orders",
                column: "Id_product",
                principalTable: "Products",
                principalColumn: "Id_product",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Id_product",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Id_product",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ProductId_product",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_product",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1,
                column: "Id_product",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2,
                column: "Id_product",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 3,
                column: "Id_product",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 1,
                column: "ProductId_product",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 2,
                column: "ProductId_product",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 3,
                column: "ProductId_product",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId_product",
                table: "Orders",
                column: "ProductId_product");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Id_product",
                table: "OrderDetails",
                column: "Id_product");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Id_product",
                table: "OrderDetails",
                column: "Id_product",
                principalTable: "Products",
                principalColumn: "Id_product",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId_product",
                table: "Orders",
                column: "ProductId_product",
                principalTable: "Products",
                principalColumn: "Id_product");
        }
    }
}
