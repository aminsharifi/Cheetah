using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _2122023632 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ParameterList_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_LastUserComment",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_UserComment",
                schema: "Masters",
                table: "M_RequestInformation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_LastUserComment",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_UserComment",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LastUserActionIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LastUserInChargeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RejectReasonIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserActionIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ParameterList_RI_RejectReasonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RejectReasonIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_LastUserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LastUserActionIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_UserActionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserActionIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LastUserInChargeIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
