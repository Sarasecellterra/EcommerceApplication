using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class addappusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {



                 

      
                 
                 

        


        
      

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
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: true),
                    LockoutEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    UserId_User = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { 1, 0, null, "2023-10-01", "john.doe@gmail.com", null, "John", "81ec43ea-28e3-4c92-aaef-0372dde9e7e4", 1, "Doe", null, null, "2023-10-10", null, null, "Password1", null, null, null, null, null, null },
                    { 2, 0, null, "2023-10-02", "jane.smith@protonmail.com", null, "Jane", "0edc632b-eedc-4cb8-b8f4-fa963563ca5b", 2, "Smith", null, null, "2023-10-11", null, null, "Password2", null, null, null, null, null, null },
                    { 3, 0, null, "2023-10-03", "mark.williams@domain.com", null, "Mark", "db59bea7-6555-4d9a-aa46-3b2c8775f8a7", 3, "Williams", null, null, "2023-10-12", null, null, "Password3", null, null, null, null, null, null },
                    { 4, 0, null, "2023-10-04", "emma.jones@outlook.com", null, "Emma", "c4105e16-794c-4973-aba2-661524e5663b", 4, "Jones", null, null, "2023-10-11", null, null, "Password4", null, null, null, null, null, null },
                    { 5, 0, null, "2023-10-05", "robert.brown@yahoo.com", null, "Robert", "fb02c6c2-a4b8-4015-9c5f-f511a4ad1f55", 5, "Brown", null, null, "2023-10-12", null, null, "Password5", null, null, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 1,
                columns: new[] { "Id_Shop_Session", "Id_product", "Quantity" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 2,
                columns: new[] { "Id_Shop_Session", "Id_product", "Quantity" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 3,
                columns: new[] { "Id_Shop_Session", "Id_product", "Quantity" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1,
                column: "Amount",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 2,
                column: "Amount",
                value: 8.50m);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3,
                column: "Amount",
                value: 3.99m);

            migrationBuilder.UpdateData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 1,
                column: "Total_price",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 2,
                column: "Total_price",
                value: 8.50m);

            migrationBuilder.UpdateData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 3,
                column: "Total_price",
                value: 3.99m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 1,
                columns: new[] { "Address", "LastName", "PasswordHash" },
                values: new object[] { "1234 Elm St, Springfield", "Doe", "gM}56fjg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 2,
                columns: new[] { "Address", "LastName", "PasswordHash" },
                values: new object[] { "5678 Oak St, Greenfield", "Smith", ">3LUmc=RvyGRHW%g/-~z" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 3,
                columns: new[] { "Address", "LastName", "PasswordHash" },
                values: new object[] { "9101 Pine St, Brookfield", "Williams", "x*D5-UV/89`&^_q,v-H7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 4,
                columns: new[] { "Address", "LastName", "PasswordHash" },
                values: new object[] { "2468 Maple St, Hilltown", "Jones", "fCxwnchJs1w|-S}YA>-F" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 5,
                columns: new[] { "Address", "LastName", "PasswordHash" },
                values: new object[] { "1357 Birch St, Riverview", "Brown", "(y.<vQ3[8w*]KYgMs3ab" });




        }
    }

}