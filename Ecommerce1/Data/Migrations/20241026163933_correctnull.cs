using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone_number",
                table: "AppUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Phone_number",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "Phone_number", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "Phone_number", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "Phone_number", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "Phone_number", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "EmailConfirmed", "LockoutEnabled", "Phone_number", "TwoFactorEnabled" },
                values: new object[] { null, null, null, null, null });
        }
    }
}
