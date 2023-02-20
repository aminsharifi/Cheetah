using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removePCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_UserSkill");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_UserRole");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_UserLocation");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_UserInformation");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_UserArea");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_Skill");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_UserActionGroup");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_RolePosition");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_ProcessState");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_Operand");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_FieldType");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Parameters",
                table: "P_EndorsementPosition");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_ListOfParameter");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_Attachment");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_Approve");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_UserSkill",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_UserRole",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_UserLocation",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_UserInformation",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_UserArea",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_User",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_Skill",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_Role",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_Location",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Systems",
                table: "S_Area",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_UserAction",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_RequestType",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_Operand",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_FieldType",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Masters",
                table: "M_Attachment",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Masters",
                table: "M_Approve",
                type: "numeric(18,0)",
                nullable: true);
        }
    }
}
