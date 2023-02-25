using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReindexAllowDuplicate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PERPCode",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PERPCode",
                schema: "Facts",
                table: "F_UserRole",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PERPCode",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PERPCode",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PERPCode",
                schema: "Facts",
                table: "F_UserArea",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PERPCode",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PERPCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PERPCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PERPCode",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PERPCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PERPCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PERPCode",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PERPCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PERPCode",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PERPCode",
                schema: "Dimentions",
                table: "D_Area",
                column: "PERPCode",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_F_UserSkill_PERPCode",
                schema: "Facts",
                table: "F_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_F_UserRole_PERPCode",
                schema: "Facts",
                table: "F_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_F_UserLocation_PERPCode",
                schema: "Facts",
                table: "F_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PERPCode",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_UserArea_PERPCode",
                schema: "Facts",
                table: "F_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_F_RolePosition_PERPCode",
                schema: "Facts",
                table: "F_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PERPCode",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PERPCode",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PERPCode",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PERPCode",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PERPCode",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PERPCode",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PERPCode",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PERPCode",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PERPCode",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PERPCode",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PERPCode",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PERPCode",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PERPCode",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PERPCode",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PERPCode",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");
        }
    }
}
