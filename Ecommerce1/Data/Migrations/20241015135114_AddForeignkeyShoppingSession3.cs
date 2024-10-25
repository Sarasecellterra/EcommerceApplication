using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignkeyShoppingSession3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Discount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId_product",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id_Discount",
                table: "Products",
                column: "Id_Discount");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Id_Order",
                table: "Payment",
                column: "Id_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId_product",
                table: "Orders",
                column: "ProductId_product");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_Id_Order",
                table: "Order_Detail",
                column: "Id_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_Id_product",
                table: "Order_Detail",
                column: "Id_product");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_Id_User",
                table: "Order_Detail",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_item_Id_user",
                table: "Cart_item",
                column: "Id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_item_Users_Id_user",
                table: "Cart_item",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Detail_Orders_Id_Order",
                table: "Order_Detail",
                column: "Id_Order",
                principalTable: "Orders",
                principalColumn: "Id_Order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Detail_Products_Id_product",
                table: "Order_Detail",
                column: "Id_product",
                principalTable: "Products",
                principalColumn: "Id_product",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Detail_Users_Id_User",
                table: "Order_Detail",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId_product",
                table: "Orders",
                column: "ProductId_product",
                principalTable: "Products",
                principalColumn: "Id_product");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Orders_Id_Order",
                table: "Payment",
                column: "Id_Order",
                principalTable: "Orders",
                principalColumn: "Id_Order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_Id_Discount",
                table: "Products",
                column: "Id_Discount",
                principalTable: "Discounts",
                principalColumn: "Id_discount",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_item_Users_Id_user",
                table: "Cart_item");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Detail_Orders_Id_Order",
                table: "Order_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Detail_Products_Id_product",
                table: "Order_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Detail_Users_Id_User",
                table: "Order_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId_product",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Orders_Id_Order",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_Id_Discount",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id_Discount",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Payment_Id_Order",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId_product",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Order_Detail_Id_Order",
                table: "Order_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Order_Detail_Id_product",
                table: "Order_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Order_Detail_Id_User",
                table: "Order_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Cart_item_Id_user",
                table: "Cart_item");

            migrationBuilder.DropColumn(
                name: "Id_Discount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId_product",
                table: "Orders");
        }
    }
}
