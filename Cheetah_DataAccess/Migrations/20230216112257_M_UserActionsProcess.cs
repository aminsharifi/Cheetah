using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MUserActionsProcess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_UserActionsProcess",
                schema: "Masters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_UserActionsProcess",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UAPPCurrentPEIdRecord = table.Column<long>(name: "UAP_P_CurrentPEIdRecord", type: "bigint", nullable: true),
                    UAPPPositionOrgIdRecord = table.Column<long>(name: "UAP_P_PositionOrgIdRecord", type: "bigint", nullable: true),
                    UAPPRequestTitleIdRecord = table.Column<long>(name: "UAP_P_RequestTitleIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MRequestInformationIdRecord = table.Column<long>(name: "M_RequestInformationIdRecord", type: "bigint", nullable: true),
                    UAPAutomation = table.Column<bool>(name: "UAP_Automation", type: "bit", nullable: true),
                    UAPCreateDate = table.Column<DateTime>(name: "UAP_CreateDate", type: "datetime2", nullable: true),
                    UAPIdentificationCodeinput = table.Column<string>(name: "UAP_IdentificationCode_input", type: "nvarchar(215)", maxLength: 215, nullable: true),
                    UAPReceiverinput = table.Column<string>(name: "UAP_Receiver_input", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UAPSMS = table.Column<bool>(name: "UAP_SMS", type: "bit", nullable: true),
                    UAPSendERP = table.Column<bool>(name: "UAP_SendERP", type: "bit", nullable: true),
                    UAPSendLetterResponse = table.Column<bool>(name: "UAP_SendLetterResponse", type: "bit", nullable: true),
                    UAPSendNotifyERP = table.Column<bool>(name: "UAP_SendNotifyERP", type: "bit", nullable: true),
                    UAPSubjectinput = table.Column<string>(name: "UAP_Subject_input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UAPTextBodyinput = table.Column<string>(name: "UAP_TextBody_input", type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    UAPsenderinput = table.Column<string>(name: "UAP_sender_input", type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_UserActionsProcess", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_M_RequestInformation_M_RequestInformationIdRecord",
                        column: x => x.MRequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_P_PositionOrg_UAP_P_PositionOrgIdRecord",
                        column: x => x.UAPPPositionOrgIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_PositionOrg",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_P_CurrentPEIdRecord",
                        column: x => x.UAPPCurrentPEIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_P_RequestTitleIdRecord",
                        column: x => x.UAPPRequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_UAP_P_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_CurrentPEIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_UAP_P_PositionOrgIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_UAP_P_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_P_RequestTitleIdRecord");
        }
    }
}
