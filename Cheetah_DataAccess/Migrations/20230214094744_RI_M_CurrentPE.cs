using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RIMCurrentPE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_M_CurrentPEIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_M_CurrentPEIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_M_CurrentPE_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_M_CurrentPEIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CurrentPE",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CurrentPE_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_ActiveProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_ActiveProcessEndorsementIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ActiveProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");
        }
    }
}
