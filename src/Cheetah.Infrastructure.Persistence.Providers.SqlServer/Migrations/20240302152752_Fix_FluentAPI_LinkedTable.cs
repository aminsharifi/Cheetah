using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Fix_FluentAPI_LinkedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Case_F_CaseId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ConditionGroupCondition_F_ConditionGroup_F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowTask_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_D_Process_D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Task_F_TaskId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Task_F_TaskId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_D_User_D_UserId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserConditionGroup_D_User_D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_WorkItemCondition_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_UserCondition_D_UserId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskFlow_F_FlowId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskFlow_F_TaskId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_F_TaskId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_ScenarioCondition_F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_L_FlowTask_F_FlowId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropIndex(
                name: "IX_L_FlowCondition_F_FlowId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_ConditionGroupCondition_F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseCondition_F_CaseId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropColumn(
                name: "F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropColumn(
                name: "D_UserId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropColumn(
                name: "F_FlowId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropColumn(
                name: "F_TaskId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropColumn(
                name: "F_TaskId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropColumn(
                name: "F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropColumn(
                name: "D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "F_FlowId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropColumn(
                name: "F_FlowId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropColumn(
                name: "F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition");

            migrationBuilder.DropColumn(
                name: "F_CaseId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.RenameColumn(
                name: "D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup",
                newName: "L_UserConditionGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserConditionGroup_D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup",
                newName: "IX_L_UserConditionGroup_L_UserConditionGroupId");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b857eae3-d466-487c-a9a2-af2303930656"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9db19e69-73b3-460f-8de8-61d8ad796506"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 788, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 470, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c14b8f87-4556-4fff-abbb-054c44a72b1a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("834f5256-7b72-4c91-b9ed-ca1682f11038"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("528afc48-f70c-45a6-95a4-d3c512aba767"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e2cce8ef-a3a2-47b0-8112-e501cfbf7f68"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("bdce9e60-db78-4e10-a6da-5235d3be389a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b183c903-4043-4a8d-87ab-9d31dacb2415"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(1339), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ea053fe2-50ae-461c-9203-ae785ffbda85"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6678004a-8a98-4a9f-ae3a-672fc32224d6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(8814), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("13866dc2-7e7d-4e67-b0f2-b6da9a53832e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("872048f7-5ce2-4657-a24a-459107d40d58"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(6051), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("43f4153f-8de5-4158-b245-522df65f3fd7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6fade4d2-2b54-4724-b066-1246fa1a2e6f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("83befb4d-dd0a-4122-94e4-8593b41f9fcd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f756ea29-5e2b-4427-ae53-a9f372df9e3d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1498f83e-9eba-4a03-9f19-9086783dfb06"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e93298ae-37f6-432c-8f6a-71aa74f82e82"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(7840), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a0d26d67-19f5-4e9f-b49e-6eea8876ee25"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a2edf63e-0d2c-4be7-8f4e-1eb9693a7a0b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(7857), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e61a8476-707a-4811-90f3-f4b8747f481f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a557078e-b591-4929-8949-c1ec0dd68487"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c27f8eb0-7905-42e3-a137-d8dd0673d2ec"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("845e37e6-580d-4ac3-a266-1467a68b0d02"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d8b575ad-a47b-4854-a079-901e41e1b50f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("096824b9-e79b-4a76-805b-f12940e47294"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b476c3b6-dffe-4cb0-848c-8b01a845353c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0936b643-f414-4baf-af5e-45e49ed3a870"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d116fab6-8be3-43e1-b86f-3ab2f76d02f2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("efd71dae-da17-4ac0-93a4-a074e82cbba2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(2036), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("64a2e651-5338-4efe-a748-244325bdbaab"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c1218229-df4f-4316-98d6-2731a9da14a6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(1859), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aa07e319-9e9d-4916-90e7-f10749c508b1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eba9be74-5705-4965-a428-669b838f92b9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5ba09a5b-6529-4d64-afad-a33634543122"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4a7810ab-ebb6-4c20-9b98-1a38ec122ab6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aff80fb8-c5dc-48d2-817a-9a2e727ebff7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("83138504-5bee-4646-80ed-60b693d5a5ad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7ac6e9dd-7b62-4bd8-aae5-689c85502b2c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6d245c2d-4954-4272-9ac3-8d47c61b2895"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(3895), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9d77c936-76fe-4a86-b3cb-7ef6dd96001d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6b135969-b0e2-49a2-b2ee-31e5b757e824"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(2160), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4df10013-8beb-494a-9292-e676e420b696"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("94ac8c57-48e4-4744-b4d9-4196ba7c3708"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("df11ffd5-9763-4b6a-ac59-8b2f7c3661cb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eb9aea06-fcac-44ee-a22f-a72f7ccd14fc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("703e09ee-9df9-4c0a-99d7-8d6bd480c383"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fea6d921-4aac-4f91-beee-936d6d51ddf5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1f5b1bc8-3bfa-47d7-9d64-be3659b8b871"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c3a15283-3717-4392-b434-9fac4b9259e6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(5013), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("53535591-c7cc-4ee1-b8b3-4e296a06a378"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f33be890-db75-4060-811d-56915e6ac5fc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ac3681da-c1e8-4391-b4b4-c5767ad668d5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c4cda7c7-ae79-481d-953a-a0d4298af6d3"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f38915a5-21ff-4fae-9a01-5233c4bb7121"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8348b205-bc99-4e55-b470-8442a5544812"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 781, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3c327741-ac2e-43e9-89b7-499efb603eba"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("be734bd4-fec6-437b-8cec-6f95b765745e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 781, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(6733), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3859), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e837c685-5e51-4f6d-b6ad-8b04175a1ed9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1664fcd2-a2e3-4436-ba55-5ed8aeb9b213") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93833b34-74d0-40eb-8a17-c99d4892cd8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fde6b59-72f4-416d-ab0a-fb1fefa50277") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3883), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b9db086-773d-4da3-8df3-7ea2e0abbb1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d8df063d-7599-4c2f-94cf-a6f11d39fd5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 385, DateTimeKind.Unspecified).AddTicks(1655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c7b2840-fba0-46e9-bc16-682cd29dab6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f95819fe-87a9-47eb-a44e-8a32ba246ed6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae9cb5cb-eacc-45a3-b1fa-310226e80b6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a4ba9b5-588f-4705-84c2-da0d2538127f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("726dc683-bfd9-4aa6-b9de-85e3e628655e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a61c5fa-8f7a-49c1-a1be-0320ac1ac68c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad4acc34-b9e7-464d-a967-e077441e26bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ef2489d-a766-4117-a1d6-bc22d9d0c41a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2280), new TimeSpan(0, 3, 30, 0, 0)), new Guid("645ca2b7-2e50-44b3-a51a-2f597f8ec201") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2285), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8d897e1-3489-4e2b-93f9-d6fa707f5aa5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2290), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1051f04-6c11-4b52-955e-3bae614e9961") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41b8b7b4-ddf5-4c23-82b3-dbcb118dcebe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2301), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6e178b9-d41d-449d-8d30-c1ccb6abb52f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bdfc6195-b6bf-4bb9-9ad7-85fbf61c561f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf5b94c8-48ea-4c2f-a740-aaa4f315bd9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a46a8bf-5a1d-45b8-9d6e-c99b8515fd28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a0253a9-8a4a-4020-9f1f-afc9e6c5ec60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9119), new TimeSpan(0, 3, 30, 0, 0)), new Guid("121ab04f-74c5-42a1-b7ff-b8129e836d6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4cdcc5f6-b658-4f6f-ac99-2175526c826b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9127), new TimeSpan(0, 3, 30, 0, 0)), new Guid("072886f0-168d-47ba-aa24-7afbc1983da1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9160), new TimeSpan(0, 3, 30, 0, 0)), new Guid("809b92ee-1ef2-42ba-83e0-4b540c5fb19c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 382, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de06dbd6-1cff-4c71-ac58-c6c2c24fe022") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("205ec56e-cd4e-4ed1-a9f9-482a83a73c57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b133eca6-7659-445d-850e-68620a2fe97c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c90661c1-d33f-44f9-a70a-e453e54e7b5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28310872-5e86-408e-a05e-7719b379e7a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4986), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6a077de-385c-419a-b520-d62bb4fbabaa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 3, 30, 0, 0)), new Guid("94879d50-379d-4f6a-8656-eff8899b6b03") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d482211-d8a7-48e1-8cdf-f0c404678b98") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f6ae7197-b86a-4b05-b9f9-c3d192f4af4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("289a19f1-5e9b-45fb-939c-aca9e4c49945") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0564e958-2037-4417-a609-a65a1df667e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(4568), new TimeSpan(0, 3, 30, 0, 0)), new Guid("76a3b99b-2387-49bb-bcb1-a9ceeff65da0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(6177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea7b301b-e3b9-4e04-b075-ee68e5a6becf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d2d4b3e-8afd-4d5f-b295-0196c2736614") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b213194-5157-4c87-aa10-50495266ee40") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 3, 30, 0, 0)), new Guid("17928282-d6b6-4a30-8583-94ba7e5b4b60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("858041a2-90ed-41e7-a9dc-041cd3191a95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 386, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab5eb8f3-182a-4304-bde1-117b7fd31357") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2faff28a-ad06-4d81-bddd-c594af0b464e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ff937ee-ce00-43d2-a287-fbfe702f9cf1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("929189c0-5dc4-4f5a-836f-21313cc9d4ec") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 383, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e3fd0b8e-d6c2-43b2-9c3f-fc74355ec845") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 382, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 3, 30, 0, 0)), new Guid("95313250-9fd9-4ac0-b5a0-208ed840bd4b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(1814), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73884a2f-eafe-49d3-bae5-434dda559a33") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 384, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db4e08b6-b380-4e98-bfa0-91ff8f595c54") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 381, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e3ee1217-1338-4b92-8857-539441b1a9d7") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserConditionGroup_L_UserConditionGroup_L_UserConditionGroupId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "L_UserConditionGroupId",
                principalSchema: "Links",
                principalTable: "L_UserConditionGroup",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_UserConditionGroup_L_UserConditionGroup_L_UserConditionGroupId",
                schema: "Links",
                table: "L_UserConditionGroup");

            migrationBuilder.RenameColumn(
                name: "L_UserConditionGroupId",
                schema: "Links",
                table: "L_UserConditionGroup",
                newName: "D_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserConditionGroup_L_UserConditionGroupId",
                schema: "Links",
                table: "L_UserConditionGroup",
                newName: "IX_L_UserConditionGroup_D_UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9db19e69-73b3-460f-8de8-61d8ad796506"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b857eae3-d466-487c-a9a2-af2303930656"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 470, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 788, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("834f5256-7b72-4c91-b9ed-ca1682f11038"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c14b8f87-4556-4fff-abbb-054c44a72b1a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e2cce8ef-a3a2-47b0-8112-e501cfbf7f68"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("528afc48-f70c-45a6-95a4-d3c512aba767"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "D_UserId",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b183c903-4043-4a8d-87ab-9d31dacb2415"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("bdce9e60-db78-4e10-a6da-5235d3be389a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 787, DateTimeKind.Unspecified).AddTicks(1339), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_FlowId",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "F_TaskId",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6678004a-8a98-4a9f-ae3a-672fc32224d6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ea053fe2-50ae-461c-9203-ae785ffbda85"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(8814), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_TaskId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("872048f7-5ce2-4657-a24a-459107d40d58"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("13866dc2-7e7d-4e67-b0f2-b6da9a53832e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(6051), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6fade4d2-2b54-4724-b066-1246fa1a2e6f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("43f4153f-8de5-4158-b245-522df65f3fd7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f756ea29-5e2b-4427-ae53-a9f372df9e3d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("83befb4d-dd0a-4122-94e4-8593b41f9fcd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 786, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_FlowId",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e93298ae-37f6-432c-8f6a-71aa74f82e82"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1498f83e-9eba-4a03-9f19-9086783dfb06"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(7840), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_FlowId",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a2edf63e-0d2c-4be7-8f4e-1eb9693a7a0b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a0d26d67-19f5-4e9f-b49e-6eea8876ee25"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(7857), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a557078e-b591-4929-8949-c1ec0dd68487"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e61a8476-707a-4811-90f3-f4b8747f481f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 785, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("845e37e6-580d-4ac3-a266-1467a68b0d02"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c27f8eb0-7905-42e3-a137-d8dd0673d2ec"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_CaseId",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("096824b9-e79b-4a76-805b-f12940e47294"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d8b575ad-a47b-4854-a079-901e41e1b50f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0936b643-f414-4baf-af5e-45e49ed3a870"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b476c3b6-dffe-4cb0-848c-8b01a845353c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("efd71dae-da17-4ac0-93a4-a074e82cbba2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d116fab6-8be3-43e1-b86f-3ab2f76d02f2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(2036), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c1218229-df4f-4316-98d6-2731a9da14a6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("64a2e651-5338-4efe-a748-244325bdbaab"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(1859), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eba9be74-5705-4965-a428-669b838f92b9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aa07e319-9e9d-4916-90e7-f10749c508b1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 784, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4a7810ab-ebb6-4c20-9b98-1a38ec122ab6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5ba09a5b-6529-4d64-afad-a33634543122"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("83138504-5bee-4646-80ed-60b693d5a5ad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aff80fb8-c5dc-48d2-817a-9a2e727ebff7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6d245c2d-4954-4272-9ac3-8d47c61b2895"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7ac6e9dd-7b62-4bd8-aae5-689c85502b2c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(3895), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6b135969-b0e2-49a2-b2ee-31e5b757e824"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d77c936-76fe-4a86-b3cb-7ef6dd96001d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(2160), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("94ac8c57-48e4-4744-b4d9-4196ba7c3708"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4df10013-8beb-494a-9292-e676e420b696"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 783, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eb9aea06-fcac-44ee-a22f-a72f7ccd14fc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("df11ffd5-9763-4b6a-ac59-8b2f7c3661cb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fea6d921-4aac-4f91-beee-936d6d51ddf5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("703e09ee-9df9-4c0a-99d7-8d6bd480c383"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c3a15283-3717-4392-b434-9fac4b9259e6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1f5b1bc8-3bfa-47d7-9d64-be3659b8b871"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(5013), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f33be890-db75-4060-811d-56915e6ac5fc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("53535591-c7cc-4ee1-b8b3-4e296a06a378"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c4cda7c7-ae79-481d-953a-a0d4298af6d3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ac3681da-c1e8-4391-b4b4-c5767ad668d5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 782, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8348b205-bc99-4e55-b470-8442a5544812"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f38915a5-21ff-4fae-9a01-5233c4bb7121"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 781, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("be734bd4-fec6-437b-8cec-6f95b765745e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3c327741-ac2e-43e9-89b7-499efb603eba"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(6733), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 18, 57, 51, 781, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b63fbe3-250a-4280-8d7c-7176f9a699fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0950af18-037c-472c-8091-80c9fa5d5ca3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24e0ed5e-e8c4-4983-bd44-9bcf182cd8b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f4be6a1-b395-4bfa-afb9-d9b9da1996c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3650ec4-f345-42ab-9ae2-7a632864b162") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b99617e-9fad-4cf9-9ce0-2b65571ed1bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 51, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d52630b9-5ea9-43b5-bbee-110ed0d71b4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4445d897-36f4-4b77-b5da-778a05b3af57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d43bdfe5-62b0-4168-b6ab-bbd004015e2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3473e4d4-76c3-49b5-9360-6199684714ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5fb1671d-5909-4084-8bbd-efa07bef1495") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d20eed1f-9fe9-491e-91e7-081475bd267b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efc7b334-4825-4f82-86a4-a0b2bd26d3ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("10631a89-8c90-447c-875b-da41b583cb0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7028), new TimeSpan(0, 3, 30, 0, 0)), new Guid("600f8348-de5b-43fb-8a7a-088832544215") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ae5f30a-42ad-4b52-a2dd-f2efe0157edd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 3, 30, 0, 0)), new Guid("29b360c4-f0c6-435c-8c29-bea89dcc0a41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7042), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f478f0bf-e7a0-4a0f-9373-d90c711f47a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8b5f976-e8a1-4c28-ad62-c60f4e72bc64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f691e09c-1f61-4288-b8f4-634fbafe918f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 52, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52e6b701-9b86-40ad-a1de-df755fa724a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df93a5a0-33f3-4cee-b9ff-f540cec5d02b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3884), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c70115d7-83ef-48e5-8ecc-5b1c1b81394c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3887), new TimeSpan(0, 3, 30, 0, 0)), new Guid("021789e8-ebb6-4cdf-9a2d-6f48484e7d2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20249596-9cfc-407b-9f20-bdec83c43e97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b1b079d-2fcf-44dd-813a-f4dc1ed302aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6eb40fec-cf17-4dd0-b072-75df9c843ad1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 48, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b17a942f-4434-4912-918c-e0337169f1bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(5909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07021d5f-9155-4905-bc9b-d4e0791e1de5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 3, 30, 0, 0)), new Guid("295b26ab-8de5-4cb9-b086-ea61e4d5174e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f106eb36-e346-46fc-8c5b-5fc120dc487e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7621), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a49710f1-2e7c-4a51-b715-0f12fbbfd7e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7624), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2aa9023a-4fa4-48e5-b706-45688cebbf4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e89e2467-8aba-4a60-99a6-a37d2852a721") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52392597-2d83-4420-b0c2-01e525472536") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ddefb94d-3967-4fa9-a071-ef025e5e0694") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4dc1a669-210d-4d7d-8d4b-0eae00a370a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8dd1ab05-1b5d-41dc-9cd9-379ebe817cea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc9d90da-e377-4d0b-b039-ce5626a61b2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 3, 30, 0, 0)), new Guid("689842b8-ca1f-4273-bcc3-f29aec0c40f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe43af9e-252b-4d11-b10e-b1f7678a639e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f3d637d-934b-4e79-9138-b3ceb2774f60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(2474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f547266-9c25-427f-a015-9a542bd142ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93616e68-fab3-49b2-b4c1-96741c55b3d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 53, DateTimeKind.Unspecified).AddTicks(2479), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a9d716d-b0f7-4766-9402-56103bd9253f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 49, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f49d7ec4-a1f3-4f15-ba8d-2daa8dce26d4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d66f9af5-008c-40a4-b593-8e4166f80fe1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f6fcb7d7-ef4d-4410-adba-3cd6331968d0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(4478), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a192d898-ff80-4e80-bd0e-60c2412d5c85") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 48, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee029d3a-1987-4c5b-a4ce-0212fe6950c8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(6544), new TimeSpan(0, 3, 30, 0, 0)), new Guid("916a314b-c47e-48f0-ba05-5da11e638dad") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 50, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a599b12f-c76a-4090-82ac-3792f1a5a0d9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "D_ProcessId", "F_ScenarioId", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 48, DateTimeKind.Unspecified).AddTicks(3547), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("638a415b-3e7d-414a-b2d9-345bcd11982c") });

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "F_WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_D_UserId",
                schema: "Links",
                table: "L_UserCondition",
                column: "D_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_F_FlowId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "F_FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_F_TaskId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "F_TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_F_TaskId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "F_TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "F_ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "D_ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "F_ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_F_FlowId",
                schema: "Links",
                table: "L_FlowTask",
                column: "F_FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_F_FlowId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "F_FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "F_ConditionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_F_CaseId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "F_CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Case_F_CaseId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "F_CaseId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ConditionGroupCondition_F_ConditionGroup_F_ConditionGroupId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "F_ConditionGroupId",
                principalSchema: "Facts",
                principalTable: "F_ConditionGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "F_FlowId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowTask_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_FlowTask",
                column: "F_FlowId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_D_Process_D_ProcessId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "D_ProcessId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_F_ScenarioId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "F_ScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_F_ScenarioId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "F_ScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Task_F_TaskId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "F_TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Flow_F_FlowId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "F_FlowId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Task_F_TaskId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "F_TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_D_User_D_UserId",
                schema: "Links",
                table: "L_UserCondition",
                column: "D_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserConditionGroup_D_User_D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "D_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "F_WorkItemId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id");
        }
    }
}
