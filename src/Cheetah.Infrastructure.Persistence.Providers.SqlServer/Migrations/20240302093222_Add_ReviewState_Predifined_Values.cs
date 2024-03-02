using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_ReviewState_Predifined_Values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("be810918-3990-4a84-995a-dd81a5664b4c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("72756592-349c-4015-a98f-93a0f482f90c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 65, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3edc0e68-420f-4cbd-8fa6-4120cafa5441"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dfd50f34-6a78-4cd4-94f2-fdb52bc0cfbd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 64, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3f39cd77-1ae1-40e0-8775-a6a08b9899d4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1cb03fff-5fb5-4e09-911c-b97368a718d4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 64, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(2383), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("78f8f4f0-21cf-4553-b66c-0e9648902f54"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("34899122-022b-4195-a412-47084f2aebba"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 63, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ccb23aaa-398b-415c-a1a0-12d21357fb5a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("193ee31a-e8bb-4345-bdc7-03223d5e6095"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 63, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("98c074bf-0e41-47b2-96a4-a1bc40cd17a1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("276a78b8-a6d6-4a74-93a5-70c8a1fe70f7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 62, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(5962), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f829ca84-98ab-4483-ad6e-25523160cb79"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7fe5f5b3-e3bf-409d-9aa5-5d382be6c28b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 61, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("301e3cd0-4644-4899-90a5-8a8b6b48b94b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eca882cb-fc7e-4b07-b0f2-6c24e5955706"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 61, DateTimeKind.Unspecified).AddTicks(2349), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("813201a2-3d7e-462f-8f91-71adb3304de1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("daafc29f-94d5-45ab-91dc-da399733a125"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 60, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("443423b0-5277-4a13-888e-f7f0075ef792"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5a59712f-8ca9-4d16-9a85-048828ae530f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 59, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("98f1cf25-38ab-4aae-9663-1aeac4eb0b1f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b390c7b4-5cd7-454d-9824-11c0d01ba234"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 59, DateTimeKind.Unspecified).AddTicks(4330), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("797d422e-a95e-449f-a819-be3d67c02bc4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b71cd5aa-a802-484b-a31a-f689544c4145"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 58, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9d5c9cf1-6b93-4d06-add3-280e2b3360b2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("84498a00-dcca-49a3-802c-e327dbee1f57"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 58, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(951), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5df45a42-efa9-4681-b311-2a9952626cf2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e6ffec1f-d788-42f4-855e-0e693254bf32"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 57, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(9055), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e3040cb4-d8cd-4615-8409-8fa0519a1443"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("52345873-4e75-4332-9e82-5b88362d8931"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 57, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c7eefee9-bc7e-4bb5-ba61-ce1cb55ff878"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ae7946cd-995c-40aa-a6a2-6707d8714bf4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 56, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8b7c50a5-816c-4e5e-a643-7c37ad553406"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d8100d35-41d2-45ea-a516-1e34dd802fec"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 55, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("75d21fbc-522b-4075-8948-433da8f5cec4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c622b96b-2bbd-4158-96da-3b8d63c3dbb8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 55, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("14438067-e74e-425a-b5bf-e252747a173d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9ead35eb-3e85-4421-bab8-89cef0df9e69"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 54, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0cb70ec1-5fe7-48f3-b56b-d4d3824ced32"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("19daa0e5-adc7-456b-be58-4de1fe4d663d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 54, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(9022), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4a87b6ea-27ef-4bf3-bbb1-7955e116ee14"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f01f81b1-266b-409e-8407-9fd087051a40"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 53, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e236c1a9-e58a-41fb-b993-e4dfa4c39ed0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("65a7b58e-1b55-4dfa-8abf-302203509293"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 53, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("93f11223-fb22-42ae-b88b-fe67b202d0d6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8dd7c36d-7c22-4d34-ae05-955d270e0a17"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 52, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("80476ac0-b967-4fcb-8863-70be6a14cea7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("05535675-d0bb-425f-b297-7306ece811cf"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 52, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("173522c3-70b9-4169-972e-cd1c26099efb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e1d95b24-76e7-4b7b-93ae-eac4da2ab0ac"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 51, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8f2c9232-858d-4e7d-bbe8-ece8b8fe1987"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("116065d1-e580-4cf8-b4e6-60293ec0f512"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 51, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f06c8373-47ba-485d-b979-a1c339a67099"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("881c4e97-05bb-4a33-9f36-7bd0ca79e3c4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 50, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(5568), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9fc94751-30cf-42cf-a95a-60311a5a033b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9aab4424-3153-4a02-a776-fc1a7d83fce5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 50, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8d8044f1-08c5-4cac-968c-5c45c16c6377"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cbefd562-3051-400b-8bfd-a8840fd7e3fd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 49, DateTimeKind.Unspecified).AddTicks(9513), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8067), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8116cf9b-24d0-4e54-b015-18bb81c4bba1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8075), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8947153d-7546-46f9-b5ae-32c737d9fb3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c14a6d2f-4da1-4aae-afa4-5f612aae5720") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67d8367f-e658-4d79-8887-fdaa0f689275") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85211d83-c285-4ca8-9b12-0fd6594e8537") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3683ee52-4887-455b-b4da-10a0284134a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 379, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4fd53d2-0f11-429b-988e-918bccf4d3bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 3, 30, 0, 0)), new Guid("299916fb-9f90-4c56-8737-48e0c539439f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dcbd8f8e-7da0-4d75-b797-b7c2828a8611") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 3, 30, 0, 0)), new Guid("514c6410-0dc3-40ca-86ba-c299f9eb66cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afad0be1-32ad-4332-a390-647af5ee6edb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d1719aa-02cf-4763-bfda-f4d2d46219f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f203f55d-c7c3-4ab2-952d-f3fc563fa9b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fde780e-95b6-4e2d-9923-faa85a4e87a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91642bea-9fb1-4809-8fab-cff6100e5a26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("87116c49-50be-490c-9d93-6dc2847ae5dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 30, 0, 0)), new Guid("25c8ec75-f9d7-49d8-b590-c0931893023a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ddca3292-852b-422f-b9ec-a22c064bdc08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4d2780a-d119-4845-aef6-39e1c87d169c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3df1e2c-cffc-41f3-8d03-f36900fca15e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d93b23ec-4670-450f-b10a-ec314481d1b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2c184a32-8ca9-4544-9166-b31ed8c990b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df78af22-f706-498d-9ce2-3ac90d66c1bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 3, 30, 0, 0)), new Guid("475fe1c6-e59a-4f66-a16f-06660a4e09a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa0c4d6c-dcbc-46d3-b195-6952fd442f55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f94c7442-e730-4f46-8d46-bc00f9a3ffce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f472b6a-2631-478c-bc90-1fc10111e2bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 376, DateTimeKind.Unspecified).AddTicks(3955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca323566-bb0f-42d2-a3d3-ea5b18a376b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d837233-e45c-4f89-93c9-78c92658173c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2082bc7c-f0b7-4413-ae37-8cd8992327fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1d0f3d6-19db-4e1f-88b1-90ce25d811bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7546), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb8a40c4-cb4d-47a0-ad25-21f783086d06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92992052-2af6-4359-b7a5-40403e02674d") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[] { 12L, new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "وضعیت بررسی", 12L, true, new Guid("6452fd2a-98d5-43f7-b2f7-54d7b1c1887d"), null, null, "ReviewState", 12L, 4L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1528a73c-1645-4b0f-b252-ce29f19fac9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7f57d7c-64e5-4ea3-a294-30d140352464") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c90138b9-6de7-4f7e-9aed-8042ba89b996") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c58187b-4f94-4701-aa93-ba9fb9f9dff1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a39380f9-60dc-496b-9fcf-f6b3e437376b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 381, DateTimeKind.Unspecified).AddTicks(8563), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f6b11fb-df94-4740-9962-e8f029fd1f3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 382, DateTimeKind.Unspecified).AddTicks(731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93da6f13-4ad7-4874-9b84-e7a90326f273") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 382, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f21f07a-ff7a-4fd5-8cd5-2a84ec6b07b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 382, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f0fe7c1d-49b9-4a31-9c83-c2be4c5f4da7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 382, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 3, 30, 0, 0)), new Guid("763cd3ed-8a43-4a9d-8297-280aa65c36f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 376, DateTimeKind.Unspecified).AddTicks(5757), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c600c35-fe92-4b4a-8d74-142476af110e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(5280), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f148fcd-70ba-46cf-b00e-453846663d68") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd91e5a0-9261-49f0-a99b-b2fca1949c17") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 376, DateTimeKind.Unspecified).AddTicks(1300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b12eab5a-0b8a-446b-9bbb-989f11a3ec21") });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 20L, new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 3, 30, 0, 0)), null, "  Approve است.", 20L, true, new Guid("ea733f71-5b36-4687-b490-b93819d58f70"), null, null, "  Approve", 1L, 20L, 12L, "Approve" },
                    { 21L, new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 3, 30, 0, 0)), null, "  Reject است.", 21L, true, new Guid("bb1a2fe7-d2bd-449f-bfa9-031b56fd5de7"), null, null, "  Reject", 1L, 21L, 12L, "Reject" },
                    { 22L, new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 3, 30, 0, 0)), null, "  Revise است.", 22L, true, new Guid("b5bcb420-615c-4347-a314-133c5fb01bf6"), null, null, "  Revise", 1L, 22L, 12L, "Revise" },
                    { 23L, new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 3, 30, 0, 0)), null, "  SendRequest است.", 23L, true, new Guid("d497c7d9-ab6b-4854-8290-8671510b0cb1"), null, null, "  SendRequest", 1L, 23L, 12L, "SendRequest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("72756592-349c-4015-a98f-93a0f482f90c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("be810918-3990-4a84-995a-dd81a5664b4c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 65, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dfd50f34-6a78-4cd4-94f2-fdb52bc0cfbd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3edc0e68-420f-4cbd-8fa6-4120cafa5441"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 64, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1cb03fff-5fb5-4e09-911c-b97368a718d4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3f39cd77-1ae1-40e0-8775-a6a08b9899d4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(2383), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 64, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("34899122-022b-4195-a412-47084f2aebba"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("78f8f4f0-21cf-4553-b66c-0e9648902f54"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 63, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("193ee31a-e8bb-4345-bdc7-03223d5e6095"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ccb23aaa-398b-415c-a1a0-12d21357fb5a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 63, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("276a78b8-a6d6-4a74-93a5-70c8a1fe70f7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("98c074bf-0e41-47b2-96a4-a1bc40cd17a1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(5962), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 62, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7fe5f5b3-e3bf-409d-9aa5-5d382be6c28b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f829ca84-98ab-4483-ad6e-25523160cb79"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 61, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eca882cb-fc7e-4b07-b0f2-6c24e5955706"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("301e3cd0-4644-4899-90a5-8a8b6b48b94b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 526, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 61, DateTimeKind.Unspecified).AddTicks(2349), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("daafc29f-94d5-45ab-91dc-da399733a125"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("813201a2-3d7e-462f-8f91-71adb3304de1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 60, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5a59712f-8ca9-4d16-9a85-048828ae530f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("443423b0-5277-4a13-888e-f7f0075ef792"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 59, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b390c7b4-5cd7-454d-9824-11c0d01ba234"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("98f1cf25-38ab-4aae-9663-1aeac4eb0b1f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 59, DateTimeKind.Unspecified).AddTicks(4330), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b71cd5aa-a802-484b-a31a-f689544c4145"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("797d422e-a95e-449f-a819-be3d67c02bc4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 58, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("84498a00-dcca-49a3-802c-e327dbee1f57"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d5c9cf1-6b93-4d06-add3-280e2b3360b2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 525, DateTimeKind.Unspecified).AddTicks(951), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 58, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e6ffec1f-d788-42f4-855e-0e693254bf32"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5df45a42-efa9-4681-b311-2a9952626cf2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(9055), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 57, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("52345873-4e75-4332-9e82-5b88362d8931"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e3040cb4-d8cd-4615-8409-8fa0519a1443"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 57, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ae7946cd-995c-40aa-a6a2-6707d8714bf4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c7eefee9-bc7e-4bb5-ba61-ce1cb55ff878"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 56, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d8100d35-41d2-45ea-a516-1e34dd802fec"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8b7c50a5-816c-4e5e-a643-7c37ad553406"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 55, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c622b96b-2bbd-4158-96da-3b8d63c3dbb8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("75d21fbc-522b-4075-8948-433da8f5cec4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 55, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9ead35eb-3e85-4421-bab8-89cef0df9e69"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("14438067-e74e-425a-b5bf-e252747a173d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 524, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 54, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("19daa0e5-adc7-456b-be58-4de1fe4d663d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0cb70ec1-5fe7-48f3-b56b-d4d3824ced32"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(9022), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 54, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f01f81b1-266b-409e-8407-9fd087051a40"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4a87b6ea-27ef-4bf3-bbb1-7955e116ee14"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 53, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("65a7b58e-1b55-4dfa-8abf-302203509293"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e236c1a9-e58a-41fb-b993-e4dfa4c39ed0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 53, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8dd7c36d-7c22-4d34-ae05-955d270e0a17"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("93f11223-fb22-42ae-b88b-fe67b202d0d6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 52, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("05535675-d0bb-425f-b297-7306ece811cf"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("80476ac0-b967-4fcb-8863-70be6a14cea7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 523, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 52, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e1d95b24-76e7-4b7b-93ae-eac4da2ab0ac"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("173522c3-70b9-4169-972e-cd1c26099efb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 51, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("116065d1-e580-4cf8-b4e6-60293ec0f512"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8f2c9232-858d-4e7d-bbe8-ece8b8fe1987"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 51, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("881c4e97-05bb-4a33-9f36-7bd0ca79e3c4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f06c8373-47ba-485d-b979-a1c339a67099"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(5568), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 50, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9aab4424-3153-4a02-a776-fc1a7d83fce5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9fc94751-30cf-42cf-a95a-60311a5a033b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 50, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cbefd562-3051-400b-8bfd-a8840fd7e3fd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8d8044f1-08c5-4cac-968c-5c45c16c6377"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 522, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 22, 49, DateTimeKind.Unspecified).AddTicks(9513), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40611a45-a1c5-4266-9621-c9618bf33c3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01399b16-b43c-4459-89d3-4486e7462050") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d6f4789-966e-43b4-b266-48ba0859df38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af587175-3e9f-4685-ab92-c077bf2187c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf1f37ab-92d3-40ff-a995-098df73ba3b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13a8ded4-f738-4d41-9815-a052380584cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 161, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba7e3079-e3a0-4b83-8291-e66215045442") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9fb00763-9686-4ee4-aff7-57ab17602ab8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74a5657b-3603-43b9-8975-cf196d3e94da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d93fd8d-cab5-4f1a-94f6-59ea7d953be9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72358e0a-992b-4f5d-ad44-64604e9fdfc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8aff925-072b-4f72-bc44-e29d31b2e26c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(688), new TimeSpan(0, 3, 30, 0, 0)), new Guid("038b5380-8a13-4cc0-aa7a-6938fd942b25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("345f90a1-19bd-4954-9654-ce35c6b696cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b8a09fe-a43d-416b-99c9-5e326b35ab50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(716), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6427326-8496-40e3-b4e7-b23c71d62ead") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb145d2c-b377-41c8-98ae-29005b15396e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(727), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73e3811c-7394-44fc-9c8b-99ed19e66bc8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(732), new TimeSpan(0, 3, 30, 0, 0)), new Guid("334cafdb-69a8-45ce-a2c6-69e69358497a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1b63249-2124-4801-9a4f-a88850286484") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7385b9b7-22f0-41e8-acd7-2d99be066e59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e24ba9ad-b670-49c9-9e1e-bf4bd6cc0a56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4d049a8-abf1-460d-9096-9c7bb425b1a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b99858ff-8629-4684-bd94-7f36fea6a289") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c869e8f-587a-4d05-ba2c-533ad66243bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d25271ef-f60a-4718-bc9b-7f4e7b3cbf31") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(3021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23f22618-b192-4ad8-a719-b09ca710ad12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2caa403e-514a-41bd-87da-dde316e58477") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ae30964-9d37-4fc1-a493-ef42ef6e9f65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35d78cd7-26ee-4379-9f6d-4efcbfd8d331") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8838), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f773287b-5118-46f4-88cb-d691dfc4ed06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13134d6d-7593-49c5-b183-a09aa17361cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 3, 30, 0, 0)), new Guid("290fb7f0-3524-4a79-a612-75270dc23513") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(7195), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "تایید", 1L, true, new Guid("4da579bc-839c-45cb-be67-b88dfac16429"), null, null, "Approve", 1L, 2L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8825), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "عدم تایید", 2L, true, new Guid("4f62c210-7c7b-4ed6-b343-8d4eaf9d0a40"), null, null, "Reject", 2L, 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "بازنگری", 3L, true, new Guid("bd51bc9b-d3a9-4178-a0e8-c9d31ca82684"), null, null, "Revise", 3L, 2L }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d68ccdd4-159a-4a45-9989-7076dbde5ece") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8313), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55cc156f-7bde-47fa-a702-5f20011deb31") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20b59ea7-47cc-4372-b9ee-5fb6de2aa5a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a04b6889-82a6-4eeb-ad41-d8f683240eb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(1789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6db58703-ef6e-4d30-9246-d10115d4d630") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(1818), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c2b21629-fff5-4759-920f-65a35ff02ce1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(3323), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9132e893-ec92-43d8-ac9a-a3911bc92396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ecd876d1-b16d-4684-9d98-1dba36953fe1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4a507a5-3897-455a-ad4f-762a1794126d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 163, DateTimeKind.Unspecified).AddTicks(3335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11d59567-d660-4915-b773-d6186f3a429f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 159, DateTimeKind.Unspecified).AddTicks(9586), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fdf54033-771e-40c5-92d5-1c72e47bd832") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc5a0e1a-d8a3-42c4-9822-b0e9fb9235c3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 160, DateTimeKind.Unspecified).AddTicks(1518), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d956de4c-8a60-4fe7-ab32-bd2c49e743c8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 159, DateTimeKind.Unspecified).AddTicks(4244), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b0df603-c134-48cf-8d57-23755023fdbb") });
        }
    }
}
