using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class resolveconflictorderdetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1,
                column: "Id_AppUser",
                value: 52);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2,
                columns: new[] { "Id_AppUser", "Id_Order" },
                values: new object[] { 51, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id_Order", "Created", "Id_product", "Modified" },
                values: new object[] { 3, "2023-10-18", 5, "2023-10-18" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3,
                columns: new[] { "Created", "Id_Order", "Modified", "Provider", "Status" },
                values: new object[] { "2023-10-21", 3, "2023-10-21", "Credit Card", "Pending" });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id_details", "Created", "Id_AppUser", "Id_Order", "Modified" },
                values: new object[] { 3, "2023-10-19", 53, 3, "2023-10-19" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1,
                column: "Id_AppUser",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2,
                columns: new[] { "Id_AppUser", "Id_Order" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3,
                columns: new[] { "Created", "Id_Order", "Modified", "Provider", "Status" },
                values: new object[] { "2023-10-23", 2, "2023-10-24", "Bank Transfer", "Completed" });
        }
    }
}
