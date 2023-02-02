using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DBchanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_M_RequestInformation_APV_idRequestInformation",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_idUserAction",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_S_User_APV_idUserInCharge",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_CallWebService_P_ParameterList_CWS_idParameterList",
                table: "M_CallWebService");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveidProcessEndorsement",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ProcessState_RI_idProcessState",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_RequestTitle_RI_idRequestTitle",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_RequestType_RI_idRequestType",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_SubRequestTitle_RI_idSubRequestTitle",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_idLastUserAction",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_idUserAction",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_Area_RI_idArea",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_idLocation",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idCreator",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idExpertUser",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idLastUserInCharge",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idRequestor",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_idRequestInformation",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_idCurrentPE",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_idRequestTitle",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrganization_PSE_idPON",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_idProcessState",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_idRequestTitle",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_S_User_PSE_idExpertUser",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_idRequestTitles",
                table: "P_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_P_UserAction_P_UserActionGroup_UA_idUserActionGroup",
                table: "P_UserAction");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_OrgPosition_User_idDefaultPosition",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Area_User_idArea",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Location_User_idLocation",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_idBossUser",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_idDelegate",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_idFirstApprover",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_idFirstRoleUser",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_idSecondApprover",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "P_PositionOrganization");

            migrationBuilder.DropIndex(
                name: "IX_M_CallWebService_CWS_idParameterList",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "CWS_idParameterList",
                table: "M_CallWebService");

            migrationBuilder.EnsureSchema(
                name: "Masters");

            migrationBuilder.EnsureSchema(
                name: "Systems");

            migrationBuilder.EnsureSchema(
                name: "Parameters");

            migrationBuilder.RenameTable(
                name: "S_User",
                newName: "S_User",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "S_Location",
                newName: "S_Location",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "S_Area",
                newName: "S_Area",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Role",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "P_UserActionGroup",
                newName: "P_UserActionGroup",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_UserAction",
                newName: "P_UserAction",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_SubRequestTitle",
                newName: "P_SubRequestTitle",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_RequestType",
                newName: "P_RequestType",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_RequestTitle",
                newName: "P_RequestTitle",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_ProcessState",
                newName: "P_ProcessState",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_ProcessEndorsement",
                newName: "P_ProcessEndorsement",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_ParameterType",
                newName: "P_ParameterType",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "P_ParameterList",
                newName: "P_ParameterList",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "OrgPosition",
                newName: "OrgPosition",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "M_UserActionsProcess",
                newName: "M_UserActionsProcess",
                newSchema: "Masters");

            migrationBuilder.RenameTable(
                name: "M_RequestInformation",
                newName: "M_RequestInformation",
                newSchema: "Masters");

            migrationBuilder.RenameTable(
                name: "M_CallWebService",
                newName: "M_CallWebService",
                newSchema: "Masters");

            migrationBuilder.RenameTable(
                name: "M_Approve",
                newName: "M_Approve",
                newSchema: "Masters");

            migrationBuilder.RenameColumn(
                name: "User_idSecondApprover",
                schema: "Systems",
                table: "S_User",
                newName: "User_SecondApproverId");

            migrationBuilder.RenameColumn(
                name: "User_idLocation",
                schema: "Systems",
                table: "S_User",
                newName: "User_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_idFirstRoleUser",
                schema: "Systems",
                table: "S_User",
                newName: "User_FirstRoleUserId");

            migrationBuilder.RenameColumn(
                name: "User_idFirstApprover",
                schema: "Systems",
                table: "S_User",
                newName: "User_FirstApproverId");

            migrationBuilder.RenameColumn(
                name: "User_idDelegate",
                schema: "Systems",
                table: "S_User",
                newName: "User_DelegateId");

            migrationBuilder.RenameColumn(
                name: "User_idDefaultPosition",
                schema: "Systems",
                table: "S_User",
                newName: "User_DefaultPositionIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_idBossUser",
                schema: "Systems",
                table: "S_User",
                newName: "User_BossUserId");

            migrationBuilder.RenameColumn(
                name: "User_idArea",
                schema: "Systems",
                table: "S_User",
                newName: "User_AreaIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idSecondApprover",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_SecondApproverId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idLocation",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_LocationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idFirstRoleUser",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_FirstRoleUserId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idFirstApprover",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_FirstApproverId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idDelegate",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_DelegateId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idDefaultPosition",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_DefaultPositionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idBossUser",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_BossUserId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_idArea",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_AreaIdRecord");

            migrationBuilder.RenameColumn(
                name: "UA_idUserActionGroup",
                schema: "Parameters",
                table: "P_UserAction",
                newName: "UA_UserActionGroupIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_UserAction_UA_idUserActionGroup",
                schema: "Parameters",
                table: "P_UserAction",
                newName: "IX_P_UserAction_UA_UserActionGroupIdRecord");

            migrationBuilder.RenameColumn(
                name: "SBT_idRequestTitles",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                newName: "SBT_RequestTitlesIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_SubRequestTitle_SBT_idRequestTitles",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                newName: "IX_P_SubRequestTitle_SBT_RequestTitlesIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_idRequestTitle",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_idProcessState",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_ProcessStateIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_idPON",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_PONIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_idExpertUser",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_ExpertUserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_idRequestTitle",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_idProcessState",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_ProcessStateIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_idPON",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_PONIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_idExpertUser",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_ExpertUserIdRecord");

            migrationBuilder.RenameColumn(
                name: "idRequestInformation",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "UAP_idRequestTitle",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_RequestInformationIdRecord");

            migrationBuilder.RenameColumn(
                name: "UAP_idCurrentPE",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "UAP_CurrentPEIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_idRequestTitle",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_idCurrentPE",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_CurrentPEIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_idRequestInformation",
                schema: "Masters",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idUserAction",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_UserActionIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idSubRequestTitle",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_SubRequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idRequestor",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_RequestorIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idRequestType",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_RequestTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idRequestTitle",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idProcessState",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_ProcessStateIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idLocation",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idLastUserInCharge",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_LastUserInChargeIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idLastUserAction",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_LastUserActionIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idExpertUser",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_ExpertUserIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idCreator",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_CreatorIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_idArea",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_AreaIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_ActiveidProcessEndorsement",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_ActiveProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idUserAction",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_UserActionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idSubRequestTitle",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_SubRequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idRequestType",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_RequestTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idRequestTitle",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idRequestor",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_RequestorIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idProcessState",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_ProcessStateIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idLocation",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_LocationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idLastUserInCharge",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_LastUserInChargeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idLastUserAction",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_LastUserActionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idExpertUser",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_ExpertUserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idCreator",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_CreatorIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_idArea",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_AreaIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_ActiveidProcessEndorsement",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_ActiveProcessEndorsementIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_idUserInCharge",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_UserInChargeIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_idUserAction",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_UserActionIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_idRequestInformation",
                schema: "Masters",
                table: "M_Approve",
                newName: "APV_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_idUserInCharge",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_UserInChargeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_idUserAction",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_UserActionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_idRequestInformation",
                schema: "Masters",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_RequestInformationIdRecord");

            migrationBuilder.AlterColumn<string>(
                name: "RI_Inputuser1",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<long>(
                name: "CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_CurrentPE",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPEProcessEndorsementsIdRecord = table.Column<long>(name: "CPE_ProcessEndorsementsIdRecord", type: "bigint", nullable: true),
                    CPERequestInformationIdRecord = table.Column<long>(name: "CPE_RequestInformationIdRecord", type: "bigint", nullable: true),
                    CPEUserActionIdRecord = table.Column<long>(name: "CPE_UserActionIdRecord", type: "bigint", nullable: true),
                    CPEUserActionsProcessIdRecord = table.Column<long>(name: "CPE_UserActionsProcessIdRecord", type: "bigint", nullable: true),
                    CPEUserIdRecord = table.Column<long>(name: "CPE_UserIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CurrentPE", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_M_RequestInformation_CPE_RequestInformationIdRecord",
                        column: x => x.CPERequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CurrentPE_M_UserActionsProcess_CPE_UserActionsProcessIdRecord",
                        column: x => x.CPEUserActionsProcessIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_UserActionsProcess",
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

            migrationBuilder.CreateTable(
                name: "P_PositionOrg",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSOUser = table.Column<string>(name: "PSO_User", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOGroup = table.Column<bool>(name: "PSO_Group", type: "bit", nullable: true),
                    PSOFMCGRole = table.Column<string>(name: "PSO_FMCGRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOMedicineRole = table.Column<string>(name: "PSO_MedicineRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSORoleIdRecord = table.Column<long>(name: "PSO_RoleIdRecord", type: "bigint", nullable: true),
                    PSORole2IdRecord = table.Column<long>(name: "PSO_Role2IdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_PositionOrg", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_PositionOrg_Role_PSO_Role2IdRecord",
                        column: x => x.PSORole2IdRecord,
                        principalSchema: "Systems",
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_PositionOrg_Role_PSO_RoleIdRecord",
                        column: x => x.PSORoleIdRecord,
                        principalSchema: "Systems",
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "CWS_ParameterListIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_ProcessEndorsementsIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_ProcessEndorsementsIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserActionIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserActionIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserActionsProcessIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserActionsProcessIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_CPE_UserIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "CPE_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Role2IdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_RoleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_M_RequestInformation_APV_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_UserActionIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_S_User_APV_UserInChargeIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_UserInChargeIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CallWebService_P_ParameterList_CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "CWS_ParameterListIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ActiveProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ProcessState_RI_ProcessStateIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ProcessStateIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_RequestTitle_RI_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_RequestType_RI_RequestTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_SubRequestTitle_RI_SubRequestTitleIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_SubRequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_SubRequestTitle",
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
                name: "FK_M_RequestInformation_S_Area_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AreaIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_CreatorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CreatorIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_ExpertUserIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ExpertUserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LastUserInChargeIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_RequestorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestorIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                column: "UAP_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

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

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrg_PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_PONIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_ProcessStateIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_ProcessStateIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_S_User_PSE_ExpertUserIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_ExpertUserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "SBT_RequestTitlesIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_UserAction_P_UserActionGroup_UA_UserActionGroupIdRecord",
                schema: "Parameters",
                table: "P_UserAction",
                column: "UA_UserActionGroupIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserActionGroup",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_DefaultPositionIdRecord",
                principalSchema: "Systems",
                principalTable: "OrgPosition",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Area_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_AreaIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Location_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_BossUserId",
                schema: "Systems",
                table: "S_User",
                column: "User_BossUserId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_DelegateId",
                schema: "Systems",
                table: "S_User",
                column: "User_DelegateId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User",
                column: "User_FirstApproverId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User",
                column: "User_FirstRoleUserId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_SecondApproverId",
                schema: "Systems",
                table: "S_User",
                column: "User_SecondApproverId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_M_RequestInformation_APV_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_UserActionIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_S_User_APV_UserInChargeIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_CallWebService_P_ParameterList_CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_ProcessState_RI_ProcessStateIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_RequestTitle_RI_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_RequestType_RI_RequestTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_SubRequestTitle_RI_SubRequestTitleIdRecord",
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
                name: "FK_M_RequestInformation_S_Area_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_CreatorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_ExpertUserIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_LastUserInChargeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_RequestorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_UAP_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_CurrentPEIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrg_PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_ProcessStateIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_S_User_PSE_ExpertUserIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_P_UserAction_P_UserActionGroup_UA_UserActionGroupIdRecord",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Area_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Location_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_BossUserId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_DelegateId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_SecondApproverId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "M_CurrentPE",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "P_PositionOrg",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_M_CallWebService_CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.RenameTable(
                name: "S_User",
                schema: "Systems",
                newName: "S_User");

            migrationBuilder.RenameTable(
                name: "S_Location",
                schema: "Systems",
                newName: "S_Location");

            migrationBuilder.RenameTable(
                name: "S_Area",
                schema: "Systems",
                newName: "S_Area");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Systems",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "P_UserActionGroup",
                schema: "Parameters",
                newName: "P_UserActionGroup");

            migrationBuilder.RenameTable(
                name: "P_UserAction",
                schema: "Parameters",
                newName: "P_UserAction");

            migrationBuilder.RenameTable(
                name: "P_SubRequestTitle",
                schema: "Parameters",
                newName: "P_SubRequestTitle");

            migrationBuilder.RenameTable(
                name: "P_RequestType",
                schema: "Parameters",
                newName: "P_RequestType");

            migrationBuilder.RenameTable(
                name: "P_RequestTitle",
                schema: "Parameters",
                newName: "P_RequestTitle");

            migrationBuilder.RenameTable(
                name: "P_ProcessState",
                schema: "Parameters",
                newName: "P_ProcessState");

            migrationBuilder.RenameTable(
                name: "P_ProcessEndorsement",
                schema: "Parameters",
                newName: "P_ProcessEndorsement");

            migrationBuilder.RenameTable(
                name: "P_ParameterType",
                schema: "Parameters",
                newName: "P_ParameterType");

            migrationBuilder.RenameTable(
                name: "P_ParameterList",
                schema: "Parameters",
                newName: "P_ParameterList");

            migrationBuilder.RenameTable(
                name: "OrgPosition",
                schema: "Systems",
                newName: "OrgPosition");

            migrationBuilder.RenameTable(
                name: "M_UserActionsProcess",
                schema: "Masters",
                newName: "M_UserActionsProcess");

            migrationBuilder.RenameTable(
                name: "M_RequestInformation",
                schema: "Masters",
                newName: "M_RequestInformation");

            migrationBuilder.RenameTable(
                name: "M_CallWebService",
                schema: "Masters",
                newName: "M_CallWebService");

            migrationBuilder.RenameTable(
                name: "M_Approve",
                schema: "Masters",
                newName: "M_Approve");

            migrationBuilder.RenameColumn(
                name: "User_SecondApproverId",
                table: "S_User",
                newName: "User_idSecondApprover");

            migrationBuilder.RenameColumn(
                name: "User_LocationIdRecord",
                table: "S_User",
                newName: "User_idLocation");

            migrationBuilder.RenameColumn(
                name: "User_FirstRoleUserId",
                table: "S_User",
                newName: "User_idFirstRoleUser");

            migrationBuilder.RenameColumn(
                name: "User_FirstApproverId",
                table: "S_User",
                newName: "User_idFirstApprover");

            migrationBuilder.RenameColumn(
                name: "User_DelegateId",
                table: "S_User",
                newName: "User_idDelegate");

            migrationBuilder.RenameColumn(
                name: "User_DefaultPositionIdRecord",
                table: "S_User",
                newName: "User_idDefaultPosition");

            migrationBuilder.RenameColumn(
                name: "User_BossUserId",
                table: "S_User",
                newName: "User_idBossUser");

            migrationBuilder.RenameColumn(
                name: "User_AreaIdRecord",
                table: "S_User",
                newName: "User_idArea");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_SecondApproverId",
                table: "S_User",
                newName: "IX_S_User_User_idSecondApprover");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_LocationIdRecord",
                table: "S_User",
                newName: "IX_S_User_User_idLocation");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_FirstRoleUserId",
                table: "S_User",
                newName: "IX_S_User_User_idFirstRoleUser");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_FirstApproverId",
                table: "S_User",
                newName: "IX_S_User_User_idFirstApprover");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_DelegateId",
                table: "S_User",
                newName: "IX_S_User_User_idDelegate");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_DefaultPositionIdRecord",
                table: "S_User",
                newName: "IX_S_User_User_idDefaultPosition");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_BossUserId",
                table: "S_User",
                newName: "IX_S_User_User_idBossUser");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_AreaIdRecord",
                table: "S_User",
                newName: "IX_S_User_User_idArea");

            migrationBuilder.RenameColumn(
                name: "UA_UserActionGroupIdRecord",
                table: "P_UserAction",
                newName: "UA_idUserActionGroup");

            migrationBuilder.RenameIndex(
                name: "IX_P_UserAction_UA_UserActionGroupIdRecord",
                table: "P_UserAction",
                newName: "IX_P_UserAction_UA_idUserActionGroup");

            migrationBuilder.RenameColumn(
                name: "SBT_RequestTitlesIdRecord",
                table: "P_SubRequestTitle",
                newName: "SBT_idRequestTitles");

            migrationBuilder.RenameIndex(
                name: "IX_P_SubRequestTitle_SBT_RequestTitlesIdRecord",
                table: "P_SubRequestTitle",
                newName: "IX_P_SubRequestTitle_SBT_idRequestTitles");

            migrationBuilder.RenameColumn(
                name: "PSE_RequestTitleIdRecord",
                table: "P_ProcessEndorsement",
                newName: "PSE_idRequestTitle");

            migrationBuilder.RenameColumn(
                name: "PSE_ProcessStateIdRecord",
                table: "P_ProcessEndorsement",
                newName: "PSE_idProcessState");

            migrationBuilder.RenameColumn(
                name: "PSE_PONIdRecord",
                table: "P_ProcessEndorsement",
                newName: "PSE_idPON");

            migrationBuilder.RenameColumn(
                name: "PSE_ExpertUserIdRecord",
                table: "P_ProcessEndorsement",
                newName: "PSE_idExpertUser");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_RequestTitleIdRecord",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_idRequestTitle");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_ProcessStateIdRecord",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_idProcessState");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_PONIdRecord",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_idPON");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_ExpertUserIdRecord",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_idExpertUser");

            migrationBuilder.RenameColumn(
                name: "UAP_RequestTitleIdRecord",
                table: "M_UserActionsProcess",
                newName: "idRequestInformation");

            migrationBuilder.RenameColumn(
                name: "UAP_RequestInformationIdRecord",
                table: "M_UserActionsProcess",
                newName: "UAP_idRequestTitle");

            migrationBuilder.RenameColumn(
                name: "UAP_CurrentPEIdRecord",
                table: "M_UserActionsProcess",
                newName: "UAP_idCurrentPE");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_RequestTitleIdRecord",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_idRequestInformation");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_RequestInformationIdRecord",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_idRequestTitle");

            migrationBuilder.RenameIndex(
                name: "IX_M_UserActionsProcess_UAP_CurrentPEIdRecord",
                table: "M_UserActionsProcess",
                newName: "IX_M_UserActionsProcess_UAP_idCurrentPE");

            migrationBuilder.RenameColumn(
                name: "RI_UserActionIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idUserAction");

            migrationBuilder.RenameColumn(
                name: "RI_SubRequestTitleIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idSubRequestTitle");

            migrationBuilder.RenameColumn(
                name: "RI_RequestorIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idRequestor");

            migrationBuilder.RenameColumn(
                name: "RI_RequestTypeIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idRequestType");

            migrationBuilder.RenameColumn(
                name: "RI_RequestTitleIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idRequestTitle");

            migrationBuilder.RenameColumn(
                name: "RI_ProcessStateIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idProcessState");

            migrationBuilder.RenameColumn(
                name: "RI_LocationIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idLocation");

            migrationBuilder.RenameColumn(
                name: "RI_LastUserInChargeIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idLastUserInCharge");

            migrationBuilder.RenameColumn(
                name: "RI_LastUserActionIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idLastUserAction");

            migrationBuilder.RenameColumn(
                name: "RI_ExpertUserIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idExpertUser");

            migrationBuilder.RenameColumn(
                name: "RI_CreatorIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idCreator");

            migrationBuilder.RenameColumn(
                name: "RI_AreaIdRecord",
                table: "M_RequestInformation",
                newName: "RI_idArea");

            migrationBuilder.RenameColumn(
                name: "RI_ActiveProcessEndorsementIdRecord",
                table: "M_RequestInformation",
                newName: "RI_ActiveidProcessEndorsement");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_UserActionIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idUserAction");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_SubRequestTitleIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idSubRequestTitle");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_RequestTypeIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idRequestType");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_RequestTitleIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idRequestTitle");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_RequestorIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idRequestor");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_ProcessStateIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idProcessState");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_LocationIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idLocation");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_LastUserInChargeIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idLastUserInCharge");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_LastUserActionIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idLastUserAction");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_ExpertUserIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idExpertUser");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_CreatorIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idCreator");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_AreaIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_idArea");

            migrationBuilder.RenameIndex(
                name: "IX_M_RequestInformation_RI_ActiveProcessEndorsementIdRecord",
                table: "M_RequestInformation",
                newName: "IX_M_RequestInformation_RI_ActiveidProcessEndorsement");

            migrationBuilder.RenameColumn(
                name: "APV_UserInChargeIdRecord",
                table: "M_Approve",
                newName: "APV_idUserInCharge");

            migrationBuilder.RenameColumn(
                name: "APV_UserActionIdRecord",
                table: "M_Approve",
                newName: "APV_idUserAction");

            migrationBuilder.RenameColumn(
                name: "APV_RequestInformationIdRecord",
                table: "M_Approve",
                newName: "APV_idRequestInformation");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_UserInChargeIdRecord",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_idUserInCharge");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_UserActionIdRecord",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_idUserAction");

            migrationBuilder.RenameIndex(
                name: "IX_M_Approve_APV_RequestInformationIdRecord",
                table: "M_Approve",
                newName: "IX_M_Approve_APV_idRequestInformation");

            migrationBuilder.AlterColumn<string>(
                name: "RI_Inputuser1",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CWS_idParameterList",
                table: "M_CallWebService",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "P_PositionOrganization",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSOidRole = table.Column<long>(name: "PSO_idRole", type: "bigint", nullable: true),
                    PSOidRole2 = table.Column<long>(name: "PSO_idRole2", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PSOFMCGRole = table.Column<string>(name: "PSO_FMCGRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOGroup = table.Column<bool>(name: "PSO_Group", type: "bit", nullable: true),
                    PSOMedicineRole = table.Column<string>(name: "PSO_MedicineRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOUser = table.Column<string>(name: "PSO_User", type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_PositionOrganization", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_PositionOrganization_Role_PSO_idRole",
                        column: x => x.PSOidRole,
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_PositionOrganization_Role_PSO_idRole2",
                        column: x => x.PSOidRole2,
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_CWS_idParameterList",
                table: "M_CallWebService",
                column: "CWS_idParameterList");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrganization_PSO_idRole",
                table: "P_PositionOrganization",
                column: "PSO_idRole");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrganization_PSO_idRole2",
                table: "P_PositionOrganization",
                column: "PSO_idRole2");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_M_RequestInformation_APV_idRequestInformation",
                table: "M_Approve",
                column: "APV_idRequestInformation",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_P_UserAction_APV_idUserAction",
                table: "M_Approve",
                column: "APV_idUserAction",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_S_User_APV_idUserInCharge",
                table: "M_Approve",
                column: "APV_idUserInCharge",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CallWebService_P_ParameterList_CWS_idParameterList",
                table: "M_CallWebService",
                column: "CWS_idParameterList",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveidProcessEndorsement",
                table: "M_RequestInformation",
                column: "RI_ActiveidProcessEndorsement",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_ProcessState_RI_idProcessState",
                table: "M_RequestInformation",
                column: "RI_idProcessState",
                principalTable: "P_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_RequestTitle_RI_idRequestTitle",
                table: "M_RequestInformation",
                column: "RI_idRequestTitle",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_RequestType_RI_idRequestType",
                table: "M_RequestInformation",
                column: "RI_idRequestType",
                principalTable: "P_RequestType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_SubRequestTitle_RI_idSubRequestTitle",
                table: "M_RequestInformation",
                column: "RI_idSubRequestTitle",
                principalTable: "P_SubRequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_idLastUserAction",
                table: "M_RequestInformation",
                column: "RI_idLastUserAction",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserAction_RI_idUserAction",
                table: "M_RequestInformation",
                column: "RI_idUserAction",
                principalTable: "P_UserAction",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_Area_RI_idArea",
                table: "M_RequestInformation",
                column: "RI_idArea",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_idLocation",
                table: "M_RequestInformation",
                column: "RI_idLocation",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idCreator",
                table: "M_RequestInformation",
                column: "RI_idCreator",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idExpertUser",
                table: "M_RequestInformation",
                column: "RI_idExpertUser",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idLastUserInCharge",
                table: "M_RequestInformation",
                column: "RI_idLastUserInCharge",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_idRequestor",
                table: "M_RequestInformation",
                column: "RI_idRequestor",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_M_RequestInformation_idRequestInformation",
                table: "M_UserActionsProcess",
                column: "idRequestInformation",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_idCurrentPE",
                table: "M_UserActionsProcess",
                column: "UAP_idCurrentPE",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_idRequestTitle",
                table: "M_UserActionsProcess",
                column: "UAP_idRequestTitle",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrganization_PSE_idPON",
                table: "P_ProcessEndorsement",
                column: "PSE_idPON",
                principalTable: "P_PositionOrganization",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_idProcessState",
                table: "P_ProcessEndorsement",
                column: "PSE_idProcessState",
                principalTable: "P_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_idRequestTitle",
                table: "P_ProcessEndorsement",
                column: "PSE_idRequestTitle",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_S_User_PSE_idExpertUser",
                table: "P_ProcessEndorsement",
                column: "PSE_idExpertUser",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_idRequestTitles",
                table: "P_SubRequestTitle",
                column: "SBT_idRequestTitles",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_UserAction_P_UserActionGroup_UA_idUserActionGroup",
                table: "P_UserAction",
                column: "UA_idUserActionGroup",
                principalTable: "P_UserActionGroup",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_OrgPosition_User_idDefaultPosition",
                table: "S_User",
                column: "User_idDefaultPosition",
                principalTable: "OrgPosition",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Area_User_idArea",
                table: "S_User",
                column: "User_idArea",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Location_User_idLocation",
                table: "S_User",
                column: "User_idLocation",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_idBossUser",
                table: "S_User",
                column: "User_idBossUser",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_idDelegate",
                table: "S_User",
                column: "User_idDelegate",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_idFirstApprover",
                table: "S_User",
                column: "User_idFirstApprover",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_idFirstRoleUser",
                table: "S_User",
                column: "User_idFirstRoleUser",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_idSecondApprover",
                table: "S_User",
                column: "User_idSecondApprover",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
