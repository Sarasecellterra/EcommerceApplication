using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDisproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Payment_Orders_Id_Order",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_Id_Discount",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Shopping_Sessions_Users_Id_user",
                table: "Shopping_Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shopping_Sessions",
                table: "Shopping_Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order_Detail",
                table: "Order_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart_item",
                table: "Cart_item");

            migrationBuilder.RenameTable(
                name: "Shopping_Sessions",
                newName: "ShoppingSessions");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Order_Detail",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Cart_item",
                newName: "CartItems");

            migrationBuilder.RenameColumn(
                name: "modified",
                table: "Products",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "Id_Discount",
                table: "Products",
                newName: "Id_discount");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Id_Discount",
                table: "Products",
                newName: "IX_Products_Id_discount");

            migrationBuilder.RenameColumn(
                name: "modified",
                table: "Discounts",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "modified",
                table: "ShoppingSessions",
                newName: "Modified");

            migrationBuilder.RenameIndex(
                name: "IX_Shopping_Sessions_Id_user",
                table: "ShoppingSessions",
                newName: "IX_ShoppingSessions_Id_user");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Id_Order",
                table: "Payments",
                newName: "IX_Payments_Id_Order");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Detail_Id_User",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Id_User");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Detail_Id_product",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Id_product");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Detail_Id_Order",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Id_Order");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_item_Id_user",
                table: "CartItems",
                newName: "IX_CartItems_Id_user");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id_discount",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Percent",
                table: "Discounts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingSessions",
                table: "ShoppingSessions",
                column: "Id_Shop_Session");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id_payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id_details");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id_cart");

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id_discount", "Created", "Description", "Modified", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, "2023-10-01 10:30:00", "10% off all fruits", "2023-10-01 10:30:00", "Fruit Discount", 10m },
                    { 2, "2023-10-02 10:30:00", "15% off on dairy products", "2023-10-02 10:30:00", "Dairy Discount", 15m },
                    { 3, "2023-10-03 10:30:00", "Buy 2 Get 1 Free on bakery items", "2023-10-03 10:30:00", "Bakery Discount", 5m },
                    { 4, "2023-10-03 10:30:00", "Buy 3 Get 1 Free on meat products", "2023-10-03 10:30:00", "Meat Discount", 10m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id_product", "Category", "Created", "Description", "Id_discount", "Modified", "Name", "Price", "SKU" },
                values: new object[,]
                {
                    { 3, "Vegetables", "2023-10-03 11:30:00", "Fresh Carrots", null, "2023-10-07 09:00:00", "Carrot", 0.50m, "VEG-CAR-003" },
                    { 4, "Vegetables", "2023-10-04 14:45:00", "Fresh Lemon", null, "2023-10-08 16:20:00", "Lemon", 2.50m, "VEG-TOM-004" },
                    { 1, "Fruits", "2023-10-01 10:30:00", "Fresh Red Apple", 1, "2023-10-05 14:20:00", "Apple", 0.99m, "FRU-APL-001" },
                    { 2, "Fruits", "2023-10-02 09:15:00", "Exotic Bananas", 1, "2023-10-06 12:40:00", "Banana", 1.20m, "FRU-BAN-002" },
                    { 5, "Dairy", "2023-10-05 08:30:00", "Whole Milk, 1 Gallon", 2, "2023-10-09 15:35:00", "Milk", 3.99m, "DAR-MIL-005" },
                    { 6, "Dairy", "2023-10-06 12:00:00", "Dozen Organic Eggs", 2, "2023-10-10 18:00:00", "Eggs", 2.99m, "DAR-EGG-006" },
                    { 7, "Bakery", "2023-10-07 07:50:00", "Whole Wheat Bread Loaf", 3, "2023-10-11 12:15:00", "Bread", 2.50m, "BAK-BRD-007" },
                    { 8, "Meat", "2023-10-08 09:30:00", "Skinless Boneless Chicken Breast, 1 lb", 4, "2023-10-12 11:45:00", "Chicken Breast", 4.99m, "MEA-CHK-008" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_Id_user",
                table: "CartItems",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Id_Order",
                table: "OrderDetails",
                column: "Id_Order",
                principalTable: "Orders",
                principalColumn: "Id_Order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Id_product",
                table: "OrderDetails",
                column: "Id_product",
                principalTable: "Products",
                principalColumn: "Id_product",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Users_Id_User",
                table: "OrderDetails",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_Id_Order",
                table: "Payments",
                column: "Id_Order",
                principalTable: "Orders",
                principalColumn: "Id_Order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_Id_discount",
                table: "Products",
                column: "Id_discount",
                principalTable: "Discounts",
                principalColumn: "Id_discount");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingSessions_Users_Id_user",
                table: "ShoppingSessions",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_Id_user",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Id_Order",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Id_product",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Users_Id_User",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_Id_Order",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_Id_discount",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingSessions_Users_Id_user",
                table: "ShoppingSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingSessions",
                table: "ShoppingSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id_discount",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id_discount",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id_discount",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id_discount",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "ShoppingSessions",
                newName: "Shopping_Sessions");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "Order_Detail");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "Cart_item");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "Products",
                newName: "modified");

            migrationBuilder.RenameColumn(
                name: "Id_discount",
                table: "Products",
                newName: "Id_Discount");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Id_discount",
                table: "Products",
                newName: "IX_Products_Id_Discount");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "Discounts",
                newName: "modified");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "Shopping_Sessions",
                newName: "modified");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingSessions_Id_user",
                table: "Shopping_Sessions",
                newName: "IX_Shopping_Sessions_Id_user");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Id_Order",
                table: "Payment",
                newName: "IX_Payment_Id_Order");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Id_User",
                table: "Order_Detail",
                newName: "IX_Order_Detail_Id_User");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Id_product",
                table: "Order_Detail",
                newName: "IX_Order_Detail_Id_product");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Id_Order",
                table: "Order_Detail",
                newName: "IX_Order_Detail_Id_Order");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_Id_user",
                table: "Cart_item",
                newName: "IX_Cart_item_Id_user");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Discount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Percent",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shopping_Sessions",
                table: "Shopping_Sessions",
                column: "Id_Shop_Session");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id_payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order_Detail",
                table: "Order_Detail",
                column: "Id_details");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart_item",
                table: "Cart_item",
                column: "Id_cart");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Shopping_Sessions_Users_Id_user",
                table: "Shopping_Sessions",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
