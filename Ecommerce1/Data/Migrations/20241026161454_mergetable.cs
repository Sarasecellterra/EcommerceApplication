using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class mergetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Users_Id_User",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingSessions_Users_Id_user",
                table: "ShoppingSessions");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id_user",
                table: "ShoppingSessions",
                newName: "Id_AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingSessions_Id_user",
                table: "ShoppingSessions",
                newName: "IX_ShoppingSessions_Id_AppUser");

            migrationBuilder.RenameColumn(
                name: "Id_User",
                table: "OrderDetails",
                newName: "Id_AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Id_User",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Id_AppUser");

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Modified", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Phone_number", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, new DateTime(2023, 10, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), "john.doe@gmail.com", false, "John", "Doe", false, null, new DateTime(2023, 10, 10, 12, 45, 0, 0, DateTimeKind.Unspecified), null, null, "gM}56fjg", null, false, null, null, false, null },
                    { 2, 0, null, null, new DateTime(2023, 10, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), "jane.smith@protonmail.com", false, "Jane", "Smith", false, null, new DateTime(2023, 10, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), null, null, ">3LUmc=RvyGRHW%g/-~z", null, false, null, null, false, null },
                    { 3, 0, null, null, new DateTime(2023, 10, 3, 14, 45, 0, 0, DateTimeKind.Unspecified), "mark.williams@domain.com", false, "Mark", "Williams", false, null, new DateTime(2023, 10, 12, 9, 10, 0, 0, DateTimeKind.Unspecified), null, null, "x*D5-UV/89`&^_q,v-H7", null, false, null, null, false, null },
                    { 4, 0, null, null, new DateTime(2023, 10, 4, 9, 50, 0, 0, DateTimeKind.Unspecified), "emma.jones@outlook.com", false, "Emma", "Jones", false, null, new DateTime(2023, 10, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), null, null, "fCxwnchJs1w|-S}YA>-F", null, false, null, null, false, null },
                    { 5, 0, null, null, new DateTime(2023, 10, 5, 8, 30, 0, 0, DateTimeKind.Unspecified), "robert.brown@yahoo.com", false, "Robert", "Brown", false, null, new DateTime(2023, 10, 12, 14, 20, 0, 0, DateTimeKind.Unspecified), null, null, "(y.<vQ3[8w*]KYgMs3ab", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-15", "2023-10-15" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 2,
                columns: new[] { "Created", "Id_Shop_Session", "Modified", "Quantity" },
                values: new object[] { "2023-10-15", 1, "2023-10-15", 1 });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 3,
                columns: new[] { "Created", "Id_Shop_Session", "Id_product", "Modified" },
                values: new object[] { "2023-10-16", 2, 5, "2023-10-16" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-19", "2023-10-19" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2,
                columns: new[] { "Created", "Id_Order", "Modified" },
                values: new object[] { "2023-10-19", 1, "2023-10-19" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-17", "2023-10-17" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-18", "2023-10-18" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1,
                columns: new[] { "Created", "Modified", "Provider" },
                values: new object[] { "2023-10-20", "2023-10-20", "Paypayl" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-21", "2023-10-21" });

            migrationBuilder.UpdateData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 3,
                column: "Total_price",
                value: 3.75m);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_AppUsers_Id_AppUser",
                table: "OrderDetails",
                column: "Id_AppUser",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingSessions_AppUsers_Id_AppUser",
                table: "ShoppingSessions",
                column: "Id_AppUser",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_AppUsers_Id_AppUser",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingSessions_AppUsers_Id_AppUser",
                table: "ShoppingSessions");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "Id_AppUser",
                table: "ShoppingSessions",
                newName: "Id_user");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingSessions_Id_AppUser",
                table: "ShoppingSessions",
                newName: "IX_ShoppingSessions_Id_user");

            migrationBuilder.RenameColumn(
                name: "Id_AppUser",
                table: "OrderDetails",
                newName: "Id_User");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Id_AppUser",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Id_User");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_User);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id_AppUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_User = table.Column<int>(type: "int", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: true),
                    LockoutEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: true),
                    UserId_User = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id_AppUser);
                    table.ForeignKey(
                        name: "FK_AppUser_Users_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Users",
                        principalColumn: "Id_User");
                    table.ForeignKey(
                        name: "FK_AppUser_Users_UserId_User",
                        column: x => x.UserId_User,
                        principalTable: "Users",
                        principalColumn: "Id_User");
                });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-12", "2023-10-12" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 2,
                columns: new[] { "Created", "Id_Shop_Session", "Modified", "Quantity" },
                values: new object[] { "2023-10-13", 2, "2023-10-13", 3 });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id_cart",
                keyValue: 3,
                columns: new[] { "Created", "Id_Shop_Session", "Id_product", "Modified" },
                values: new object[] { "2023-10-14", 3, 3, "2023-10-14" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-12", "2023-10-12" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id_details",
                keyValue: 2,
                columns: new[] { "Created", "Id_Order", "Modified" },
                values: new object[] { "2023-10-13", 2, "2023-10-13" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-12", "2023-10-12" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id_Order",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-13", "2023-10-13" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id_Order", "Created", "Id_product", "Modified" },
                values: new object[] { 3, "2023-10-14", 3, "2023-10-14" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 1,
                columns: new[] { "Created", "Modified", "Provider" },
                values: new object[] { "2023-10-12", "2023-10-12", "PayPal" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id_payments",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { "2023-10-13", "2023-10-13" });

            migrationBuilder.UpdateData(
                table: "ShoppingSessions",
                keyColumn: "Id_Shop_Session",
                keyValue: 3,
                column: "Total_price",
                value: 3.99m);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_User", "Address", "Created", "Email", "FirstName", "LastName", "Modified", "PasswordHash", "Phone_number" },
                values: new object[,]
                {
                    { 1, "1234 Elm St, Springfield", "2023-10-01 10:30:00", "john.doe@gmail.com", "John", "Doe", "2023-10-10 12:45:00", "gM}56fjg", "+1 555-123-4567" },
                    { 2, "5678 Oak St, Greenfield", "2023-10-02 11:20:00", "jane.smith@protonmail.com", "Jane", "Smith", "2023-10-11 15:00:00", ">3LUmc=RvyGRHW%g/-~z", "+1 555-987-6543" },
                    { 3, "9101 Pine St, Brookfield", "2023-10-03 14:45:00", "mark.williams@domain.com", "Mark", "Williams", "2023-10-12 09:10:00", "x*D5-UV/89`&^_q,v-H7", "+1 555-321-7654" },
                    { 4, "2468 Maple St, Hilltown", "2023-10-04 09:50:00", "emma.jones@outlook.com", "Emma", "Jones", "2023-10-11 16:30:00", "fCxwnchJs1w|-S}YA>-F", "+1 555-654-3210" },
                    { 5, "1357 Birch St, Riverview", "2023-10-05 08:30:00", "robert.brown@yahoo.com", "Robert", "Brown", "2023-10-12 14:20:00", "(y.<vQ3[8w*]KYgMs3ab", "+1 555-555-7890" }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id_AppUser", "AccessFailedCount", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FirstName", "Id", "Id_User", "LastName", "LockoutEnabled", "LockoutEnd", "Modified", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId_User", "UserName" },
                values: new object[,]
                {
                    { 1, null, null, "2023-10-01", "john.doe@gmail.com", false, "John", "ef8664ff-7a8f-4648-8510-d52783895fcb", 1, "Doe", null, null, "2023-10-10", null, null, "gM}56fjg", null, null, null, null, null, null },
                    { 2, null, null, "2023-10-02", "jane.smith@protonmail.com", false, "Jane", "e222c884-4380-4b77-9a7e-baeb956fab09", 2, "Smith", null, null, "2023-10-11", null, null, ">3LUmc=RvyGRHW%g/-~z", null, null, null, null, null, null },
                    { 3, null, null, "2023-10-03", "mark.williams@domain.com", false, "Mark", "e7e181fc-7a7b-4aff-8d8a-6cb983bd4d1a", 3, "Williams", null, null, "2023-10-12", null, null, "x*D5-UV/89`&^_q,v-H7", null, null, null, null, null, null },
                    { 4, null, null, "2023-10-04", "emma.jones@outlook.com", false, "Emma", "207a6368-2c82-4bc2-8afd-e2b66a2d5a7e", 4, "Jones", null, null, "2023-10-11", null, null, "fCxwnchJs1w|-S}YA>-F", null, null, null, null, null, null },
                    { 5, null, null, "2023-10-05", "robert.brown@yahoo.com", false, "Robert", "a73e783d-9eea-41f4-8c92-10f71560df28", 5, "Brown", null, null, "2023-10-12", null, null, "(y.<vQ3[8w*]KYgMs3ab", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id_details", "Created", "Id_Order", "Id_User", "Modified" },
                values: new object[] { 3, "2023-10-14", 3, 3, "2023-10-14" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id_payments", "Amount", "Created", "Id_Order", "Modified", "Provider", "Status" },
                values: new object[] { 3, 3.99m, "2023-10-14", 3, "2023-10-14", "Bank Transfer", "Completed" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Id_User",
                table: "AppUser",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_UserId_User",
                table: "AppUser",
                column: "UserId_User");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Users_Id_User",
                table: "OrderDetails",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingSessions_Users_Id_user",
                table: "ShoppingSessions",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
