using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctcemailconfirmed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmailConfirmed",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmailConfirmed",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmailConfirmed",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmailConfirmed",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "EmailConfirmed",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "EmailConfirmed",
                value: false);
        }
    }
}
