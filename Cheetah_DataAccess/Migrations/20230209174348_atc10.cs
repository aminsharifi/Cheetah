using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.RenameColumn(
                name: "UAP_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_P_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "UAP_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_P_CurrentPEIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_P_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_P_CurrentPEIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_P_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_CurrentPEIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_P_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_P_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_P_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.RenameColumn(
                name: "UAP_P_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "UAP_P_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_CurrentPEIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_P_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_P_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_CurrentPEIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_CurrentPEIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }
    }
}
