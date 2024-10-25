using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignkeyShoppingSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Shopping_Sessions_Id_user",
                table: "Shopping_Sessions",
                column: "Id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_Shopping_Sessions_Users_Id_user",
                table: "Shopping_Sessions",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shopping_Sessions_Users_Id_user",
                table: "Shopping_Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Shopping_Sessions_Id_user",
                table: "Shopping_Sessions");
        }
    }
}
