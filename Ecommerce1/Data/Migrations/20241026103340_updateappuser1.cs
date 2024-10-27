using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateappuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Users_Id_User",
                table: "AppUser");

            migrationBuilder.AlterColumn<string>(
                name: "Modified",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id_User",
                table: "AppUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                column: "Id",
                value: "1ddbcd1b-e939-45d3-b4e7-778b6aeba817");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                column: "Id",
                value: "5df6aa52-c483-4db9-b51d-dcf68eaef656");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                column: "Id",
                value: "8e4f5380-3c46-484b-8ba1-f7c2218fd920");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                column: "Id",
                value: "78f6e5ff-b27e-4e5f-a3e5-f798d6d4ae7e");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                column: "Id",
                value: "ab622974-e0ee-48fb-9e01-f9e18980cd6e");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Users_Id_User",
                table: "AppUser",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Users_Id_User",
                table: "AppUser");

            migrationBuilder.AlterColumn<string>(
                name: "Modified",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_User",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AlterColumn<string>(
                name: "Created",
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
                column: "Id",
                value: "dd40e46e-583c-4903-bfdb-38bbab8e5a78");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                column: "Id",
                value: "bde7c21e-1b66-47ba-9602-5c3cd5080f86");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                column: "Id",
                value: "5df81cf7-ded6-4a94-bb1e-caaa2fa62596");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                column: "Id",
                value: "a6f54453-657f-4a6c-9e98-6e663bd3b5cd");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                column: "Id",
                value: "35e985f6-d022-4f64-b924-d254ba923d95");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Users_Id_User",
                table: "AppUser",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
