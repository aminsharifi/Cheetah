using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProcessEndorsementToApprove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_P_ProcessEndorsementsIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_P_ProcessEndorsementsIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropIndex(
                name: "IX_M_Approve_APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "APV_P_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_Approve");
        }
    }
}
