using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReindexDuplicate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");
        }
    }
}
