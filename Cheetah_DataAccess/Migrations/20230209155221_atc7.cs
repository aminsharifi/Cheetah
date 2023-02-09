using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_CallWebService_M_RequestInformation_CWS_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropForeignKey(
                name: "FK_M_CurrentPE_M_RequestInformation_CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropForeignKey(
                name: "FK_M_CurrentPE_M_UserActionsProcess_CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropIndex(
                name: "IX_M_CurrentPE_CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropIndex(
                name: "IX_M_CurrentPE_CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.RenameColumn(
                name: "CWS_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                newName: "M_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_CallWebService_CWS_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                newName: "IX_M_CallWebService_M_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CallWebService_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "M_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_CallWebService_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.RenameColumn(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                newName: "CWS_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_CallWebService_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                newName: "IX_M_CallWebService_CWS_RequestInformationIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserActionsProcessIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CallWebService_M_RequestInformation_CWS_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "CWS_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CurrentPE_M_RequestInformation_CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CurrentPE_M_UserActionsProcess_CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserActionsProcessIdRecord",
                principalSchema: "Masters",
                principalTable: "M_UserActionsProcess",
                principalColumn: "IdRecord");
        }
    }
}
