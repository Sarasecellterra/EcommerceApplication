using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { false, "22c4e778-c604-469a-9f10-3a273b55882b" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { false, "7198afbf-f0f0-42cd-8a07-03d88e34fcbc" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { false, "ec49831c-7185-4e57-9b2b-b9ae125e6fe9" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { false, "c9db7229-bd39-410f-b31c-8e0b7cba08f5" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { false, "a100ffb5-2ac7-416d-a8e4-95ab5d121c9d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AppUser",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { null, "1ddbcd1b-e939-45d3-b4e7-778b6aeba817" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { null, "5df6aa52-c483-4db9-b51d-dcf68eaef656" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { null, "8e4f5380-3c46-484b-8ba1-f7c2218fd920" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { null, "78f6e5ff-b27e-4e5f-a3e5-f798d6d4ae7e" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "EmailConfirmed", "Id" },
                values: new object[] { null, "ab622974-e0ee-48fb-9e01-f9e18980cd6e" });
        }
    }
}
