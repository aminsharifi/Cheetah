using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Fact_Link_Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "L_WorkItemCondition",
                schema: "Links",
                comment: "Conditionals of each workitem");

            migrationBuilder.AlterTable(
                name: "L_UserCondition",
                schema: "Links",
                comment: "Conditionals of each user");

            migrationBuilder.AlterTable(
                name: "L_TaskFlow",
                schema: "Links",
                comment: "Exit flows of each task");

            migrationBuilder.AlterTable(
                name: "L_TaskCondition",
                schema: "Links",
                comment: "Conditionals of each task");

            migrationBuilder.AlterTable(
                name: "L_ScenarioCondition",
                schema: "Links",
                comment: "Conditionals of each scenario");

            migrationBuilder.AlterTable(
                name: "L_ProcessScenario",
                schema: "Links",
                comment: "Related scenarios of each flow");

            migrationBuilder.AlterTable(
                name: "L_FlowTask",
                schema: "Links",
                comment: "Exit tasks of each flow");

            migrationBuilder.AlterTable(
                name: "L_FlowCondition",
                schema: "Links",
                comment: "Conditionals of each flow");

            migrationBuilder.AlterTable(
                name: "L_CaseTaskUser",
                schema: "Links",
                comment: "Manual choosing performer");

            migrationBuilder.AlterTable(
                name: "L_CaseCondition",
                schema: "Links",
                comment: "Conditions of each case for selecting correct scenario");

            migrationBuilder.AlterTable(
                name: "F_WorkItem",
                schema: "Facts",
                comment: "Numeric, Text, Date, binary");

            migrationBuilder.AlterTable(
                name: "F_Task",
                schema: "Facts",
                comment: "Entities like position, role, etc.");

            migrationBuilder.AlterTable(
                name: "F_Scenario",
                schema: "Facts",
                comment: "Scenario of processes");

            migrationBuilder.AlterTable(
                name: "F_Flow",
                schema: "Facts",
                comment: "Flow of BPMN for transferring between tasks");

            migrationBuilder.AlterTable(
                name: "F_Condition",
                schema: "Facts",
                comment: "Condition of each tag");

            migrationBuilder.AlterTable(
                name: "F_Case",
                schema: "Facts",
                comment: "Each request create one record in this table");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("59aeb0bc-8f47-413a-be64-20948c491881"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e83a6052-74bf-4c5d-954e-5a858083f4b9"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 303, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0a200b5c-4b5d-45c4-8f71-e0c12595356d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("76f1b98f-31ba-43eb-92b1-1f1457e1350f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3c10a7eb-4e3b-496b-93f7-1acfbad39d4d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ad7d68d2-db88-4d42-9a01-5e34afa4c622"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4efe093a-7815-42fc-8e65-b91a728c810f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7e27b5d2-1019-4c5f-9826-f1030f0befa4"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c36a8848-3319-431d-b708-039173d71726"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("315cc1a1-7b26-49fb-ae8e-ed15cd2aa222"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(6482), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0d746cd0-25c8-4fb5-972c-3ed798a049ad"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("51f57ee4-9bed-4236-91bd-545131e89058"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("753abb5e-2dcf-4cad-8969-c6d0b626d306"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("68510fa2-3fed-47de-ad22-ba03b71a9948"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("27b76279-8e48-4352-8b6f-690b6a10467e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4ee68cf9-9b16-4bcd-b780-2ee9ecfa4bfc"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("21386b53-eac3-4feb-bdd6-8164e2ea679d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f1129aae-584c-4d11-92ca-eceaec994abb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd50bcba-78eb-41e7-b37d-96269257e81c"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d5f0aede-d792-4f3a-b842-e209bcc81906"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eb66fbc8-98e6-4ad0-ae68-254ee982586e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fc452553-97cb-4176-bca0-39d70ba3c9e2"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("28387c9f-05b0-482c-a3c4-c87b67252b4e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("74f041f4-d002-4f89-88f7-b8159e813277"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("37cd2f8b-287f-415a-b286-6254859cc1c6"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5fd8659d-a256-41f5-b537-768c0e8166fa"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9d92203e-315d-43f6-a7ea-59cd01d9bf8c"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8bb55a1c-bfc0-44f0-a9bb-5e39fa46ecb0"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("24df1c02-0fbe-4e5e-8867-9f3b033dc0a4"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cd4974d9-2285-4ff9-9cf7-ce931890bf50"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c7f0522e-1c82-4eac-9233-bbb3b404a361"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ce21e291-ca54-47c3-9922-6b8c3a57e41d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4fececa6-cbb8-4ee5-8dff-dee430eb8349"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e570d92-e104-499e-b0a9-ca714753d2cb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fc2043a1-8bb0-47d9-a5d2-aad990996bcc"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7b4d38fc-aaf8-4dd1-a396-954255ef7fca"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 31, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4253a297-c30d-4b46-805c-017bf4b5f3e1"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("794e6119-9d85-4712-8f18-390dc1c26946"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c65005fb-983c-478a-bfd4-b9b8748b6b4f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d7c0a250-2717-4520-afed-876ebbeb48f5"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f0281dff-41b2-4dd3-aede-ea5062506a7e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a5d21dad-6579-40a3-8dda-2ffec5dd3b5e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fec2663a-79e8-4897-98c5-2f8761b08b3e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("11368d36-63f4-491c-a5fd-35899cb3139e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 29, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ead44cce-6a1b-4c6f-8e31-60ca62c5dcbe"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9ae30f04-e8d0-457d-86fb-9542201190c4"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 27, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8523bfd4-c893-41c9-bebf-323eedf7c672"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("66f1463f-dc52-4929-ab9d-65c7a5f564ea"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 26, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d650ab90-958c-4120-a0dd-0c048c02fab8"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("93c8b170-968b-4819-bb6e-65f2919d987f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(6125), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1b378d48-63d0-4b37-be30-a660fe5e7045"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2b689da7-0d01-4e9b-9390-6d43a6a30465"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3dee5fc7-76ee-4aa7-83ec-427cc02e01dd"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b7a1dacb-c78c-4d08-8210-39839947b2eb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("734472ec-d9ea-4d0b-8e86-20b54881218b"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7d8b1016-5acc-40ba-a530-f8ec5d78df94"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cbfeb1c8-f107-40da-acbc-f05737aa1177"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fae2a328-8103-4917-8652-402e3f516168"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 23, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8385), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2cf99f1-8ed6-46a8-bdf0-59cac8c0a18e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8391), new TimeSpan(0, 3, 30, 0, 0)), new Guid("500f63d1-b9ae-4d05-8fa0-5da753a93970") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 3, 30, 0, 0)), new Guid("674b0852-f156-41f9-83d4-ca0d9aeaff05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 3, 30, 0, 0)), new Guid("75990012-173e-458b-adae-b140a6755318") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8399), new TimeSpan(0, 3, 30, 0, 0)), new Guid("724b03d6-29ac-4cd3-b7f5-1a4c21700717") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92693998-32ad-47c6-8192-8a3c9e94b088") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 566, DateTimeKind.Unspecified).AddTicks(8138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c34e0586-0441-4795-8494-b12acbb482ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1013175-8df1-42f6-969a-f0294dc3acc4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8501), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d2afffb-d8c7-45f2-85d2-ff02a699790b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8508), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be84e137-352e-47b2-9cc9-e90592a63f7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3052627-f4ce-42c2-96f4-d4d235f7384e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbc6bb7e-f8d8-4c03-ad51-5f9e692124dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d8a2e1c-0132-4244-931c-2092d938e927") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b73432fe-9003-49ed-a69b-c5c011ac3313") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e5fb5e6-2c19-4f23-bdc8-855f9b88ddba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8557), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a8944db-5f46-46b3-a76c-d39879cbbb0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8563), new TimeSpan(0, 3, 30, 0, 0)), new Guid("137bd54e-f2cd-4f53-86ef-0f592bfc2695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8568), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b730980-d9d2-47f2-a7aa-f4b0835ac1dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8573), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dddfc830-063a-41bf-a1f8-815bf03a04b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 3, 30, 0, 0)), new Guid("088ff840-f954-427b-8794-9981cf406b32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 567, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8475a70d-8154-4add-908a-a2c0f492417e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a56e76b-e971-4dc0-a79e-def9672ba3eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4079c6c-843b-4af3-bc67-a813e082bd27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a754a940-71e1-4045-b3df-c1c20abbe038") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a567bbd1-aef9-41b3-ba3d-5e8e84443dc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18f5c956-fb95-42ba-81cd-60f3cf7f4661") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c02ebc7-b31c-4f1a-ab5f-3183f285618b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 563, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7537934e-fca3-48b4-b63a-e2244f81db2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(7785), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bf695b5-c0f8-4843-a8b8-8c174907c228") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92f5faa8-855e-4744-a5bc-84bdecbd6e26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b60964b8-16ee-46f1-abab-684df714eaa5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55a0357d-fcd9-4186-9cff-363ae18f8599") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70344f1f-42dc-4bcb-a2dc-56be2bdf6cbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40f674d0-2696-4182-b715-3da23e041f61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4dc87c50-966a-4040-b78c-f2d3a8f0c624") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80842475-ec4f-4b7e-9101-0fb3e6983c18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9069), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f5e9476-8640-4e89-b160-1cae1e2f785a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cfc72be7-17b8-4ac8-bd89-2ef88f993f58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a7437a3a-7f53-4a0d-8fcf-e9ebc19da5d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 3, 30, 0, 0)), new Guid("494458db-e15e-4edb-9e7e-cf1f87b9a8f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2ba33c7-e409-4ce7-ad9d-a558e3345ccc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78b84ff7-4a32-4900-aaf8-5cec7ab3876d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e54cff95-3904-461f-a1d0-e2d59a78db75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e25ee967-6b33-4cd9-983f-90716f6b2a1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 568, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61c90aed-1789-4d6f-b3a3-f8cc2bc2ed56") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 564, DateTimeKind.Unspecified).AddTicks(4781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a521db44-a970-4f36-9f40-145d719abc1a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb571f40-a86e-4ca9-98c9-1c329a003915") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd48336b-b6c8-4fc3-81e2-f807c5f5ca89") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4e22b4f4-e99e-4762-b703-c4997212b684") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 563, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("474616ef-b126-4962-8e25-250e9b7c4d14") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae6b1255-d690-4e1e-914c-4ef9de0dd62d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 565, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01d037d1-86e4-4925-a968-7ff4d29571bf") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 28, 563, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d7aed76-87dd-44b4-86d0-770d592bfd9d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "L_WorkItemCondition",
                schema: "Links",
                oldComment: "Conditionals of each workitem");

            migrationBuilder.AlterTable(
                name: "L_UserCondition",
                schema: "Links",
                oldComment: "Conditionals of each user");

            migrationBuilder.AlterTable(
                name: "L_TaskFlow",
                schema: "Links",
                oldComment: "Exit flows of each task");

            migrationBuilder.AlterTable(
                name: "L_TaskCondition",
                schema: "Links",
                oldComment: "Conditionals of each task");

            migrationBuilder.AlterTable(
                name: "L_ScenarioCondition",
                schema: "Links",
                oldComment: "Conditionals of each scenario");

            migrationBuilder.AlterTable(
                name: "L_ProcessScenario",
                schema: "Links",
                oldComment: "Related scenarios of each flow");

            migrationBuilder.AlterTable(
                name: "L_FlowTask",
                schema: "Links",
                oldComment: "Exit tasks of each flow");

            migrationBuilder.AlterTable(
                name: "L_FlowCondition",
                schema: "Links",
                oldComment: "Conditionals of each flow");

            migrationBuilder.AlterTable(
                name: "L_CaseTaskUser",
                schema: "Links",
                oldComment: "Manual choosing performer");

            migrationBuilder.AlterTable(
                name: "L_CaseCondition",
                schema: "Links",
                oldComment: "Conditions of each case for selecting correct scenario");

            migrationBuilder.AlterTable(
                name: "F_WorkItem",
                schema: "Facts",
                oldComment: "Numeric, Text, Date, binary");

            migrationBuilder.AlterTable(
                name: "F_Task",
                schema: "Facts",
                oldComment: "Entities like position, role, etc.");

            migrationBuilder.AlterTable(
                name: "F_Scenario",
                schema: "Facts",
                oldComment: "Scenario of processes");

            migrationBuilder.AlterTable(
                name: "F_Flow",
                schema: "Facts",
                oldComment: "Flow of BPMN for transferring between tasks");

            migrationBuilder.AlterTable(
                name: "F_Condition",
                schema: "Facts",
                oldComment: "Condition of each tag");

            migrationBuilder.AlterTable(
                name: "F_Case",
                schema: "Facts",
                oldComment: "Each request create one record in this table");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e83a6052-74bf-4c5d-954e-5a858083f4b9"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("59aeb0bc-8f47-413a-be64-20948c491881"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 303, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("76f1b98f-31ba-43eb-92b1-1f1457e1350f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0a200b5c-4b5d-45c4-8f71-e0c12595356d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ad7d68d2-db88-4d42-9a01-5e34afa4c622"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3c10a7eb-4e3b-496b-93f7-1acfbad39d4d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7e27b5d2-1019-4c5f-9826-f1030f0befa4"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4efe093a-7815-42fc-8e65-b91a728c810f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("315cc1a1-7b26-49fb-ae8e-ed15cd2aa222"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c36a8848-3319-431d-b708-039173d71726"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(6482), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("51f57ee4-9bed-4236-91bd-545131e89058"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0d746cd0-25c8-4fb5-972c-3ed798a049ad"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("68510fa2-3fed-47de-ad22-ba03b71a9948"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("753abb5e-2dcf-4cad-8969-c6d0b626d306"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4ee68cf9-9b16-4bcd-b780-2ee9ecfa4bfc"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("27b76279-8e48-4352-8b6f-690b6a10467e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f1129aae-584c-4d11-92ca-eceaec994abb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("21386b53-eac3-4feb-bdd6-8164e2ea679d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d5f0aede-d792-4f3a-b842-e209bcc81906"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cd50bcba-78eb-41e7-b37d-96269257e81c"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fc452553-97cb-4176-bca0-39d70ba3c9e2"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eb66fbc8-98e6-4ad0-ae68-254ee982586e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("74f041f4-d002-4f89-88f7-b8159e813277"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("28387c9f-05b0-482c-a3c4-c87b67252b4e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5fd8659d-a256-41f5-b537-768c0e8166fa"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("37cd2f8b-287f-415a-b286-6254859cc1c6"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8bb55a1c-bfc0-44f0-a9bb-5e39fa46ecb0"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d92203e-315d-43f6-a7ea-59cd01d9bf8c"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd4974d9-2285-4ff9-9cf7-ce931890bf50"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("24df1c02-0fbe-4e5e-8867-9f3b033dc0a4"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ce21e291-ca54-47c3-9922-6b8c3a57e41d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c7f0522e-1c82-4eac-9233-bbb3b404a361"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3e570d92-e104-499e-b0a9-ca714753d2cb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4fececa6-cbb8-4ee5-8dff-dee430eb8349"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7b4d38fc-aaf8-4dd1-a396-954255ef7fca"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fc2043a1-8bb0-47d9-a5d2-aad990996bcc"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 31, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("794e6119-9d85-4712-8f18-390dc1c26946"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4253a297-c30d-4b46-805c-017bf4b5f3e1"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d7c0a250-2717-4520-afed-876ebbeb48f5"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c65005fb-983c-478a-bfd4-b9b8748b6b4f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a5d21dad-6579-40a3-8dda-2ffec5dd3b5e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f0281dff-41b2-4dd3-aede-ea5062506a7e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("11368d36-63f4-491c-a5fd-35899cb3139e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fec2663a-79e8-4897-98c5-2f8761b08b3e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 29, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9ae30f04-e8d0-457d-86fb-9542201190c4"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ead44cce-6a1b-4c6f-8e31-60ca62c5dcbe"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 27, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("66f1463f-dc52-4929-ab9d-65c7a5f564ea"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8523bfd4-c893-41c9-bebf-323eedf7c672"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 26, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("93c8b170-968b-4819-bb6e-65f2919d987f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d650ab90-958c-4120-a0dd-0c048c02fab8"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(6125), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2b689da7-0d01-4e9b-9390-6d43a6a30465"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1b378d48-63d0-4b37-be30-a660fe5e7045"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b7a1dacb-c78c-4d08-8210-39839947b2eb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3dee5fc7-76ee-4aa7-83ec-427cc02e01dd"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7d8b1016-5acc-40ba-a530-f8ec5d78df94"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("734472ec-d9ea-4d0b-8e86-20b54881218b"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fae2a328-8103-4917-8652-402e3f516168"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cbfeb1c8-f107-40da-acbc-f05737aa1177"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 23, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4bf3ce5f-38ba-480d-be98-bfbf55ab6e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("067cc350-29bb-442e-85cb-2be4069fadca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33009fc6-ad4b-4b78-a695-87aae49375ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b5cbb7c-a008-4674-9579-e7fdf5e875c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("190201ff-a9eb-4576-9c93-2f31546541d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6a91df4-a15b-4aeb-aa72-42ded71930cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 864, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afc33b99-5df0-4049-baec-70fe9eaf1d63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afe3f8f1-2f2d-4228-9577-5c0ce0765f0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c83aab5-cb3d-463f-9485-e3b2787bad02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("414446c7-ae04-4931-81a7-7e94b32ae5e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e71b29b8-876b-478f-b391-261f0eb12c41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("934d8cc6-e94e-44c4-83c6-e07c7022b074") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2677b1e1-7298-4426-aeb2-69b0e49d2a5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 3, 30, 0, 0)), new Guid("847ca583-72b7-4858-a8e1-53c4da9d99d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11e1ffe6-5431-4660-9b52-c95af979072d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df90271b-5a92-459c-9947-2d1c1521d8eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("441dc90f-1d63-4843-8990-dd6bbdc21100") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4499), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4598faf1-42e4-4662-9b74-79ca52f7a130") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4503), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e951a42-c33b-4d00-9719-c5e11ea9241c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e8287b9-c56e-4f4a-8498-16e6dae973e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("36013ff1-708f-42ac-b195-e0b68f5b1b78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1240), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3e9c0c0-a3b9-477f-a234-a34b9c7b6d0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f41e5e5-d52e-4f79-ada9-bfe1ccbf8346") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fd0fc8b-48dc-449d-8efa-b61d2e0daa57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9f33820-9b25-41bc-9a51-6917fb5f864d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 3, 30, 0, 0)), new Guid("774e5497-c48a-4604-837c-980d0aa2f203") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01f54e1b-311a-4c05-a6c1-ed4e1d21f13d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 861, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7be9af33-a27c-4977-88b5-2372e03b85d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23b6eb69-f10e-456b-9fd5-be4013032820") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a5887ae-3540-4572-bb49-7151dd7c0748") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9c7437e-cb02-4677-8450-d776d6f49ea6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18fd424c-adeb-4e97-8e8b-39f00d816b0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2783ad86-f92a-460b-ae06-f33dd56de24f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba259b5f-4b9d-4662-b577-5ce48c514ca8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7f05707b-8483-4774-ae2b-a9715606b5fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("97f8cc6a-ed1e-47b6-a769-bc09363cf2c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6554), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6645a588-e9d1-4fa5-8579-7ae31dfcf676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c52e62c9-494a-4001-89e2-d09ad7ea559f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dcda295-4cf1-40ca-a185-e8ff0e5f3006") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(8421), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18319d17-d032-4f7e-a291-89908f911ec3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13c2f612-78db-443d-a0e9-124d92f33d8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85ec6385-d7f5-48c0-880a-4238556d70d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e1c22c1-1b34-4874-9550-fe6662b5ca58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad666407-3f96-4916-888e-5736c5331be8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e16ddf2f-acc9-457d-b636-8dd68a6ca560") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39b4dd0c-db98-4aae-94f3-c5fab06a2c82") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96d3409f-c3ef-4610-a940-1235c05a8a87") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35807aff-5252-4160-8fbc-a56b7f2eb7df") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc2d6cc2-318f-4b32-b332-c65ab7ce188f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 861, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0fd768a4-9dbb-4f7e-a8c3-033de3feca30") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4d93751-0b63-4aa8-8f9a-f35825e80808") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(4505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69a890e3-2749-44b8-8755-591007bf6fd8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 860, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fb61b09-8300-4b0b-91da-64388780d19e") });
        }
    }
}
