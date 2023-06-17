using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemovePCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_L_UserPosition_PCode",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropIndex(
                name: "IX_L_UserLocation_PCode",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_UserAssignment_PCode",
                schema: "Links",
                table: "L_UserAssignment");

            migrationBuilder.DropIndex(
                name: "IX_L_RolePosition_PCode",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_PCode",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_F_Scenario_PCode",
                schema: "Facts",
                table: "F_Scenario");

            migrationBuilder.DropIndex(
                name: "IX_F_Review_PCode",
                schema: "Facts",
                table: "F_Review");

            migrationBuilder.DropIndex(
                name: "IX_F_Endorsement_PCode",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PCode",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Assignment_PCode",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropIndex(
                name: "IX_D_UserInformation_PCode",
                schema: "Dimentions",
                table: "D_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PCode",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_TagType_PCode",
                schema: "Dimentions",
                table: "D_TagType");

            migrationBuilder.DropIndex(
                name: "IX_D_Tag_PCode",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PCode",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PCode",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_Process_PCode",
                schema: "Dimentions",
                table: "D_Process");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PCode",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PCode",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PCode",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Entity_PCode",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Links",
                table: "L_UserAssignment");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Scenario");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Review");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_UserInformation");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_TagType");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Process");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Entity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Links",
                table: "L_UserAssignment",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Review",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Request",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Endorsement",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Facts",
                table: "F_Assignment",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PCode",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PCode",
                schema: "Facts",
                table: "F_Review",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PCode",
                schema: "Facts",
                table: "F_Assignment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");
        }
    }
}
