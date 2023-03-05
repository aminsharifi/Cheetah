using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addlink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F_RolePosition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserArea",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserLocation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserRole",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserSkill",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.EnsureSchema(
                name: "Links");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "L_RolePosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Role_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_L_RolePosition_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_RolePosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserArea",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserArea_D_Area_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserArea_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserArea_L_UserArea_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_UserArea",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_L_UserLocation_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_UserLocation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserRelatedLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserRelatedLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserRelatedLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRelatedLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRelatedLocation_L_UserRelatedLocation_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_UserRelatedLocation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserRole",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserRole_D_Role_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRole_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRole_L_UserRole_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_UserRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserSkill",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false),
                    DPositionId = table.Column<long>(name: "D_PositionId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_Position_D_PositionId",
                        column: x => x.DPositionId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_Skill_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_L_UserSkill_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Links",
                        principalTable: "L_UserSkill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_CreateTimeRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_DsblRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FirstId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_LastUpdatedRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_Parent_Id",
                schema: "Links",
                table: "L_RolePosition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PIndex",
                schema: "Links",
                table: "L_RolePosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PName",
                schema: "Links",
                table: "L_RolePosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_SecondId",
                schema: "Links",
                table: "L_RolePosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_CreateTimeRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_DsblRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_FirstId",
                schema: "Links",
                table: "L_UserArea",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_Parent_Id",
                schema: "Links",
                table: "L_UserArea",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PCode",
                schema: "Links",
                table: "L_UserArea",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PERPCode",
                schema: "Links",
                table: "L_UserArea",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PIndex",
                schema: "Links",
                table: "L_UserArea",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PName",
                schema: "Links",
                table: "L_UserArea",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_SecondId",
                schema: "Links",
                table: "L_UserArea",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_CreateTimeRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_DsblRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FirstId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Parent_Id",
                schema: "Links",
                table: "L_UserLocation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PIndex",
                schema: "Links",
                table: "L_UserLocation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PName",
                schema: "Links",
                table: "L_UserLocation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_SecondId",
                schema: "Links",
                table: "L_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_CreateTimeRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_DsblRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_FirstId",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PCode",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PERPCode",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PIndex",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PName",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_SecondId",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_CreateTimeRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_DsblRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_FirstId",
                schema: "Links",
                table: "L_UserRole",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_Parent_Id",
                schema: "Links",
                table: "L_UserRole",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PCode",
                schema: "Links",
                table: "L_UserRole",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PERPCode",
                schema: "Links",
                table: "L_UserRole",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PIndex",
                schema: "Links",
                table: "L_UserRole",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PName",
                schema: "Links",
                table: "L_UserRole",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_SecondId",
                schema: "Links",
                table: "L_UserRole",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_CreateTimeRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_D_PositionId",
                schema: "Links",
                table: "L_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_DsblRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_FirstId",
                schema: "Links",
                table: "L_UserSkill",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_Parent_Id",
                schema: "Links",
                table: "L_UserSkill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PERPCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PIndex",
                schema: "Links",
                table: "L_UserSkill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PName",
                schema: "Links",
                table: "L_UserSkill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_SecondId",
                schema: "Links",
                table: "L_UserSkill",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_RolePosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserArea",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserRelatedLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserRole",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserSkill",
                schema: "Links");

            migrationBuilder.DropIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter");

            migrationBuilder.DropIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType");

            migrationBuilder.DropIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType");

            migrationBuilder.DropIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Dimentions",
                table: "D_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "F_RolePosition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UPPositionOrgId = table.Column<long>(name: "UP_PositionOrgId", type: "bigint", nullable: true),
                    UPRoleId = table.Column<long>(name: "UP_RoleId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Position_UP_PositionOrgId",
                        column: x => x.UPPositionOrgId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Role_UP_RoleId",
                        column: x => x.UPRoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RolePosition_F_RolePosition_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_RolePosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserArea",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UAAreaId = table.Column<long>(name: "UA_AreaId", type: "bigint", nullable: true),
                    UAUserId = table.Column<long>(name: "UA_UserId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserArea_D_Area_UA_AreaId",
                        column: x => x.UAAreaId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserArea_D_User_UA_UserId",
                        column: x => x.UAUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserArea_F_UserArea_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserArea",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserLocation",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    ULLocationId = table.Column<long>(name: "UL_LocationId", type: "bigint", nullable: true),
                    ULRelatedUserLocationId = table.Column<long>(name: "UL_RelatedUserLocationId", type: "bigint", nullable: true),
                    ULUserLocationId = table.Column<long>(name: "UL_UserLocationId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_Location_UL_LocationId",
                        column: x => x.ULLocationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_User_UL_RelatedUserLocationId",
                        column: x => x.ULRelatedUserLocationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_User_UL_UserLocationId",
                        column: x => x.ULUserLocationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_F_UserLocation_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserLocation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserRole",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    URRoleId = table.Column<long>(name: "UR_RoleId", type: "bigint", nullable: true),
                    URUserId = table.Column<long>(name: "UR_UserId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserRole_D_Role_UR_RoleId",
                        column: x => x.URRoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserRole_D_User_UR_UserId",
                        column: x => x.URUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserRole_F_UserRole_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserSkill",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    USSkillId = table.Column<long>(name: "US_SkillId", type: "bigint", nullable: true),
                    USUserId = table.Column<long>(name: "US_UserId", type: "bigint", nullable: true),
                    DPositionId = table.Column<long>(name: "D_PositionId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Position_D_PositionId",
                        column: x => x.DPositionId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Skill_US_SkillId",
                        column: x => x.USSkillId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_User_US_UserId",
                        column: x => x.USUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_F_UserSkill_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserSkill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

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
                descending: new bool[0]);

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
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PCode",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PERPCode",
                schema: "Facts",
                table: "F_RolePosition",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_RolePosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_PositionOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_RoleId");

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
                descending: new bool[0]);

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
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PCode",
                schema: "Facts",
                table: "F_UserArea",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PERPCode",
                schema: "Facts",
                table: "F_UserArea",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_UserArea_UA_AreaId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_UA_UserId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_UserId");

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
                descending: new bool[0]);

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
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PCode",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PERPCode",
                schema: "Facts",
                table: "F_UserLocation",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_UserLocation_UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_RelatedUserLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_UserLocationId");

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
                descending: new bool[0]);

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
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PCode",
                schema: "Facts",
                table: "F_UserRole",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PERPCode",
                schema: "Facts",
                table: "F_UserRole",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_UserRole_UR_RoleId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_UR_UserId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_DsblRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "DsblRecord",
                descending: new bool[0]);

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
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PCode",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PERPCode",
                schema: "Facts",
                table: "F_UserSkill",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_UserSkill_US_SkillId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_US_UserId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_UserId");
        }
    }
}
