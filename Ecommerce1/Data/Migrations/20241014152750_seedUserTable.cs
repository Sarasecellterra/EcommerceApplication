using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_User", "Adress", "Created", "Email", "Name", "Password", "Phone_number", "Surname", "modified" },
                values: new object[,]
                {
                    { 1, "1234 Elm St, Springfield", "2023-10-01 10:30:00", "john.doe@gmail.com", "John", "gM}56fjg", "+1 555-123-4567", "Doe", "2023-10-10 12:45:00" },
                    { 2, "5678 Oak St, Greenfield", "2023-10-02 11:20:00", "jane.smith@protonmail.com", "Jane", ">3LUmc=RvyGRHW%g/-~z", "+1 555-987-6543", "Smith", "2023-10-11 15:00:00" },
                    { 3, "9101 Pine St, Brookfield", "2023-10-03 14:45:00", "mark.williams@domain.com", "Mark", "x*D5-UV/89`&^_q,v-H7", "+1 555-321-7654", "Williams", "2023-10-12 09:10:00" },
                    { 4, "2468 Maple St, Hilltown", "2023-10-04 09:50:00", "emma.jones@outlook.com", "Emma", "fCxwnchJs1w|-S}YA>-F", "+1 555-654-3210", "Jones", "2023-10-11 16:30:00" },
                    { 5, "1357 Birch St, Riverview", "2023-10-05 08:30:00", "robert.brown@yahoo.com", "Robert", "(y.<vQ3[8w*]KYgMs3ab", "+1 555-555-7890", "Brown", "2023-10-12 14:20:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_User",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
        }
    }
}
