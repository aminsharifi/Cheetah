using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Fix_WorkitemCondition_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_D_WorkItemState_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_WorkItemCondition_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropColumn(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b867885f-ecc4-4e62-8887-95753c2e6085"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3c866a26-c01a-48f0-b273-f0620c0dfd29"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("40e7eac0-7021-4117-b4bc-760e3b6ef4e7"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("eb9f015c-365f-41b1-8ea0-93b7298ed190"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e9063c71-e94e-489d-8a60-2445f2c8103d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("79e49fbb-59d1-4ad3-a508-7a3e27e13b50"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("10b9ed0a-f300-4559-86c4-03aceeea1b33"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7bcf7a07-ce69-414d-ad8d-218d0df6e78b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("152e83d2-ece1-437f-a953-0f9e4ac0412f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("56efe08a-27ca-45b2-8bde-6c0e866a2b52"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("70761dfa-593d-4bbe-89ed-d970440015a7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9de41e79-c71a-4cf8-aa7a-352721102188"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("392aa8a4-d5bc-47ba-8ed3-3293f4162e0b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("33c9cfc6-5d35-46a0-b41a-39c316e437af"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3047b26c-1e4b-4325-a399-f5ac73454c1f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("02d7f842-ceef-4c8e-b015-56ba4a2083bf"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(7296), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c738ba93-bce7-4836-82da-8a9414a8d6a0"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 483, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("42959372-009b-4478-81a5-f7eeb8acd59c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("d5f34990-b71f-44a6-83c8-fc1117e69d77"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("6a60f59e-45a9-4f5f-9ea7-5f66cf6ffc0e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("a880bfd1-db0e-40bf-b0a4-56506e222049"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("aeeb6630-e372-45a1-914d-a10864244fd1"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("30b86211-62ad-4065-8040-4035bdacdaad"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("8efe853d-028b-46b9-b538-277f7d3d973d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("9d38f106-b853-4e72-b43a-9cb1c83f59c8"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("b15e5845-4545-4b1a-9219-a8711d1bef86"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ce44efb3-1d84-4118-a604-6bd2dd6aba19"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3416c88e-c6f7-482c-a2a2-e469d1d10c28"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 3, 30, 0, 0)),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("846a9619-613c-47c9-b25b-eb7be56a2962") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c78edfef-d62e-41e8-8b54-a7135e7d94a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96f5111d-c7ab-4870-beda-a6090688f2d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2115), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d1c119d-1dc7-4d72-be23-b9f2ad444cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4806a3a-2399-468c-b09c-ea2fb928498b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("955bbfa4-726f-416f-93cd-d2a0d6cd8e5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(9400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a992407-8c19-4730-9c79-acf9c408b128") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00dbe9cc-e07b-43f2-ac61-3c9f6da19775") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a68274a-3cbe-406f-bf1e-f5d3f71db8a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd0fb31a-9c9c-4b58-b61a-ba247b676bb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed17b4a8-d2c6-49ce-a6db-f981d0cf9c14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f045466-aca8-4ad6-88fe-527bf9363833") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b805ab7-ad79-41e7-9e48-90bdf6a8a424") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f203a8c-bdb6-468b-9fe0-63ad7bfc4a7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9244), new TimeSpan(0, 3, 30, 0, 0)), new Guid("306660b1-b3a4-447c-b84c-f88b2733fef2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("207e037f-ef44-4467-ad16-5448aa2d9c4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6b271e87-704f-4707-aed2-7ed3cc4eb7ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ae36a2-26db-416c-a45f-8c3c55d9eb5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93828b85-af29-437a-a3c0-61c6f6e11f30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0085e6bc-79fb-4ee3-9899-acf77336484a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fed69ebc-8203-4971-a98a-f9a27ef8333a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1482), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3c394a8-6c46-4e82-a019-84fd480e4561") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("746a3528-8064-46f4-8232-7ee223140b6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55ccb56d-3faf-435e-bcd1-7bbcd473d75d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d0227c6-d6e8-4069-ac2b-69fa49d7ef5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e89e46b3-5234-4531-aea8-0c51142d5a95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d952c78-aee1-457e-8942-3fae74c7b683") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1dd6f7d-8da4-414e-ae3a-4174d1b354cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c61d411-129e-4188-8e7a-8e4b0638ce64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 30, 0, 0)), new Guid("423efe56-4f73-49d7-a8d1-a8ce82d8bf7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31f9def6-2cf8-4f64-9462-40645edcb64d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd3f39b9-142f-41ee-85ee-05c11d880dbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 3, 30, 0, 0)), new Guid("544265e7-07c4-492b-8fc0-4c1701df06c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7464), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a5e2718-5a21-41a9-ad2b-46eec9357c32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7731186e-760d-46ba-9e4d-efe7cb72dd3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3c2342d-ad53-4851-b114-06d46002782f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0133bd33-536e-4d51-bf03-3e6f9d3353f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("acaa5841-bbe3-49c1-93e5-8785226cf5f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("263e43a2-6984-4b24-8fa8-edce01ce45b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82d6aeb1-47b1-4702-a302-5f8b85fac49d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4aa7bb5f-3e0d-4a6b-badd-8dffe4241cf6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6cb8774-973b-43b3-af0c-10c2502f9a8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9aae0277-fa98-4a8a-8d35-0fc3512de336") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d1afa53-4b09-4466-a0d9-ee6930dd745e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa7abb27-0cee-473a-887f-b1b7fbb3eb50") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 480, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3eebcebc-427a-4569-b5e1-2a6c4e29c37b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac786ab9-6ab8-40ad-b51d-88ad752934c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0e9dbc3-21c5-407c-b143-fccad4a97318") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 480, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d0abc78-dbb6-4692-a7e0-b86d09936fcc") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3c866a26-c01a-48f0-b273-f0620c0dfd29"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b867885f-ecc4-4e62-8887-95753c2e6085"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 486, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("40e7eac0-7021-4117-b4bc-760e3b6ef4e7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("eb9f015c-365f-41b1-8ea0-93b7298ed190"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e9063c71-e94e-489d-8a60-2445f2c8103d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("79e49fbb-59d1-4ad3-a508-7a3e27e13b50"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("10b9ed0a-f300-4559-86c4-03aceeea1b33"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7bcf7a07-ce69-414d-ad8d-218d0df6e78b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("152e83d2-ece1-437f-a953-0f9e4ac0412f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("56efe08a-27ca-45b2-8bde-6c0e866a2b52"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9de41e79-c71a-4cf8-aa7a-352721102188"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("70761dfa-593d-4bbe-89ed-d970440015a7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 14, 33, 43, 484, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("392aa8a4-d5bc-47ba-8ed3-3293f4162e0b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("33c9cfc6-5d35-46a0-b41a-39c316e437af"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3047b26c-1e4b-4325-a399-f5ac73454c1f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("02d7f842-ceef-4c8e-b015-56ba4a2083bf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(7296), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c738ba93-bce7-4836-82da-8a9414a8d6a0"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("42959372-009b-4478-81a5-f7eeb8acd59c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("d5f34990-b71f-44a6-83c8-fc1117e69d77"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6a60f59e-45a9-4f5f-9ea7-5f66cf6ffc0e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a880bfd1-db0e-40bf-b0a4-56506e222049"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("aeeb6630-e372-45a1-914d-a10864244fd1"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("30b86211-62ad-4065-8040-4035bdacdaad"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8efe853d-028b-46b9-b538-277f7d3d973d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("9d38f106-b853-4e72-b43a-9cb1c83f59c8"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b15e5845-4545-4b1a-9219-a8711d1bef86"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ce44efb3-1d84-4118-a604-6bd2dd6aba19"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3416c88e-c6f7-482c-a2a2-e469d1d10c28"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 3, 30, 0, 0)));

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
                name: "IX_L_WorkItemCondition_F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "F_WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_D_WorkItemState_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
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
