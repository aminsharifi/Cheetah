using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Cleanup2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.RenameColumn(
                name: "S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                newName: "RelatedLocations_S_UserIdRecord");

            migrationBuilder.RenameColumn(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "Locations_S_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_Location_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                newName: "IX_S_Location_RelatedLocations_S_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_Location_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "IX_S_Location_Locations_S_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "Locations_S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "RelatedLocations_S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.RenameColumn(
                name: "RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "S_UserIdRecord1");

            migrationBuilder.RenameColumn(
                name: "Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "S_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_Location_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "IX_S_Location_S_UserIdRecord1");

            migrationBuilder.RenameIndex(
                name: "IX_S_Location_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                newName: "IX_S_Location_S_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord1",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
