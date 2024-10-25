using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class news : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "3a90607a-7f3e-4a50-b061-31da47d90006", "3d2243f4-a284-4ab1-a06d-4b34ea7574c5", "de3c7a2a-2dd8-4392-aa63-2d8f074c0b3e" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "dcde7d25-50a0-475a-89dd-833d83f68ec9", "b377b681-b552-4b9f-b514-ab8e82246dad", "2c09788d-bccb-41eb-a657-06d80efea925" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "0c48a533-a857-4a26-bc3c-1b09d1da064e", "0073dbf3-1040-469d-b2fe-3f34ec31ba77", "2f95d211-9eac-49d6-a38e-ff9e412ade7b" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "b14ee5cb-b318-46da-b9a4-b8957460d698", "8fd75f7d-3eec-41ce-aa88-e72252f1e80e", "6c3a8956-8b02-47e9-882f-f007eea171de" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "3b6e4628-24cd-424a-96bd-ceddfe575b49", "f3d32b57-db2b-41b6-bd48-6c6c40256afe", "259ba0c3-832c-4c13-902d-18b1d99dc686" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "e98e7439-3ef6-4cf9-99f0-dc496a50e959", "470e796e-5f54-41cb-b7ee-c9d77386e747", "0192f443-0fa7-4f65-9677-d94687ee825c" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "cbbd1439-33e0-43c4-8185-6247b7d50b08", "01eee795-adb5-4c08-ab79-dfecdf65e8d2", "0cc88634-d175-4d63-a691-d8c9adb18164" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "f202b88a-c294-412d-b48f-8afcd3b0d023", "96bddaca-3fbf-4418-9b18-f2f11fd91e2e", "d71f3dc9-9d5a-4ded-8aff-37cf8b314681" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "1381fcd3-c8ba-497d-96c7-c6d65712141f", "d7fdf1f6-eae7-487c-9c24-c19a12fd63d6", "c7b6ed31-9f81-4d1a-ab4e-7d63e9c33571" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id_AppUser",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "4ad7f49d-fc4b-45d8-9beb-e63334dd6c65", "ce919533-6562-417c-87fb-08bfd15b4fa5", "095658c7-a1ec-48e4-b296-cf459e2a39a3" });
        }
    }
}
