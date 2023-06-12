using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Delete_BossUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_User_User_BossUserId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_User_BossUserId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "User_BossUserId",
                schema: "Dimentions",
                table: "D_User");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_BossUserId",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_BossUserId",
                schema: "Dimentions",
                table: "D_User",
                column: "User_BossUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_D_User_User_BossUserId",
                schema: "Dimentions",
                table: "D_User",
                column: "User_BossUserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");
        }
    }
}
