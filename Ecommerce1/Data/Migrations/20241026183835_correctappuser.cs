using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctappuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cf9815e1-96b2-4b61-bec1-d486d1164f9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6fae91a9-17ca-4203-a68a-aa89680a221c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "36959a36-2ed7-4483-8482-7a419ca33093");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "72ce56f9-e213-49aa-9f5a-3891e8587917");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "398d7c52-b01b-4ac2-81ee-b56ef5a3d2e6");
        }
    }
}
