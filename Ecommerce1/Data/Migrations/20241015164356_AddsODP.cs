using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddsODP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id_Order", "Created", "Id_product", "ProductId_product", "modified" },
                values: new object[,]
                {
                    { 1, "2023-10-12", 1, null, "2023-10-12" },
                    { 2, "2023-10-13", 2, null, "2023-10-13" },
                    { 3, "2023-10-14", 3, null, "2023-10-14" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id_details", "Created", "Id_Order", "Id_User", "Id_product", "modified" },
                values: new object[,]
                {
                    { 1, "2023-10-12", 1, 1, 1, "2023-10-12" },
                    { 2, "2023-10-13", 2, 2, 2, "2023-10-13" },
                    { 3, "2023-10-14", 3, 3, 3, "2023-10-14" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id_payments", "Amount", "Created", "Id_Order", "Provider", "Status", "modified" },
                values: new object[,]
                {
                    { 1, "5.00", "2023-10-12", 1, "PayPal", "Completed", "2023-10-12" },
                    { 2, "8.50", "2023-10-13", 2, "Credit Card", "Pending", "2023-10-13" },
                    { 3, "3.99", "2023-10-14", 3, "Bank Transfer", "Completed", "2023-10-14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 3);
        }
    }
}
