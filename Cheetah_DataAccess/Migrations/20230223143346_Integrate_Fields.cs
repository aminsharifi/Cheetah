using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class IntegrateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Area_D_UnitType_Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_F_User_PSE_ExpertUserIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_ApproveIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_NeedApproveIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_User_APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_Operand_PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_F_User_F_UserIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_RequestType_RI_RequestTypeIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_SubRequestTitle_RI_SubRequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_ExpertUserIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_RequestorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RolePosition_D_Position_UP_PositionOrgIdRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RolePosition_D_Role_UP_RoleIdRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserArea_D_Area_UR_AreaIdRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserArea_F_User_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_D_Location_UL_LocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_F_User_UL_RelatedUserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_F_User_UL_UserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserRole_D_Role_UR_RoleIdRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserRole_F_User_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_D_Position_D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_D_Skill_US_SkillIdRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_F_User_US_UserIdRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropTable(
                name: "D_EndorsementPosition",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_RequestType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_User",
                schema: "Facts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F_RequestInformation",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F_AllApprove",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "RI_LastTimeModify",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_NewDate",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OldDate",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "US_UserIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "US_UserId");

            migrationBuilder.RenameColumn(
                name: "US_SkillIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "US_SkillId");

            migrationBuilder.RenameColumn(
                name: "D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_US_UserIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_US_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_US_SkillIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_US_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                newName: "UR_UserId");

            migrationBuilder.RenameColumn(
                name: "UR_RoleIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                newName: "UR_RoleId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_UserRole",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserRole_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                newName: "IX_F_UserRole_UR_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserRole_UR_RoleIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                newName: "IX_F_UserRole_UR_RoleId");

            migrationBuilder.RenameColumn(
                name: "UL_UserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_UserLocationId");

            migrationBuilder.RenameColumn(
                name: "UL_RelatedUserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_RelatedUserLocationId");

            migrationBuilder.RenameColumn(
                name: "UL_LocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_LocationId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_UserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_UserLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_RelatedUserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_RelatedUserLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_LocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_LocationId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_UserInformation",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                newName: "UA_UserId");

            migrationBuilder.RenameColumn(
                name: "UR_AreaIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                newName: "UA_AreaId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_UserArea",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserArea_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                newName: "IX_F_UserArea_UA_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserArea_UR_AreaIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                newName: "IX_F_UserArea_UA_AreaId");

            migrationBuilder.RenameColumn(
                name: "UP_RoleIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "UP_RoleId");

            migrationBuilder.RenameColumn(
                name: "UP_PositionOrgIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "UP_PositionOrgId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_RolePosition_UP_RoleIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "IX_F_RolePosition_UP_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RolePosition_UP_PositionOrgIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "IX_F_RolePosition_UP_PositionOrgId");

            migrationBuilder.RenameColumn(
                name: "RI_SubRequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_RequestorId");

            migrationBuilder.RenameColumn(
                name: "RI_RequestorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_RequestTitleId");

            migrationBuilder.RenameColumn(
                name: "RI_RequestTypeIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_ProcessStateId");

            migrationBuilder.RenameColumn(
                name: "RI_RequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_ExpertUserId");

            migrationBuilder.RenameColumn(
                name: "RI_ProcessStateIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_CreatorId");

            migrationBuilder.RenameColumn(
                name: "RI_ExpertUserIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_AllApproveId");

            migrationBuilder.RenameColumn(
                name: "RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "PIndex");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "PCode");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_SubRequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_RequestorId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_RequestTypeIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_ProcessStateId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_RequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_ExpertUserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_RequestorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_RequestTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_ProcessStateIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_ExpertUserIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_AllApproveId");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "LOP_ParameterTypeIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "PT_OperandId");

            migrationBuilder.RenameColumn(
                name: "LOP_ParameterListIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "LOP_ParameterTypeId");

            migrationBuilder.RenameColumn(
                name: "F_UserIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "LOP_ParameterListId");

            migrationBuilder.RenameColumn(
                name: "F_RequestInformationIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "F_RequestInformationId");

            migrationBuilder.RenameColumn(
                name: "D_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "D_UserId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_Parent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterTypeIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_PT_OperandId");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterListIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_LOP_ParameterTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_F_UserIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_LOP_ParameterListId");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_F_RequestInformationIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_F_RequestInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_D_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_D_UserId");

            migrationBuilder.RenameColumn(
                name: "F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_UserInChargeId");

            migrationBuilder.RenameColumn(
                name: "APV_NeedApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_ProcessEndorsementId");

            migrationBuilder.RenameColumn(
                name: "APV_ApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_NeedApproveId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_Parent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_UserInChargeId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_NeedApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_ProcessEndorsementId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_ApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_NeedApproveId");

            migrationBuilder.RenameColumn(
                name: "AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "PIndex");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "PCode");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "IX_F_AllApprove_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "IX_D_SubRequestTitle_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Skill",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Role",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "PSE_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_SubRequestTitleId");

            migrationBuilder.RenameColumn(
                name: "PSE_ProcessStateIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_RequestTitleId");

            migrationBuilder.RenameColumn(
                name: "PSE_ExpertUserIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_ProcessStateId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_Parent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_SubRequestTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_RequestTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_ExpertUserIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_ProcessStateId");

            migrationBuilder.RenameColumn(
                name: "PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "D_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "PSO_Default_LocationId");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_Parent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_D_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_PSO_Default_LocationId");

            migrationBuilder.RenameColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "IX_D_ParameterType_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "IX_D_ParameterList_Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Location",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area",
                newName: "Parent_Id");

            migrationBuilder.RenameColumn(
                name: "IdRecord",
                schema: "Dimentions",
                table: "D_Area",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_D_Area_Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area",
                newName: "IX_D_Area_Parent_Id");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserSkill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserSkill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "D_PositionId",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserRole",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserArea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserArea",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_RolePosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_RolePosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "APV_ApproveId",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_F_RequestInformation",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F_AllApprove",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UserFullName = table.Column<string>(name: "User_FullName", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUserName = table.Column<string>(name: "User_UserName", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserDomain = table.Column<string>(name: "User_Domain", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserEnabledForAssignation = table.Column<bool>(name: "User_EnabledForAssignation", type: "bit", nullable: true),
                    UserDelegateEnabled = table.Column<bool>(name: "User_DelegateEnabled", type: "bit", nullable: true),
                    UserCreatedCasesSkipAssigRules = table.Column<bool>(name: "User_CreatedCasesSkipAssigRules", type: "bit", nullable: true),
                    UserIDPersonel = table.Column<string>(name: "User_IDPersonel", type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserLDAPDescription = table.Column<string>(name: "User_LDAPDescription", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserBossUserId = table.Column<long>(name: "User_BossUserId", type: "bigint", nullable: true),
                    UserDelegateId = table.Column<long>(name: "User_DelegateId", type: "bigint", nullable: true),
                    UserUserInformationId = table.Column<long>(name: "User_UserInformationId", type: "bigint", nullable: true),
                    UserIdentityUserId = table.Column<string>(name: "User_IdentityUserId", type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_AspNetUsers_User_IdentityUserId",
                        column: x => x.UserIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_F_UserInformation_User_UserInformationId",
                        column: x => x.UserUserInformationId,
                        principalSchema: "Facts",
                        principalTable: "F_UserInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_EndorsementPosition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UPProcessEndorsementId = table.Column<long>(name: "UP_ProcessEndorsementId", type: "bigint", nullable: true),
                    UPPositionOrgId = table.Column<long>(name: "UP_PositionOrgId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_D_Position_UP_PositionOrgId",
                        column: x => x.UPPositionOrgId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_D_ProcessEndorsement_UP_ProcessEndorsementId",
                        column: x => x.UPProcessEndorsementId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_F_EndorsementPosition_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementPosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_ProcessEndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ExpertUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area",
                column: "Area_UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Facts",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_BossUserId",
                schema: "Facts",
                table: "D_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_DelegateId",
                schema: "Facts",
                table: "D_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_IdentityUserId",
                schema: "Facts",
                table: "D_User",
                column: "User_IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_UserInformationId",
                schema: "Facts",
                table: "D_User",
                column: "User_UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_PositionOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_UP_ProcessEndorsementId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_ProcessEndorsementId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Area_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Area",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Area_D_UnitType_Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area",
                column: "Area_UnitTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_UnitType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_FieldType_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_FieldType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Location_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Operand_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterList_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_FieldType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterType_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationId",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_SubRequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_User_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ExpertUserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_RequestTitle_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Role_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Skill_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Skill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_SubRequestTitle_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_SubRequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_UnitType_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_UnitType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ProcessEndorsementId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_D_User_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_UserInChargeId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveId",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Attachment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_Operand_PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PT_OperandId",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterListId",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_ProcessEndorsementId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_User_D_UserId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_UserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_ListOfParameter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_RequestInformationId",
                principalSchema: "Facts",
                principalTable: "F_RequestInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ProcessStateId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_CreatorId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_ExpertUserId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ExpertUserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestorId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveId",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_RequestInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RolePosition_D_Position_UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_PositionOrgId",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RolePosition_D_Role_UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_RoleId",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RolePosition_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_RolePosition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserArea_D_Area_UA_AreaId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_AreaId",
                principalSchema: "Dimentions",
                principalTable: "D_Area",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserArea_D_User_UA_UserId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_UserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserArea_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_UserArea",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserInformation_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_UserInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_D_Location_UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_LocationId",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_D_User_UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_RelatedUserLocationId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_D_User_UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_UserLocationId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_UserLocation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserRole_D_Role_UR_RoleId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_RoleId",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserRole_D_User_UR_UserId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_UserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserRole_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_UserRole",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_D_Position_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionId",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_D_Skill_US_SkillId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_SkillId",
                principalSchema: "Dimentions",
                principalTable: "D_Skill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_D_User_US_UserId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_UserId",
                principalSchema: "Facts",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_UserSkill",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Area_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Area_D_UnitType_Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropForeignKey(
                name: "FK_D_FieldType_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Location_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Operand_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterList_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterType_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_User_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropForeignKey(
                name: "FK_D_RequestTitle_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Role_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Skill_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropForeignKey(
                name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_D_SubRequestTitle_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_D_UnitType_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_D_User_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_Operand_PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_D_User_D_UserId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_ExpertUserId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RolePosition_D_Position_UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RolePosition_D_Role_UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RolePosition_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserArea_D_Area_UA_AreaId",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserArea_D_User_UA_UserId",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserArea_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserInformation_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_D_Location_UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_D_User_UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_D_User_UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserLocation_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserRole_D_Role_UR_RoleId",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserRole_D_User_UR_UserId",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserRole_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_D_Position_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_D_Skill_US_SkillId",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_D_User_US_UserId",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserSkill_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_EndorsementPosition",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F_RequestInformation",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F_AllApprove",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropColumn(
                name: "D_PositionId",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "PDescription",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "PERPCode",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "PName",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropColumn(
                name: "D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropColumn(
                name: "F_ApproveId",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropColumn(
                name: "APV_ApproveId",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "PDescription",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "PERPCode",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "PName",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropColumn(
                name: "D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropColumn(
                name: "PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropColumn(
                name: "PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropColumn(
                name: "Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.RenameColumn(
                name: "US_UserId",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "US_UserIdRecord");

            migrationBuilder.RenameColumn(
                name: "US_SkillId",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "US_SkillIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "D_PositionIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_US_UserId",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_US_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_US_SkillId",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_US_SkillIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                newName: "IX_F_UserSkill_D_PositionIdRecord");

            migrationBuilder.RenameColumn(
                name: "UR_UserId",
                schema: "Facts",
                table: "F_UserRole",
                newName: "UR_UserIdRecord");

            migrationBuilder.RenameColumn(
                name: "UR_RoleId",
                schema: "Facts",
                table: "F_UserRole",
                newName: "UR_RoleIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_UserRole",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserRole_UR_UserId",
                schema: "Facts",
                table: "F_UserRole",
                newName: "IX_F_UserRole_UR_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserRole_UR_RoleId",
                schema: "Facts",
                table: "F_UserRole",
                newName: "IX_F_UserRole_UR_RoleIdRecord");

            migrationBuilder.RenameColumn(
                name: "UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_UserLocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_RelatedUserLocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "UL_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_UserLocationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_RelatedUserLocationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserLocation_UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation",
                newName: "IX_F_UserLocation_UL_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_UserInformation",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "UA_UserId",
                schema: "Facts",
                table: "F_UserArea",
                newName: "UR_UserIdRecord");

            migrationBuilder.RenameColumn(
                name: "UA_AreaId",
                schema: "Facts",
                table: "F_UserArea",
                newName: "UR_AreaIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_UserArea",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserArea_UA_UserId",
                schema: "Facts",
                table: "F_UserArea",
                newName: "IX_F_UserArea_UR_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_UserArea_UA_AreaId",
                schema: "Facts",
                table: "F_UserArea",
                newName: "IX_F_UserArea_UR_AreaIdRecord");

            migrationBuilder.RenameColumn(
                name: "UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "UP_RoleIdRecord");

            migrationBuilder.RenameColumn(
                name: "UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "UP_PositionOrgIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RolePosition_UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "IX_F_RolePosition_UP_RoleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RolePosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition",
                newName: "IX_F_RolePosition_UP_PositionOrgIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_SubRequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_RequestorIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_RequestTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_ExpertUserId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_ProcessStateIdRecord");

            migrationBuilder.RenameColumn(
                name: "RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_ExpertUserIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_CreatorIdRecord");

            migrationBuilder.RenameColumn(
                name: "PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "RI_AllApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_RequestorIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_SubRequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_RequestTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_ExpertUserId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_ProcessStateIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_ExpertUserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                newName: "IX_F_RequestInformation_RI_CreatorIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "PT_OperandIdRecord");

            migrationBuilder.RenameColumn(
                name: "PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "LOP_ParameterTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "LOP_ParameterTypeId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "LOP_ParameterListIdRecord");

            migrationBuilder.RenameColumn(
                name: "LOP_ParameterListId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "F_UserIdRecord");

            migrationBuilder.RenameColumn(
                name: "F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "F_RequestInformationIdRecord");

            migrationBuilder.RenameColumn(
                name: "D_UserId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "D_ProcessEndorsementIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_LOP_ParameterTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_PT_OperandIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterTypeId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_LOP_ParameterListIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterListId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_F_UserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_F_RequestInformationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_ListOfParameter_D_UserId",
                schema: "Facts",
                table: "F_ListOfParameter",
                newName: "IX_F_ListOfParameter_D_ProcessEndorsementIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                newName: "F_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_F_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_UserInChargeIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_ProcessEndorsementIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_ProcessEndorsementId",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_NeedApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                newName: "APV_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Facts",
                table: "F_Approve",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_UserInChargeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_ProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_ProcessEndorsementId",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_NeedApproveIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Approve_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                newName: "IX_F_Approve_APV_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "AAP_Last_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "AAP_Current_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                newName: "IX_F_AllApprove_AAP_Last_ApproveIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_UnitType",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "D_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                newName: "IX_D_SubRequestTitle_D_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Skill",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Role",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_SubRequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_RequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_ProcessStateIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_ExpertUserIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_RequestTitleIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_ProcessStateIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_ExpertUserIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_SubRequestTitleIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                newName: "PSO_Default_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                newName: "D_ProcessEndorsementIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_D_ProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_PSO_Default_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "PT_P_FieldTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                newName: "IX_D_ParameterType_PT_P_FieldTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "PL_ParameterTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                newName: "IX_D_ParameterList_PL_ParameterTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Location",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_FieldType",
                newName: "IdRecord");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                newName: "Area_UnitTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Dimentions",
                table: "D_Area",
                newName: "IdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                newName: "IX_D_Area_Area_UnitTypeIdRecord");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserSkill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserSkill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserRole",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserArea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserArea",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_RolePosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_RolePosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<long>(
                name: "RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "RI_LastTimeModify",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.AddColumn<DateTime>(
                name: "RI_NewDate",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AddColumn<DateTime>(
                name: "RI_OldDate",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "datetime2",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<long>(
                name: "AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 52)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 53)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_F_RequestInformation",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "IdRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F_AllApprove",
                schema: "Facts",
                table: "F_AllApprove",
                column: "IdRecord");

            migrationBuilder.CreateTable(
                name: "D_EndorsementPosition",
                schema: "Dimentions",
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
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true),
                    UPProcessEndorsementIdRecord = table.Column<long>(name: "UP_ProcessEndorsementIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_EndorsementPosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_EndorsementPosition_D_Position_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_EndorsementPosition_D_ProcessEndorsement_UP_ProcessEndorsementIdRecord",
                        column: x => x.UPProcessEndorsementIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_RequestType",
                schema: "Dimentions",
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
                    RTRequestTitlesIdRecord = table.Column<long>(name: "RT_RequestTitlesIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestType", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_RequestType_D_RequestTitle_RT_RequestTitlesIdRecord",
                        column: x => x.RTRequestTitlesIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_User",
                schema: "Facts",
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
                    UserFullName = table.Column<string>(name: "User_FullName", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUserName = table.Column<string>(name: "User_UserName", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserDomain = table.Column<string>(name: "User_Domain", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserEnabledForAssignation = table.Column<bool>(name: "User_EnabledForAssignation", type: "bit", nullable: true),
                    UserDelegateEnabled = table.Column<bool>(name: "User_DelegateEnabled", type: "bit", nullable: true),
                    UserCreatedCasesSkipAssigRules = table.Column<bool>(name: "User_CreatedCasesSkipAssigRules", type: "bit", nullable: true),
                    UserIDPersonel = table.Column<string>(name: "User_IDPersonel", type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserLDAPDescription = table.Column<string>(name: "User_LDAPDescription", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserBossUserId = table.Column<long>(name: "User_BossUserId", type: "bigint", nullable: true),
                    UserDelegateId = table.Column<long>(name: "User_DelegateId", type: "bigint", nullable: true),
                    UserIdentityUserId = table.Column<string>(name: "User_IdentityUserId", type: "nvarchar(450)", nullable: true),
                    UserUserInformationIdRecord = table.Column<long>(name: "User_UserInformationIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_User", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_User_AspNetUsers_User_IdentityUserId",
                        column: x => x.UserIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_User_F_UserInformation_User_UserInformationIdRecord",
                        column: x => x.UserUserInformationIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_UserInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_User_F_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_User_F_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPosition_UP_PositionOrgIdRecord",
                schema: "Dimentions",
                table: "D_EndorsementPosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPosition_UP_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_EndorsementPosition",
                column: "UP_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestType_RT_RequestTitlesIdRecord",
                schema: "Dimentions",
                table: "D_RequestType",
                column: "RT_RequestTitlesIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_BossUserId",
                schema: "Facts",
                table: "F_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_DelegateId",
                schema: "Facts",
                table: "F_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_IdentityUserId",
                schema: "Facts",
                table: "F_User",
                column: "User_IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_UserInformationIdRecord",
                schema: "Facts",
                table: "F_User",
                column: "User_UserInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Area_D_UnitType_Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "Area_UnitTypeIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_UnitType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "D_ProcessEndorsementIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_RequestTitleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_SubRequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_F_User_PSE_ExpertUserIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ExpertUserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ProcessEndorsementIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_ApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_AllApprove_APV_NeedApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Approve_F_User_APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_UserInChargeIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_Operand_PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PT_OperandIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterListIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterList",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterTypeIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_ProcessEndorsementIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_RequestInformationIdRecord",
                principalSchema: "Facts",
                principalTable: "F_RequestInformation",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_ListOfParameter_F_User_F_UserIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_UserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ProcessStateIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_RequestType_RI_RequestTypeIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTypeIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_RequestType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_SubRequestTitle_RI_SubRequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_SubRequestTitleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_SubRequestTitle",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_AllApprove",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_CreatorIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_ExpertUserIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ExpertUserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_F_User_RI_RequestorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestorIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RolePosition_D_Position_UP_PositionOrgIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_PositionOrgIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RolePosition_D_Role_UP_RoleIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_RoleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserArea_D_Area_UR_AreaIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "UR_AreaIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserArea_F_User_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "UR_UserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_D_Location_UL_LocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_LocationIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_F_User_UL_RelatedUserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_RelatedUserLocationIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserLocation_F_User_UL_UserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_UserLocationIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserRole_D_Role_UR_RoleIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_RoleIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserRole_F_User_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_UserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_D_Position_D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_D_Skill_US_SkillIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_SkillIdRecord",
                principalSchema: "Dimentions",
                principalTable: "D_Skill",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserSkill_F_User_US_UserIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_UserIdRecord",
                principalSchema: "Facts",
                principalTable: "F_User",
                principalColumn: "IdRecord");
        }
    }
}
