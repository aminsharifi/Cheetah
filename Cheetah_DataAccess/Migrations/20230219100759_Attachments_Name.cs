using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AttachmentsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.RenameColumn(
                name: "APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_P_ProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_P_ProcessEndorsementIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_P_ProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.RenameColumn(
                name: "APV_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_P_ProcessEndorsementsIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_P_ProcessEndorsementsIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_P_ProcessEndorsementsIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");
        }
    }
}
