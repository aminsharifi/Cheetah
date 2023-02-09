using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.RenameColumn(
                name: "UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_P_PositionOrgIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_P_PositionOrgIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "M_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_PositionOrg_UAP_P_PositionOrgIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_PositionOrgIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_PositionOrg_UAP_P_PositionOrgIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropIndex(
                name: "IX_M_UserActionsProcess_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropColumn(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.RenameColumn(
                name: "UAP_P_PositionOrgIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_P_PositionOrgIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");
        }
    }
}
