using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class DropColumnsAppusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modified",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "91a1807f-d50f-4926-8987-b76b3c64ef2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Created" },
                values: new object[] { "c92634d9-2be1-464a-b707-b82b8827d4ce", new DateTime(2023, 10, 2, 11, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c53d4774-0bb5-4af0-921c-c76d80d7a1e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "1740b265-a421-4c61-a7f3-228dc1156e02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4759476c-d7de-43fa-a191-12ef68540797");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Modified" },
                values: new object[] { null, new DateTime(2023, 10, 10, 12, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Created", "Modified" },
                values: new object[] { null, new DateTime(2023, 10, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Modified" },
                values: new object[] { null, new DateTime(2023, 10, 12, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Modified" },
                values: new object[] { null, new DateTime(2023, 10, 11, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Modified" },
                values: new object[] { null, new DateTime(2023, 10, 12, 14, 20, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
