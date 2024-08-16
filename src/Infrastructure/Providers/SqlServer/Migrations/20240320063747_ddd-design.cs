using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ddddesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("59aeb0bc-8f47-413a-be64-20948c491881"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("0a200b5c-4b5d-45c4-8f71-e0c12595356d"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 39, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("3c10a7eb-4e3b-496b-93f7-1acfbad39d4d"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("4efe093a-7815-42fc-8e65-b91a728c810f"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 38, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("c36a8848-3319-431d-b708-039173d71726"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(6482), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("0d746cd0-25c8-4fb5-972c-3ed798a049ad"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 37, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("753abb5e-2dcf-4cad-8969-c6d0b626d306"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("27b76279-8e48-4352-8b6f-690b6a10467e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 36, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("21386b53-eac3-4feb-bdd6-8164e2ea679d"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cb37de6c-0547-40eb-a643-fa403cd5366c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 693, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 35, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("eb66fbc8-98e6-4ad0-ae68-254ee982586e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("28387c9f-05b0-482c-a3c4-c87b67252b4e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 34, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("37cd2f8b-287f-415a-b286-6254859cc1c6"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("9d92203e-315d-43f6-a7ea-59cd01d9bf8c"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 33, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("24df1c02-0fbe-4e5e-8867-9f3b033dc0a4"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("c7f0522e-1c82-4eac-9233-bbb3b404a361"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d6e9541c-27fd-431b-bf8a-96093ff43285"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 684, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 32, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("fc2043a1-8bb0-47d9-a5d2-aad990996bcc"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 31, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("4253a297-c30d-4b46-805c-017bf4b5f3e1"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c4c9eb9c-94f5-4990-b2de-e45a87e1db41"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 679, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("f0281dff-41b2-4dd3-aede-ea5062506a7e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 30, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("fec2663a-79e8-4897-98c5-2f8761b08b3e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 29, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("ead44cce-6a1b-4c6f-8e31-60ca62c5dcbe"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 27, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("8523bfd4-c893-41c9-bebf-323eedf7c672"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 26, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("d650ab90-958c-4120-a0dd-0c048c02fab8"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(6125), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("1b378d48-63d0-4b37-be30-a660fe5e7045"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 25, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("3dee5fc7-76ee-4aa7-83ec-427cc02e01dd"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("734472ec-d9ea-4d0b-8e86-20b54881218b"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 24, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("cbfeb1c8-f107-40da-acbc-f05737aa1177"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 45, 29, 23, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d2bb422-c7b9-4656-8149-ded351528db2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e4af065a-c4ae-4da0-ad90-7f760f9b1fc5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d067da0d-b41a-45d9-9206-3eaf9e12999d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7535), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08286a22-f133-4427-b8f8-47db32a7cb64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d7ad963-2532-4887-bf1c-cc4790bb3114") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1699da6-abb0-4784-9ce2-5b2fb289df6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 723, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33ed249c-ccac-4039-8a32-785f335379bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41fd846f-e0de-4730-a2de-42c117f7c8e9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b660057a-213b-4607-a723-af92b304290b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eafa7a70-5ce3-4677-81db-5ba5d0f20aec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77963f75-3f7c-468a-b8b3-2561cf86b04a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04ec113a-44cc-43c1-80c8-46d0331830ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42e2f6e3-5aa3-4fdd-b911-f75e0c7c7af2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4e07f06-6e4c-4a1e-8956-78053b31e2e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("028c3ced-11c7-45d1-8a18-32168743626d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 3, 30, 0, 0)), new Guid("684e9232-9bcf-4e78-b82c-5f5dc0e70ac0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e28591cd-4be2-405c-8ab2-4995fc5fe85d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7f162b8-51a7-486e-8b8f-595efff13fc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1d6a2f4-b309-42f4-8384-1cf03d03fea9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eeaebc63-1c24-4a6d-b80f-177349b22c3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 724, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2077b94a-e167-4757-936f-2d3cdc7e81ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e620cf9a-895b-4d96-a091-936267d8da97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6f634e9-75ae-41c3-a898-be1214410d8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d9eb76d-1c9c-410b-a65c-e6995ca2f0ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee04301e-b55a-43dd-817b-9094027555d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8272073e-7d00-4986-89e9-84fded0f8057") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca1eec58-20d4-471c-ace8-b0595dc37c96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 717, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0e1682d-eac4-4c45-b194-4b01de538b2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 719, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b2bd6d0-5a47-41c6-a72a-0c9eda6b1c93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("394e0d23-314f-4716-a6f7-ef157f22d199") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 3, 30, 0, 0)), new Guid("53b8ab46-ebb1-467c-84ff-5284c9df90bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba52a109-07ae-40d0-a6bf-34308fb152b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04f6dad0-d79f-408d-bfbe-76f51a5debda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b16e5a4-c053-4fd8-96ca-adad22f3c2ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(2388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("212bef65-5cc8-48d2-acaa-775c8bc5c0b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1342), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08389e94-e030-4d29-80b2-fc5feb3ea2d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0fa3dea0-51bf-433a-b37b-62ee24aca2a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa10277d-700d-4105-a567-6e365b43ae54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e41dfec7-8a33-446e-86b4-818f93e8e354") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(2938), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d69cd4e7-e1ae-4dc5-9ead-4dba3857432c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 3, 30, 0, 0)), new Guid("764ac60d-2b68-4d66-b1ad-37160e308fce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6bca60fe-2b80-4f20-a41d-6f9cc1ce9822") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a42202a-0b2d-4dde-8e46-520e85e917a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 3, 30, 0, 0)), new Guid("318564f2-d199-49ab-bb78-4fe5af0b40a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 725, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9cf2a053-dc78-4668-b86e-c8dce2e4ad98") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 719, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 3, 30, 0, 0)), new Guid("584329ab-3b6e-43e0-ab26-1fbadc472bce") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdfec767-bb14-4e5e-91d8-c2243a4a0730") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2c106eb-31e3-46c3-8baa-1a264bcc4332") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 720, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4198fca-4251-43ac-8278-c893bae48567") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 717, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3acf63f-d8ac-41b5-bd2d-4c0ac6c6d816") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(3938), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d00d1d2e-aa25-4a9b-bd00-8fbff7b60556") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 721, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 3, 30, 0, 0)), new Guid("777f0b10-7483-4ac9-87e5-0da59fdf77bb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 44, 716, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e56752f-a77e-4362-b78f-1947ce65177a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("ed2e8e0c-5d3f-46c8-a9e8-9b0e7d291123"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 706, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("41e8af51-f468-47bc-924f-5a6716689c99"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 705, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("cff16211-98d9-448d-bc6a-82427fc6119a"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 704, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("d9a844c3-cb3f-45c4-9292-29b0c988fa04"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 703, DateTimeKind.Unspecified).AddTicks(169), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("d26f2d8d-3fbd-463c-bc64-0c419feed634"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 701, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("39642d8c-4d8e-4e56-b613-9ecda1d116b8"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 699, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("fc9a6adb-2023-4251-842e-5f9eeb42279e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 697, DateTimeKind.Unspecified).AddTicks(3282), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("647a2d48-0c3a-4e4e-9f15-6c7418514c32"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 695, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("244956c9-1575-4d4a-b20b-495e79a4e88c"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 694, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("cb37de6c-0547-40eb-a643-fa403cd5366c"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 693, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("062534f3-801c-42a2-ade7-a2bb4fa31374"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 692, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("05bf4d92-3017-4159-95fb-545d4f859bbc"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 691, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("185ae323-6932-413b-b4bb-2799906cec3a"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 689, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("f8e9406e-1f6b-4ed2-9779-3a685a72dff0"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 688, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("3cba603f-3f34-4494-9cf1-4289460bfbac"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 687, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("567c43e5-e29b-4e54-a2aa-154f7696803b"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 685, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("d6e9541c-27fd-431b-bf8a-96093ff43285"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 684, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("d8ff502a-ae9c-47cb-8ca4-bbfdca3e86b6"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 682, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("1e885441-6c33-457b-95d5-9ee8e3bf1e50"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 680, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 3, 30, 0, 0)),
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
                oldDefaultValue: new Guid("c4c9eb9c-94f5-4990-b2de-e45a87e1db41"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 679, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("6cb7f942-f3ce-4790-9d55-2f61612dae8b"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 678, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("84ea5d5c-f884-47ff-a906-4d1a0f176271"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 677, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("ab659fe2-e26d-4616-8c0f-bb93b6311c37"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 672, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("703eebfe-f5c9-4ad0-8d71-c177289c143c"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 671, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("26947d7c-4bad-4138-bac5-e188f8600a67"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 670, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("3b440068-5869-4bdf-8646-75b31a8f928e"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 668, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("4ae4164e-0dea-416c-a7b8-1fce7dd63cd5"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 667, DateTimeKind.Unspecified).AddTicks(3222), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("5a8114ea-e452-4503-be74-3a0d0382405d"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 666, DateTimeKind.Unspecified).AddTicks(976), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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
                oldDefaultValue: new Guid("0719d2a9-2f0f-442b-aa74-2eef877809f5"),
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 20, 10, 7, 45, 664, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 3, 30, 0, 0)),
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
    }
}
