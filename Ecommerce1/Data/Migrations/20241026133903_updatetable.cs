using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "ef8664ff-7a8f-4648-8510-d52783895fcb", "gM}56fjg" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "e222c884-4380-4b77-9a7e-baeb956fab09", ">3LUmc=RvyGRHW%g/-~z" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "e7e181fc-7a7b-4aff-8d8a-6cb983bd4d1a", "x*D5-UV/89`&^_q,v-H7" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "207a6368-2c82-4bc2-8afd-e2b66a2d5a7e", "fCxwnchJs1w|-S}YA>-F" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "a73e783d-9eea-41f4-8c92-10f71560df28", "(y.<vQ3[8w*]KYgMs3ab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "22c4e778-c604-469a-9f10-3a273b55882b", "Password1" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "7198afbf-f0f0-42cd-8a07-03d88e34fcbc", "Password2" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "ec49831c-7185-4e57-9b2b-b9ae125e6fe9", "Password3" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "c9db7229-bd39-410f-b31c-8e0b7cba08f5", "Password4" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "Id", "PasswordHash" },
                values: new object[] { "a100ffb5-2ac7-416d-a8e4-95ab5d121c9d", "Password5" });
        }
    }
}
