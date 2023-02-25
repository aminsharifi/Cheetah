using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Reindex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PCode",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PIndex",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PName",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PCode",
                schema: "Facts",
                table: "F_UserRole",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PIndex",
                schema: "Facts",
                table: "F_UserRole",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PName",
                schema: "Facts",
                table: "F_UserRole",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PCode",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PIndex",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PName",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PCode",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PName",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PCode",
                schema: "Facts",
                table: "F_UserArea",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PIndex",
                schema: "Facts",
                table: "F_UserArea",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PName",
                schema: "Facts",
                table: "F_UserArea",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_CreateTimeRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PCode",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PIndex",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PName",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PName",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_CreateTimeRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LastUpdatedRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PCode",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PName",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PName",
                schema: "Facts",
                table: "F_Attachment",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PName",
                schema: "Facts",
                table: "F_Approve",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PName",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PName",
                schema: "Dimentions",
                table: "D_User",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PCode",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PName",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PName",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PName",
                schema: "Dimentions",
                table: "D_Role",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PName",
                schema: "Dimentions",
                table: "D_Position",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PName",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PName",
                schema: "Dimentions",
                table: "D_Location",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PCode",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PName",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "DsblRecord",
                unique: true,
                descending: new bool[0],
                filter: "[DsblRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id",
                unique: true,
                descending: new bool[0],
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PCode",
                schema: "Dimentions",
                table: "D_Area",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PName",
                schema: "Dimentions",
                table: "D_Area",
                column: "PName",
                unique: true,
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PCode",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PIndex",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PName",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_DsblRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PCode",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PIndex",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PName",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_DsblRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PCode",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PIndex",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PName",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PCode",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PName",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_DsblRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PCode",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PIndex",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PName",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_CreateTimeRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_DsblRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PCode",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PIndex",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PName",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PCode",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PName",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_CreateTimeRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_LastUpdatedRecord",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PCode",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PName",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PCode",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PName",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PCode",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PName",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PCode",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PName",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PCode",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PName",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PCode",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PName",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PCode",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PName",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PCode",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PName",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PCode",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PName",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PCode",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PName",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PCode",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PName",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PCode",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PName",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PCode",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PName",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PCode",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PName",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PCode",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PName",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PCode",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PName",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PCode",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PName",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PCode",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PName",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");
        }
    }
}
