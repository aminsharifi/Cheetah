using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RIUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserRelationshipIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserRelationship_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserRelationshipIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserRelationship",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserRelationship_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");
        }
    }
}
