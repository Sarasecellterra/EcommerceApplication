using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
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
                });

            // Inserting seed data for AppUser table
            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id_AppUser", "Id_User", "Email", "FirstName", "LastName", "Created", "Modified" },
                values: new object[,]
                {
                    { 1, 1, "john.doe@gmail.com", "John", "Doe", "2023-10-01", "2023-10-10" },
                    { 2, 2, "jane.smith@protonmail.com", "Jane", "Smith", "2023-10-02", "2023-10-11" },
                    { 3, 3, "mark.williams@domain.com", "Mark", "Williams", "2023-10-03", "2023-10-12" },
                    { 4, 4, "emma.jones@outlook.com", "Emma", "Jones", "2023-10-04", "2023-10-11" },
                    { 5, 5, "robert.brown@yahoo.com", "Robert", "Brown", "2023-10-05", "2023-10-12" }
                });

            // Updates in Products and Users tables as per your original requirements
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

