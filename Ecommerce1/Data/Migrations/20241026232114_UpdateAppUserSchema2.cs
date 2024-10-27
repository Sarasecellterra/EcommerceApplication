using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAppUserSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id_Appuser",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id_Appuser", "Created", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), "john.doe@gmail.com", false, "John", "Doe", null, null, null, "gM}56fjg", null, false, null },
                    { 2, new DateTime(2023, 10, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), "jane.smith@protonmail.com", false, "Jane", "Smith", null, null, null, ">3LUmc=RvyGRHW%g/-~z", null, false, null },
                    { 3, new DateTime(2023, 10, 3, 14, 45, 0, 0, DateTimeKind.Unspecified), "mark.williams@domain.com", false, "Mark", "Williams", null, null, null, "x*D5-UV/89`&^_q,v-H7", null, false, null },
                    { 4, new DateTime(2023, 10, 4, 9, 50, 0, 0, DateTimeKind.Unspecified), "emma.jones@outlook.com", false, "Emma", "Jones", null, null, null, "fCxwnchJs1w|-S}YA>-F", null, false, null },
                    { 5, new DateTime(2023, 10, 5, 8, 30, 0, 0, DateTimeKind.Unspecified), "robert.brown@yahoo.com", false, "Robert", "Brown", null, null, null, "(y.<vQ3[8w*]KYgMs3ab", null, false, null }
                });
        }
    }
}
