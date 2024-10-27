using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class @null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AppUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AppUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AppUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AppUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { 0, false, false, false });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { 0, false, false, false });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { 0, false, false, false });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { 0, false, false, false });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "TwoFactorEnabled" },
                values: new object[] { 0, false, false, false });
        }
    }
}
