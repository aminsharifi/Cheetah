using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MAttachmen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_OrgPosition");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_OrgPosition");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_OrgPosition",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_OrgPosition",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "M_Attachment",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ATCData = table.Column<byte>(name: "ATC_Data", type: "tinyint", nullable: true),
                    ATCName = table.Column<byte>(name: "ATC_Name", type: "tinyint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: false),
                    MApproveIdRecord = table.Column<long>(name: "M_ApproveIdRecord", type: "bigint", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Attachment", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_Attachment_M_Approve_M_ApproveIdRecord",
                        column: x => x.MApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_Approve",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_Attachment_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_Attachment",
                column: "M_ApproveIdRecord");
        }
    }
}
