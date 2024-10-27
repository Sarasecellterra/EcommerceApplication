using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAppUserSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1,
                column: "Provider",
                value: "Paypal");

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id_payments", "Amount", "Created", "Id_Order", "Modified", "Provider", "Status" },
                values: new object[] { 3, 8.50m, "2023-10-23", 2, "2023-10-24", "Bank Transfer", "Completed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "91a1807f-d50f-4926-8987-b76b3c64ef2e", false, null, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "c92634d9-2be1-464a-b707-b82b8827d4ce", false, null, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "c53d4774-0bb5-4af0-921c-c76d80d7a1e5", false, null, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "1740b265-a421-4c61-a7f3-228dc1156e02", false, null, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "4759476c-d7de-43fa-a191-12ef68540797", false, null, false });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1,
                column: "Provider",
                value: "Paypayl");
        }
    }
}
