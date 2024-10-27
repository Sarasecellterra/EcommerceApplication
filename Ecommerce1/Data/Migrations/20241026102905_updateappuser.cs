using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateappuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AppUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { null, "dd40e46e-583c-4903-bfdb-38bbab8e5a78" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { null, "bde7c21e-1b66-47ba-9602-5c3cd5080f86" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { null, "5df81cf7-ded6-4a94-bb1e-caaa2fa62596" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { null, "a6f54453-657f-4a6c-9e98-6e663bd3b5cd" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { null, "35e985f6-d022-4f64-b924-d254ba923d95" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { 0, "81ec43ea-28e3-4c92-aaef-0372dde9e7e4" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { 0, "0edc632b-eedc-4cb8-b8f4-fa963563ca5b" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { 0, "db59bea7-6555-4d9a-aa46-3b2c8775f8a7" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { 0, "c4105e16-794c-4973-aba2-661524e5663b" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "Id" },
                values: new object[] { 0, "fb02c6c2-a4b8-4015-9c5f-f511a4ad1f55" });
        }
    }
}
