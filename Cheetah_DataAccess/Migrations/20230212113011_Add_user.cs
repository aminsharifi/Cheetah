using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Adduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_UserRelationshipIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_UserRelationship_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_UserRelationshipIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserRelationship",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_UserRelationship_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User");
        }
    }
}
