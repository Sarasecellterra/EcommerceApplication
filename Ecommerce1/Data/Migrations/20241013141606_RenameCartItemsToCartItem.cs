using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameCartItemsToCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_payments",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart_items",
                table: "Cart_items");

            migrationBuilder.RenameTable(
                name: "payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Cart_items",
                newName: "Cart_item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id_payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart_item",
                table: "Cart_item",
                column: "Id_cart");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart_item",
                table: "Cart_item");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "payments");

            migrationBuilder.RenameTable(
                name: "Cart_item",
                newName: "Cart_items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payments",
                table: "payments",
                column: "Id_payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart_items",
                table: "Cart_items",
                column: "Id_cart");
        }
    }
}
