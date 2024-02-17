using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class removeConditionsFromCaseAndWorkitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Case_CaseId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_WorkItem_WorkItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_CaseId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_WorkItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "CaseId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "WorkItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("96dcae17-455e-4351-a482-5fc2ed41d249"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fb03bea7-392e-4cae-aafc-fe31fbeceef2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 240, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e86de050-c56e-4002-ae60-743b86785380"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d91ff64e-8446-42a7-9ba2-ad3b1f634145"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cf7e87e9-ba95-4a0b-9408-50df365fa0be"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("82752d2c-d9e5-47e1-a0af-7357e3b8b537"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8f61b3f7-ce91-4644-9a48-f53f5a0c6e71"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("23d18597-0c14-4bf0-b2ed-e6ee77c56818"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c479c30d-32f8-425a-9d2b-08d79544ef3a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d9badfb6-b809-4fac-86e8-20b96eec83e9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2f853ad9-2da7-40ca-8aa1-7b042dba24c1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6ebf0c00-ca55-4ed2-a104-29d30f637f31"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(1917), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2a1846c6-e392-4dd3-948a-984d47e386b9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2203f8ff-a77b-40f3-910f-320430f0346e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e7c5be4c-8fa2-4c67-887e-54ac85e565da"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("13f37586-8943-4cc7-9773-564866e22db4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cedef71a-6adb-40c4-8e21-fd53c749e7bb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("133d34ba-8a95-4b59-a8e5-386c12abd5f8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(3843), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("861c2d1b-28f5-4a28-b264-45b4041eac54"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8e2d4358-b2f5-428a-b23e-b13a9da1f98e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(9690), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f07ed5c3-5dda-4457-9d9c-6d00029e805a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aaf053e9-5361-4208-8b8d-e3eb4616e56e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(149), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("51e03d9d-1ad1-4373-afbd-ff84db17e1f0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d38ef06c-20e4-4077-b217-d896c9c9f722"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("710ff979-fd4c-4ab0-8e71-3b7d2d83cebd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("83989007-202d-49ef-a2e8-19b8c6d96516"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f4d11d52-b766-4a8b-802a-d09d992ad0df"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("99f3d322-cb5c-484e-9361-0380f9bc61ad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("baa6eb2c-e877-4b3c-af22-3f68547eaf5b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("701b58d3-8f7c-45f0-9558-b87bf6e81468"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(9609), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a6834d90-078f-4a97-91d7-bf4cb924c133"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("47c2fc25-3c13-4808-9908-361a90802a4c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(257), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ca0236b3-a92e-4a46-ad63-aaae2d2f05f0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c0aaa4de-bbad-4e11-966e-3a446126ca62"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(6162), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4cdc805e-7cea-4499-a71b-33104223ecd3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dcb490be-f611-4534-af5d-1ba776867059"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(4268), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(6477), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e57f6a3b-e75d-46e4-b0f4-b9af0deaa205"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b9c02240-a25b-4f58-b740-b3d8efc8dca1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("873fb05e-f68a-461f-93bf-996e1b40780e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("00e6ecf7-9c0c-4527-bd13-9013df859840"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8624d4ef-4abf-4bd1-b1c8-940c39ae6628"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a3b55eba-6360-4196-b362-8ea12524c900"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd9531cf-3539-4081-b669-0ba50063637b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aafe212e-4210-4e11-9e1a-384b63456c36"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aba62d4c-c6ad-41cb-aa57-81615a773276"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d626a238-4cea-468f-a150-12e474cd2c00"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c7bec201-ebea-4204-9f31-e75a1550a48e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("de57c447-f8d8-4ab4-becf-67ad25bbc25c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(3293), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "L_CaseCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("9de41e79-c71a-4cf8-aa7a-352721102188")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_CaseCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_CaseCondition_F_Case_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_WorkItemCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3c866a26-c01a-48f0-b273-f0620c0dfd29")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    F_WorkItemId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_WorkItemCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_WorkItemCondition_D_WorkItemState_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_WorkItemState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_WorkItemCondition_F_WorkItem_F_WorkItemId",
                        column: x => x.F_WorkItemId,
                        principalSchema: "Facts",
                        principalTable: "F_WorkItem",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8175), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a6ec43a-6a86-460f-98dd-f328fa1e907a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b0f5237-fdf4-4b70-bef3-af67345be62f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a6ad507-1e66-4252-a485-cdf9f147677d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8194), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1ac6c87-60d6-4757-95ea-527d214cb42b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bfc1d4e-8145-448e-83c9-7880b26e30b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(8205), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8925cb1-d389-4cb2-9549-d8ccafaaa3e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 107, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7571db8c-5587-45e0-9875-ef1f6a4754f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02ed79e0-6bdb-4ab9-b2fc-f3fd50f72106") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64144fdc-24e8-400f-beb3-a50c094b63b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9228), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1410a171-ad57-45d4-886d-4237fca7deda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9235), new TimeSpan(0, 3, 30, 0, 0)), new Guid("849a58d6-6d8c-4d03-8723-efbfc00d1317") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50dcc8af-85d7-412e-9b37-f29d51bb69ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de3665f1-e1e0-45e6-90d6-09d1cf06fef4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42add623-dbe4-4ecb-9681-1d3c3368c6e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9315), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e69311c-6c26-4b14-9442-7f4b57a0bf84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3b67348-bee0-47be-b4a5-69b26668cc56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9325), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a168fbd-d109-4579-b406-d1831cde1896") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9330), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d66af6bf-3472-4cdd-81eb-9ca06e2b4a46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9334), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7fcffe09-aa0d-45fa-908a-bd99295d3fad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 108, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cbc508bd-02b5-4c56-a669-8c20a2b4c3f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e33a33e-c403-4891-a299-cda055c8776a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8b97602-bbcf-429a-9a18-d867d69bed7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5eccc5f-df6b-4f01-9dbb-0cf5a2f00f15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1899), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ff11acc-23c6-4ef0-aeab-03d576230bf5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1929), new TimeSpan(0, 3, 30, 0, 0)), new Guid("257da42c-2db2-46a7-9286-7a3755e9768c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a35eb112-05ab-481d-a05b-d17cf8b4036c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dcff6266-3cb1-482f-9e46-15e49de57606") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b16cedc-2ebe-4b11-adcd-7c515d19b24f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af8abcf3-2e0a-44de-acea-ce995aaa7e3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd4414ab-d722-4985-be59-1e1369eef5eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d07b8ce-f604-4723-9c60-a7052052b898") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6168dea7-db60-412f-90d1-6b27682284d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("848530fa-8328-444a-bc9e-4f6fdd58745a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b70e7926-e7ed-430d-a234-18918839c702") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5c72cbc1-a099-463d-b996-a205feebb5c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("343c2dfd-535b-4575-a4d7-6e37554d98c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa895dd9-cec9-4d0a-8923-63d34cf93054") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65755aa8-4da3-462c-9473-2bc3e1033aa3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 109, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30ab9655-e5f5-4abb-9806-120e4d3ed2a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf339011-f224-4950-a95b-e6f568e7e794") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3c6a779-831b-4bde-858a-7a34a2a37b42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(2701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("746ed48f-3e2c-442e-bf5d-41b33be7031a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d42ce7b-e64c-4958-a009-38029ef84362") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ccbffdb-edf9-475f-a73d-cc2d216a39cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 110, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 3, 30, 0, 0)), new Guid("677f17d5-e243-4c6a-85a2-dc91126bc822") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee79911f-46cc-4ec3-b76d-cbe70e26b976") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa3123cd-2d50-4b20-b938-f3113939a78a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 106, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58d29d98-1501-4a10-b860-3ce140d9122c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 105, DateTimeKind.Unspecified).AddTicks(8633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a2b7ca7-bef5-4a7a-ae97-4464b371aaa5") });

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_Created",
                schema: "Links",
                table: "L_CaseCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_ERPCode",
                schema: "Links",
                table: "L_CaseCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FifthId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FirstId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FourthId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_Name",
                schema: "Links",
                table: "L_CaseCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_ThirdId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_ERPCode",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "F_WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FifthId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FourthId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_Name",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_ThirdId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_CaseCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_WorkItemCondition",
                schema: "Links");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fb03bea7-392e-4cae-aafc-fe31fbeceef2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("96dcae17-455e-4351-a482-5fc2ed41d249"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 240, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d91ff64e-8446-42a7-9ba2-ad3b1f634145"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e86de050-c56e-4002-ae60-743b86785380"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("82752d2c-d9e5-47e1-a0af-7357e3b8b537"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cf7e87e9-ba95-4a0b-9408-50df365fa0be"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("23d18597-0c14-4bf0-b2ed-e6ee77c56818"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8f61b3f7-ce91-4644-9a48-f53f5a0c6e71"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d9badfb6-b809-4fac-86e8-20b96eec83e9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c479c30d-32f8-425a-9d2b-08d79544ef3a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6ebf0c00-ca55-4ed2-a104-29d30f637f31"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2f853ad9-2da7-40ca-8aa1-7b042dba24c1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 485, DateTimeKind.Unspecified).AddTicks(1917), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2203f8ff-a77b-40f3-910f-320430f0346e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2a1846c6-e392-4dd3-948a-984d47e386b9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("13f37586-8943-4cc7-9773-564866e22db4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e7c5be4c-8fa2-4c67-887e-54ac85e565da"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("133d34ba-8a95-4b59-a8e5-386c12abd5f8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cedef71a-6adb-40c4-8e21-fd53c749e7bb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(3843), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8e2d4358-b2f5-428a-b23e-b13a9da1f98e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("861c2d1b-28f5-4a28-b264-45b4041eac54"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(9690), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aaf053e9-5361-4208-8b8d-e3eb4616e56e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f07ed5c3-5dda-4457-9d9c-6d00029e805a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(149), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d38ef06c-20e4-4077-b217-d896c9c9f722"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("51e03d9d-1ad1-4373-afbd-ff84db17e1f0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("83989007-202d-49ef-a2e8-19b8c6d96516"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("710ff979-fd4c-4ab0-8e71-3b7d2d83cebd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "CaseId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AddColumn<long>(
                name: "WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("99f3d322-cb5c-484e-9361-0380f9bc61ad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f4d11d52-b766-4a8b-802a-d09d992ad0df"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("701b58d3-8f7c-45f0-9558-b87bf6e81468"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("baa6eb2c-e877-4b3c-af22-3f68547eaf5b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(9609), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("47c2fc25-3c13-4808-9908-361a90802a4c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a6834d90-078f-4a97-91d7-bf4cb924c133"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(257), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c0aaa4de-bbad-4e11-966e-3a446126ca62"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ca0236b3-a92e-4a46-ad63-aaae2d2f05f0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(6162), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dcb490be-f611-4534-af5d-1ba776867059"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4cdc805e-7cea-4499-a71b-33104223ecd3"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(6477), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(4268), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b9c02240-a25b-4f58-b740-b3d8efc8dca1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e57f6a3b-e75d-46e4-b0f4-b9af0deaa205"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00e6ecf7-9c0c-4527-bd13-9013df859840"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("873fb05e-f68a-461f-93bf-996e1b40780e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 482, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a3b55eba-6360-4196-b362-8ea12524c900"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8624d4ef-4abf-4bd1-b1c8-940c39ae6628"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aafe212e-4210-4e11-9e1a-384b63456c36"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cd9531cf-3539-4081-b669-0ba50063637b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d626a238-4cea-468f-a150-12e474cd2c00"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aba62d4c-c6ad-41cb-aa57-81615a773276"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("de57c447-f8d8-4ab4-becf-67ad25bbc25c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c7bec201-ebea-4204-9f31-e75a1550a48e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 481, DateTimeKind.Unspecified).AddTicks(3293), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de6537bd-2b0f-4df8-a1cb-077dfb369ece") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 3, 30, 0, 0)), new Guid("330a4e76-b63d-4cf1-8b00-44f47b6edf2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc987f44-ce7f-4368-95f6-05ab978283d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b78bf7af-c37c-420f-b565-e501e003608e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48ebfc3f-d797-463c-9267-9f2872257839") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f280e1da-ab42-4bc4-8004-12f2624e0326") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 889, DateTimeKind.Unspecified).AddTicks(1798), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16a878d6-720c-438f-b44d-fba2e80c0dda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 3, 30, 0, 0)), new Guid("517a3ae3-b8c8-4798-b436-316a1004b160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1283), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f13bbb8a-0622-409d-bb1a-2550063c9a46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69bee783-60c5-48a8-8383-b0dc834e66ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1297), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dceffe2e-02bf-4c76-adc9-799429d91ebf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 3, 30, 0, 0)), new Guid("899b6546-4d4b-4c4d-b027-b7ca5a7a121d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1364), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92eb7a6b-6ca2-4b7e-b91e-0ff9b55b6469") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ac6c01d-31f7-4822-b7bc-9e07a5483dd6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c2693525-c5f6-4c9f-9082-40fca89e5528") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ee9d1d9-fa2c-41d5-b57b-c024610b768c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 3, 30, 0, 0)), new Guid("390536c0-a271-43ee-8c39-d33367b17a44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf4ce668-6a50-4729-b3fa-abc152b5d0e9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ae4d754-6a71-4848-b8b0-ac2f3f504cb5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18b85a95-9e52-49df-ab53-4875821ed29c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3692), new TimeSpan(0, 3, 30, 0, 0)), new Guid("22bba782-487f-4970-a34e-bb88d6895fc3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86781f47-8335-4604-acee-73a7a7ef6f79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0c2657a-227a-4684-aa0f-1d34dafb7fdb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77ca4157-3118-4971-9e02-9e1f6b4ae510") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5108f08-ea6c-4f97-83e2-383f103b5fb8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a0e564a3-a59a-40da-ab94-fc108c10bacd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c4fa5eb-e06f-4c48-81bf-7374cf2e992a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a0ba6956-76af-426e-b1ae-39a86f6f7830") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2609be9f-29c5-4a1d-b0e2-ecfa40f9ac1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfd7030c-fca3-48dc-9073-b9fd6399c7ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d94319f-a97c-4cc0-9618-a67fce7e213e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c462975b-7a0c-49f4-afbe-6803f0837018") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bfafb2c-077f-4f7b-8927-6ad22b8d83bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23c24cc6-574c-42a4-aaf8-8e61ddc8df6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9828), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b66ccb3-1174-4472-a77d-2d3701cd6688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edc9b812-68d2-4bb9-8514-ead27984cf85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9237), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b43b45a-f0e3-44c8-af55-1e286974d9f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9240), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31f8832b-5d45-45a1-9e6c-fc9dcb077cab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd872ed1-0c92-4a40-b445-460e75a38ad0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(2856), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ddc3d9ca-a3d8-4278-919e-89e9faaf1740") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5558c921-d99c-4930-a184-cd31562bb6a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e4b049d-39e2-49fc-b5ce-bf9b3f45db15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d18515be-7712-4922-b2c2-683fc79be620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c72d9c35-fe9f-4db1-a2b6-65a8be81516f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04748a88-e7b7-4dd7-9b30-f1828ee267af") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 887, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, 3, 30, 0, 0)), new Guid("94661983-1577-445c-aa29-cd0221b9b461") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(186), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3cde28cd-65f1-45f3-8714-3288f6cb9ce5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f710fa1-a36b-4acf-9bcb-f3fae2bc45f1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 885, DateTimeKind.Unspecified).AddTicks(8157), new TimeSpan(0, 3, 30, 0, 0)), new Guid("286fc27c-ed8a-4d5b-852b-7ea57c40507b") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CaseId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "WorkItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Case_CaseId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_WorkItem_WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "WorkItemId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id");
        }
    }
}
