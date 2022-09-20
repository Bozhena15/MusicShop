using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicShop.Migrations
{
    public partial class AddDbSetUserOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrder_Users_UserId",
                table: "UserOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrder",
                table: "UserOrder");

            migrationBuilder.RenameTable(
                name: "UserOrder",
                newName: "UserOrders");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrder_UserId",
                table: "UserOrders",
                newName: "IX_UserOrders_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_Users_UserId",
                table: "UserOrders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_Users_UserId",
                table: "UserOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders");

            migrationBuilder.RenameTable(
                name: "UserOrders",
                newName: "UserOrder");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrders_UserId",
                table: "UserOrder",
                newName: "IX_UserOrder_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrder",
                table: "UserOrder",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrder_Users_UserId",
                table: "UserOrder",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
