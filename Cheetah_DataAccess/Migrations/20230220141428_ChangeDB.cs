using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CurrentPE_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropTable(
                name: "M_CurrentPE",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "P_UserAction",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_UserActionGroup",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "M_AllApproveIdRecord1");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_M_AllApproveIdRecord1");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord1",
                schema: "Masters",
                table: "M_Approve",
                column: "M_AllApproveIdRecord1",
                principalSchema: "Masters",
                principalTable: "M_AllApprove",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord1",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.RenameColumn(
                name: "M_AllApproveIdRecord1",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_UserActionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_M_AllApproveIdRecord1",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_UserActionIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_UserActionGroup",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UserActionGroup", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_UserAction",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UAUserActionGroupIdRecord = table.Column<long>(name: "UA_UserActionGroupIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UserAction", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_UserAction_P_UserActionGroup_UA_UserActionGroupIdRecord",
                        column: x => x.UAUserActionGroupIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_UserActionGroup",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_CurrentPE",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    CPEActive = table.Column<bool>(name: "CPE_Active", type: "bit", nullable: true),
                    CPEProcessEndorsementsIdRecord = table.Column<long>(name: "CPE_ProcessEndorsementsIdRecord", type: "bigint", nullable: true),
                    CPEUserActionIdRecord = table.Column<long>(name: "CPE_UserActionIdRecord", type: "bigint", nullable: true),
                    CPEUserIdRecord = table.Column<long>(name: "CPE_UserIdRecord", type: "bigint", nullable: true),
                    MRequestInformationIdRecord = table.Column<long>(name: "M_RequestInformationIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CurrentPE", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_M_RequestInformation_M_RequestInformationIdRecord",
                        column: x => x.MRequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_P_ProcessEndorsement_CPE_ProcessEndorsementsIdRecord",
                        column: x => x.CPEProcessEndorsementsIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_P_UserAction_CPE_UserActionIdRecord",
                        column: x => x.CPEUserActionIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_UserAction",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_S_User_CPE_UserIdRecord",
                        column: x => x.CPEUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_M_CurrentPEIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_ProcessEndorsementsIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserActionIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserActionIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_UserAction_UA_UserActionGroupIdRecord",
                schema: "Parameters",
                table: "P_UserAction",
                column: "UA_UserActionGroupIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_UserActionIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_M_CurrentPE_RI_M_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_M_CurrentPEIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CurrentPE",
                principalColumn: "IdRecord");
        }
    }
}
