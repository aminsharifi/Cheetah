using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RI_RejectReason",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_RejectReasonIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_Person",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_PersonIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_PersonIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RejectReasonIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ParameterList_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RejectReasonIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_PersonIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ParameterList_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_RejectReason");

            migrationBuilder.RenameColumn(
                name: "RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_Person");
        }
    }
}
