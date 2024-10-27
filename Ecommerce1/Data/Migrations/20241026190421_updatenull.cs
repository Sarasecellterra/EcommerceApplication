using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatenull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                column: "EmailConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                column: "EmailConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                column: "EmailConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                column: "EmailConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                column: "EmailConfirmed",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4,
                column: "EmailConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5,
                column: "EmailConfirmed",
                value: false);
        }
    }
}
