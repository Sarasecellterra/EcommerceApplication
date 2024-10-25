using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddshopsessionCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id_cart", "Created", "Id_user", "Total_Price", "modified" },
                values: new object[,]
                {
                    { 1, "2023-10-12", 1, "5.00", "2023-10-12" },
                    { 2, "2023-10-13", 2, "8.50", "2023-10-13" },
                    { 3, "2023-10-14", 3, "3.99", "2023-10-14" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingSessions",
                columns: new[] { "Id_Shop_Session", "Created", "Id_user", "Modified", "Total_price" },
                values: new object[,]
                {
                    { 1, "2023-10-12", 1, "2023-10-12", "20.00" },
                    { 2, "2023-10-13", 2, "2023-10-13", "15.50" },
                    { 3, "2023-10-14", 3, "2023-10-14", "30.00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 3);
        }
    }
}
