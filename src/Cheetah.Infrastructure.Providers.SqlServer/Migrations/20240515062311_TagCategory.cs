using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class TagCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Flow_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Flow");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserConditionGroup_F_ConditionGroup_SecondId",
                schema: "Links",
                table: "L_UserConditionGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropTable(
                name: "F_Attachment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "L_ConditionGroupCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "F_ConditionGroup",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_Flow_CaseStateId",
                schema: "Facts",
                table: "F_Flow");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ed2e8e0c-5d3f-46c8-a9e8-9b0e7d291123"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 706, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("41e8af51-f468-47bc-924f-5a6716689c99"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 705, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cff16211-98d9-448d-bc6a-82427fc6119a"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 704, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d9a844c3-cb3f-45c4-9292-29b0c988fa04"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 703, DateTimeKind.Unspecified).AddTicks(169), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d26f2d8d-3fbd-463c-bc64-0c419feed634"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 701, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("39642d8c-4d8e-4e56-b613-9ecda1d116b8"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 699, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fc9a6adb-2023-4251-842e-5f9eeb42279e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 697, DateTimeKind.Unspecified).AddTicks(3282), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("647a2d48-0c3a-4e4e-9f15-6c7418514c32"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 695, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("244956c9-1575-4d4a-b20b-495e79a4e88c"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 694, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("062534f3-801c-42a2-ade7-a2bb4fa31374"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 692, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("05bf4d92-3017-4159-95fb-545d4f859bbc"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 691, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("185ae323-6932-413b-b4bb-2799906cec3a"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 689, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f8e9406e-1f6b-4ed2-9779-3a685a72dff0"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 688, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3cba603f-3f34-4494-9cf1-4289460bfbac"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 687, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("567c43e5-e29b-4e54-a2aa-154f7696803b"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 685, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d8ff502a-ae9c-47cb-8ca4-bbfdca3e86b6"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 682, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1e885441-6c33-457b-95d5-9ee8e3bf1e50"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 680, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6cb7f942-f3ce-4790-9d55-2f61612dae8b"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 678, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("84ea5d5c-f884-47ff-a906-4d1a0f176271"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 677, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ab659fe2-e26d-4616-8c0f-bb93b6311c37"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 672, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("703eebfe-f5c9-4ad0-8d71-c177289c143c"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 671, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("26947d7c-4bad-4138-bac5-e188f8600a67"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 670, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AddColumn<long>(
                name: "TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3b440068-5869-4bdf-8646-75b31a8f928e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 668, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4ae4164e-0dea-416c-a7b8-1fce7dd63cd5"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 667, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5a8114ea-e452-4503-be74-3a0d0382405d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 666, DateTimeKind.Unspecified).AddTicks(976), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0719d2a9-2f0f-442b-aa74-2eef877809f5"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 664, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.CreateTable(
                name: "D_TagCategory",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_TagCategory", x => x.Id);
                },
                comment: "Action, Performer");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a163bb6a-c082-4e9d-b806-1c5279323662") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8a83576-2c73-49d8-8b74-02fd7ee4ed51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a7426349-5ddf-48d6-aa20-b863fa34fd72") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 3, 30, 0, 0)), "تایید شده", new Guid("1a5b91ac-8fed-4cfa-be60-c8e11081e824"), "Approved" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cfe7601-0857-4dbf-91fa-527b8558f904") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cbf1807f-13a3-4cda-95e4-3e5b1768de07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 311, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 3, 30, 0, 0)), new Guid("583b7ac7-54b1-4789-a375-4935196b5682") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e7550c1-25db-45ba-855b-a7ac867def2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82fa0312-c141-4025-9b5b-b851dc60efaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4e1ee04-c2e5-4de1-87bb-5b789b1ac8f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd1649be-d8a8-4d93-bcf7-a73c5f4a9e52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c23c8ec9-ec5f-43b4-943b-c959702e33d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b937b6be-d454-4d69-a84e-409b7817ce19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c59fc73f-154e-4efc-816a-66df738d0354") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e38665c-8042-43a1-b91a-5526200f88b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3def7146-63ce-423c-b48f-ed9948018171") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dccd15d7-9907-4777-bafc-0169aa88615f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7727), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c47303d-97a6-4260-946f-0001255b30be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c0db8f6-6c7f-4ba6-b0cf-0fecf5e97c42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 3, 30, 0, 0)), new Guid("36d4a28e-f2a6-4b3b-804f-e742489b6b37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 312, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8edd48fe-9de1-4288-9f3e-0e3eb4977f4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5c276caa-5d50-4c32-aa37-3606b9b1fb84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6420), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59d06e81-3bb5-4ae6-9106-cd5c495196a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3dc18d90-0fa7-40e2-8f9c-8e4f3dae2afe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 3, 30, 0, 0)), new Guid("073268fa-dc09-4507-b037-d6c42cb4c4e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6428), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f2e548d-64bb-423f-9885-770b8917dbe7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5ec79de-2f37-4e52-86c4-a8d0e247bef4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 308, DateTimeKind.Unspecified).AddTicks(780), new TimeSpan(0, 3, 30, 0, 0)), new Guid("893b30e4-95e7-4068-823e-d3d09cc3d22c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(1028), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d77e2aba-1f9d-4c98-9d46-39b07beb880b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 3, 30, 0, 0)), new Guid("576cc38f-1407-4113-a314-7c298500191a"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2520), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6a1fc75f-f3d6-4d9e-acbc-e13a0acc9c3c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b52444ae-5314-4dfe-86a4-710969e13b5e"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f1f716b-5326-43a6-8ade-454f617e0493"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9e1b890-3e78-490d-9e8a-01e2f22d776f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord", "TagCategoryId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37f65926-0396-4167-9ce8-f08b9a607a48"), null });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagCategory",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(2936), new TimeSpan(0, 3, 30, 0, 0)), "Performer", 1L, true, new Guid("f6c83bed-9d51-4d64-9b86-87f5168f66c2"), "Performer", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 3, 30, 0, 0)), "Action", 2L, true, new Guid("b08f55a4-ce0a-4a68-b509-bfc5c1e049e0"), "Action", 2L }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2104), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ddfd9d7-419c-49f2-a869-aab51e4df6ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c42ad5b-9d18-4095-82d3-f9d2d40af94e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2115), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ccba371-7c4b-46b0-adb9-566cedfe3e1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 3, 30, 0, 0)), new Guid("da810c3a-c344-4c45-a4e1-9b1053bf484a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91590399-0c12-40e3-9b4c-2badce6b38ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d89de98-ed3f-44b2-a3b8-6795a600b53b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5c502d16-cf85-47cd-b194-696328d76965") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a5e45e1-40f0-4723-9039-3352a91ecb74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(1999), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c852d3c5-8c79-446b-a220-838026307c7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 310, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8fde9be-d06f-40ff-a264-fef451322524") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 308, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ef55a09-fa5b-4bb7-b73d-6fdd255c4023") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c89f7f4-3d33-444a-bf04-e19288e6f464") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e22b36d-a747-4a5e-bcbd-5e6b6532864b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce78d1da-35ab-4333-ab33-d72e1d13853d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 308, DateTimeKind.Unspecified).AddTicks(2344), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1bcf441-29eb-48f3-bfc1-757ccb5a6e1e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e3cd45b1-3743-4f65-ac7d-4084c720eab1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 309, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("60a3d1fa-fb21-43c1-aa0a-681401767455") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 9, 53, 10, 296, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 3, 30, 0, 0)), new Guid("220df0db-772e-4c8c-8b7b-006d93b50133") });

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_Created",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_ERPCode",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_LastModified",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_Name",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagCategoryId",
                principalSchema: "Dimentions",
                principalTable: "D_TagCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropTable(
                name: "D_TagCategory",
                schema: "Dimentions");

            migrationBuilder.DropIndex(
                name: "IX_D_Tag_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropColumn(
                name: "TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ed2e8e0c-5d3f-46c8-a9e8-9b0e7d291123"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 706, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("41e8af51-f468-47bc-924f-5a6716689c99"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 705, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cff16211-98d9-448d-bc6a-82427fc6119a"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 704, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d9a844c3-cb3f-45c4-9292-29b0c988fa04"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 703, DateTimeKind.Unspecified).AddTicks(169), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d26f2d8d-3fbd-463c-bc64-0c419feed634"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 701, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("39642d8c-4d8e-4e56-b613-9ecda1d116b8"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 699, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fc9a6adb-2023-4251-842e-5f9eeb42279e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 697, DateTimeKind.Unspecified).AddTicks(3282), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("647a2d48-0c3a-4e4e-9f15-6c7418514c32"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 695, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("244956c9-1575-4d4a-b20b-495e79a4e88c"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 694, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("062534f3-801c-42a2-ade7-a2bb4fa31374"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 692, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("05bf4d92-3017-4159-95fb-545d4f859bbc"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 691, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("185ae323-6932-413b-b4bb-2799906cec3a"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 689, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f8e9406e-1f6b-4ed2-9779-3a685a72dff0"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 688, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3cba603f-3f34-4494-9cf1-4289460bfbac"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 687, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("567c43e5-e29b-4e54-a2aa-154f7696803b"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 685, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d8ff502a-ae9c-47cb-8ca4-bbfdca3e86b6"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 682, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1e885441-6c33-457b-95d5-9ee8e3bf1e50"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 680, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6cb7f942-f3ce-4790-9d55-2f61612dae8b"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 678, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("84ea5d5c-f884-47ff-a906-4d1a0f176271"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 677, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ab659fe2-e26d-4616-8c0f-bb93b6311c37"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 672, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("703eebfe-f5c9-4ad0-8d71-c177289c143c"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 671, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("26947d7c-4bad-4138-bac5-e188f8600a67"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 670, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3b440068-5869-4bdf-8646-75b31a8f928e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 668, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4ae4164e-0dea-416c-a7b8-1fce7dd63cd5"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 667, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5a8114ea-e452-4503-be74-3a0d0382405d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 666, DateTimeKind.Unspecified).AddTicks(976), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0719d2a9-2f0f-442b-aa74-2eef877809f5"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 664, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date");

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 679, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 3, 30, 0, 0)), comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("c4c9eb9c-94f5-4990-b2de-e45a87e1db41"), comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: "", comment: "English name of each record"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F_ConditionGroup",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 684, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 3, 30, 0, 0)), comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d6e9541c-27fd-431b-bf8a-96093ff43285"), comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_ConditionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L_ConditionGroupCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 693, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 3, 30, 0, 0)), comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("cb37de6c-0547-40eb-a643-fa403cd5366c"), comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ConditionGroupCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ConditionGroupCondition_F_ConditionGroup_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_ConditionGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_ConditionGroupCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d2bb422-c7b9-4656-8149-ded351528db2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e4af065a-c4ae-4da0-ad90-7f760f9b1fc5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d067da0d-b41a-45d9-9206-3eaf9e12999d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "LastModified", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7535), new TimeSpan(0, 3, 30, 0, 0)), "کامل شده", new Guid("08286a22-f133-4427-b8f8-47db32a7cb64"), null, "Completed" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d7ad963-2532-4887-bf1c-cc4790bb3114"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1699da6-abb0-4784-9ce2-5b2fb289df6d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 723, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33ed249c-ccac-4039-8a32-785f335379bd"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41fd846f-e0de-4730-a2de-42c117f7c8e9"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b660057a-213b-4607-a723-af92b304290b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eafa7a70-5ce3-4677-81db-5ba5d0f20aec"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77963f75-3f7c-468a-b8b3-2561cf86b04a"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04ec113a-44cc-43c1-80c8-46d0331830ec"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42e2f6e3-5aa3-4fdd-b911-f75e0c7c7af2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4e07f06-6e4c-4a1e-8956-78053b31e2e7"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("028c3ced-11c7-45d1-8a18-32168743626d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 3, 30, 0, 0)), new Guid("684e9232-9bcf-4e78-b82c-5f5dc0e70ac0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e28591cd-4be2-405c-8ab2-4995fc5fe85d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7f162b8-51a7-486e-8b8f-595efff13fc6"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1d6a2f4-b309-42f4-8384-1cf03d03fea9"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eeaebc63-1c24-4a6d-b80f-177349b22c3d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2077b94a-e167-4757-936f-2d3cdc7e81ef"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e620cf9a-895b-4d96-a091-936267d8da97"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6f634e9-75ae-41c3-a898-be1214410d8f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d9eb76d-1c9c-410b-a65c-e6995ca2f0ba"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee04301e-b55a-43dd-817b-9094027555d5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8272073e-7d00-4986-89e9-84fded0f8057"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca1eec58-20d4-471c-ace8-b0595dc37c96"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 717, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0e1682d-eac4-4c45-b194-4b01de538b2f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 719, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b2bd6d0-5a47-41c6-a72a-0c9eda6b1c93"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("394e0d23-314f-4716-a6f7-ef157f22d199"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 3, 30, 0, 0)), new Guid("53b8ab46-ebb1-467c-84ff-5284c9df90bf"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba52a109-07ae-40d0-a6bf-34308fb152b8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04f6dad0-d79f-408d-bfbe-76f51a5debda"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b16e5a4-c053-4fd8-96ca-adad22f3c2ad"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("212bef65-5cc8-48d2-acaa-775c8bc5c0b5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1342), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08389e94-e030-4d29-80b2-fc5feb3ea2d0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0fa3dea0-51bf-433a-b37b-62ee24aca2a2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa10277d-700d-4105-a567-6e365b43ae54"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e41dfec7-8a33-446e-86b4-818f93e8e354"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(2938), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d69cd4e7-e1ae-4dc5-9ead-4dba3857432c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 3, 30, 0, 0)), new Guid("764ac60d-2b68-4d66-b1ad-37160e308fce"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6bca60fe-2b80-4f20-a41d-6f9cc1ce9822"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a42202a-0b2d-4dde-8e46-520e85e917a0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 3, 30, 0, 0)), new Guid("318564f2-d199-49ab-bb78-4fe5af0b40a8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9cf2a053-dc78-4668-b86e-c8dce2e4ad98"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 719, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 3, 30, 0, 0)), new Guid("584329ab-3b6e-43e0-ab26-1fbadc472bce"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdfec767-bb14-4e5e-91d8-c2243a4a0730"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2c106eb-31e3-46c3-8baa-1a264bcc4332"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4198fca-4251-43ac-8278-c893bae48567"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 717, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3acf63f-d8ac-41b5-bd2d-4c0ac6c6d816"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(3938), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d00d1d2e-aa25-4a9b-bd00-8fbff7b60556"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 3, 30, 0, 0)), new Guid("777f0b10-7483-4ac9-87e5-0da59fdf77bb"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 716, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e56752f-a77e-4362-b78f-1947ce65177a"), null });

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_CaseStateId",
                schema: "Facts",
                table: "F_Flow",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Created",
                schema: "Facts",
                table: "F_Attachment",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_LastModified",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Name",
                schema: "Facts",
                table: "F_Attachment",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_EnableRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_ERPCode",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_LastModified",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_EnableRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_ERPCode",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FifthId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FirstId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FourthId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_LastModified",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_SecondId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_ThirdId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Flow_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Flow",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserConditionGroup_F_ConditionGroup_SecondId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_ConditionGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }
    }
}
