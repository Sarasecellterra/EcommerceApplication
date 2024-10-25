using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modified",
                table: "Users",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Users",
                newName: "Address");

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id_AppUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId_User = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id_AppUser);
                    table.ForeignKey(
                        name: "FK_AppUser_Users_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Users",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_Users_UserId_User",
                        column: x => x.UserId_User,
                        principalTable: "Users",
                        principalColumn: "Id_User");
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id_AppUser", "AccessFailedCount", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FirstName", "Id", "Id_User", "LastName", "LockoutEnabled", "LockoutEnd", "Modified", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId_User", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "e98e7439-3ef6-4cf9-99f0-dc496a50e959", "2023-10-01", "john.doe@gmail.com", false, "John", "470e796e-5f54-41cb-b7ee-c9d77386e747", 1, "Doe", false, null, "2023-10-10", null, null, "Password1", null, false, "0192f443-0fa7-4f65-9677-d94687ee825c", false, null, null },
                    { 2, 0, "cbbd1439-33e0-43c4-8185-6247b7d50b08", "2023-10-02", "jane.smith@protonmail.com", false, "Jane", "01eee795-adb5-4c08-ab79-dfecdf65e8d2", 2, "Smith", false, null, "2023-10-11", null, null, "Password2", null, false, "0cc88634-d175-4d63-a691-d8c9adb18164", false, null, null },
                    { 3, 0, "f202b88a-c294-412d-b48f-8afcd3b0d023", "2023-10-03", "mark.williams@domain.com", false, "Mark", "96bddaca-3fbf-4418-9b18-f2f11fd91e2e", 3, "Williams", false, null, "2023-10-12", null, null, "Password3", null, false, "d71f3dc9-9d5a-4ded-8aff-37cf8b314681", false, null, null },
                    { 4, 0, "1381fcd3-c8ba-497d-96c7-c6d65712141f", "2023-10-04", "emma.jones@outlook.com", false, "Emma", "d7fdf1f6-eae7-487c-9c24-c19a12fd63d6", 4, "Jones", false, null, "2023-10-11", null, null, "Password4", null, false, "c7b6ed31-9f81-4d1a-ab4e-7d63e9c33571", false, null, null },
                    { 5, 0, "4ad7f49d-fc4b-45d8-9beb-e63334dd6c65", "2023-10-05", "robert.brown@yahoo.com", false, "Robert", "ce919533-6562-417c-87fb-08bfd15b4fa5", 5, "Brown", false, null, "2023-10-12", null, null, "Password5", null, false, "095658c7-a1ec-48e4-b296-cf459e2a39a3", false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 3,
                column: "Id_discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 4,
                column: "Id_discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 1,
                columns: new[] { "LastName", "PasswordHash" },
                values: new object[] { "Doe", "gM}56fjg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 2,
                columns: new[] { "LastName", "PasswordHash" },
                values: new object[] { "Smith", ">3LUmc=RvyGRHW%g/-~z" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 3,
                columns: new[] { "LastName", "PasswordHash" },
                values: new object[] { "Williams", "x*D5-UV/89`&^_q,v-H7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 4,
                columns: new[] { "LastName", "PasswordHash" },
                values: new object[] { "Jones", "fCxwnchJs1w|-S}YA>-F" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 5,
                columns: new[] { "LastName", "PasswordHash" },
                values: new object[] { "Brown", "(y.<vQ3[8w*]KYgMs3ab" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Id_User",
                table: "AppUser",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_UserId_User",
                table: "AppUser",
                column: "UserId_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "Users",
                newName: "modified");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "Adress");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 3,
                column: "Id_discount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id_product",
                keyValue: 4,
                column: "Id_discount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 1,
                columns: new[] { "Password", "Surname" },
                values: new object[] { "gM}56fjg", "Doe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 2,
                columns: new[] { "Password", "Surname" },
                values: new object[] { ">3LUmc=RvyGRHW%g/-~z", "Smith" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 3,
                columns: new[] { "Password", "Surname" },
                values: new object[] { "x*D5-UV/89`&^_q,v-H7", "Williams" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 4,
                columns: new[] { "Password", "Surname" },
                values: new object[] { "fCxwnchJs1w|-S}YA>-F", "Jones" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 5,
                columns: new[] { "Password", "Surname" },
                values: new object[] { "(y.<vQ3[8w*]KYgMs3ab", "Brown" });
        }
    }
}
