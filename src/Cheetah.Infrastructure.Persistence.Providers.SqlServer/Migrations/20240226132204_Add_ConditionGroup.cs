using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_ConditionGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new Guid("c2808b3c-31d0-47b4-b6c3-81c7b254cf83"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("115e5da5-3b83-4c48-9449-ed67b82f311c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("d635bd03-5997-472c-9552-79ccc0beb9c2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ad81689d-f6fa-4277-bd09-27d20d7d598a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("269ce883-cf5f-4a46-8ef0-31b40e153f2e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("198e35ff-d678-4414-9ac2-a7219493cdd7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e4f554f9-c1ae-41b3-9ac1-54c2623f87e8"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("10d03726-1106-480d-9d69-2d78ede99e6d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("783811ed-3e93-46ca-a8b4-edbcc6748e7e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5e57322f-9ee7-4678-aee0-dd51dde90ce0"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b1649def-1c11-44c7-92b6-30acd529e954"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("dbf7652b-67ad-4b42-be69-69e10a32d7df"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5885294f-277b-4963-8d2a-5ab6fbc4ee93"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("caa7527b-8526-48ee-b3b3-08294a41af31"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a3ac1b6f-ef7b-408f-a44a-8f7b1a6a322d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("56f0d25a-5211-4c8c-b0d9-42c2338a0d51"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("74859f67-59ba-4ea1-9ad9-b6e2e9680187"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4f615fe7-ded7-455c-a3fc-73a88f49dbc6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("65799da7-1a29-41f3-83b9-44b1443d66d5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("cf0f4751-5ac5-46f7-aeea-679e80668052"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("68c9e926-c697-47b6-af66-963f72b8a57e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("763ffac4-3e14-46e9-8dda-bcc53a33378e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ddaf00d5-a2ae-4719-a625-4dcc228b4b25"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3d92e17d-8d2d-4432-a28e-169f3c497d33"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("fb4ccb53-7044-4620-a660-23192328414d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3b0c3a69-c494-47e7-8549-da338e3ff407"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("42032e3c-c2fb-443a-9dfa-879085d930fd"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7a5c487e-1f71-4ac2-a7a8-938c766bbc55"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "L_UserCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(2383), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1cb03fff-5fb5-4e09-911c-b97368a718d4")),
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
                    table.PrimaryKey("PK_L_UserCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserCondition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserCondition_F_Condition_SecondId",
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
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(7195), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4da579bc-839c-45cb-be67-b88dfac16429") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8825), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f62c210-7c7b-4ed6-b343-8d4eaf9d0a40") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 162, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd51bc9b-d3a9-4178-a0e8-c9d31ca82684") });

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

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Created",
                schema: "Links",
                table: "L_UserCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FifthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FourthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_LastModified",
                schema: "Links",
                table: "L_UserCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Name",
                schema: "Links",
                table: "L_UserCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ThirdId",
                schema: "Links",
                table: "L_UserCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_UserCondition",
                schema: "Links");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c2808b3c-31d0-47b4-b6c3-81c7b254cf83"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("115e5da5-3b83-4c48-9449-ed67b82f311c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 16, 52, 3, 527, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d635bd03-5997-472c-9552-79ccc0beb9c2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ad81689d-f6fa-4277-bd09-27d20d7d598a"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("269ce883-cf5f-4a46-8ef0-31b40e153f2e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("198e35ff-d678-4414-9ac2-a7219493cdd7"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e4f554f9-c1ae-41b3-9ac1-54c2623f87e8"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("10d03726-1106-480d-9d69-2d78ede99e6d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("783811ed-3e93-46ca-a8b4-edbcc6748e7e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5e57322f-9ee7-4678-aee0-dd51dde90ce0"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("b1649def-1c11-44c7-92b6-30acd529e954"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("dbf7652b-67ad-4b42-be69-69e10a32d7df"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5885294f-277b-4963-8d2a-5ab6fbc4ee93"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("caa7527b-8526-48ee-b3b3-08294a41af31"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("a3ac1b6f-ef7b-408f-a44a-8f7b1a6a322d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("56f0d25a-5211-4c8c-b0d9-42c2338a0d51"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("74859f67-59ba-4ea1-9ad9-b6e2e9680187"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("4f615fe7-ded7-455c-a3fc-73a88f49dbc6"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("65799da7-1a29-41f3-83b9-44b1443d66d5"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("cf0f4751-5ac5-46f7-aeea-679e80668052"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("68c9e926-c697-47b6-af66-963f72b8a57e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("763ffac4-3e14-46e9-8dda-bcc53a33378e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ddaf00d5-a2ae-4719-a625-4dcc228b4b25"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3d92e17d-8d2d-4432-a28e-169f3c497d33"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("fb4ccb53-7044-4620-a660-23192328414d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3b0c3a69-c494-47e7-8549-da338e3ff407"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("42032e3c-c2fb-443a-9dfa-879085d930fd"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7a5c487e-1f71-4ac2-a7a8-938c766bbc55"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, 3, 30, 0, 0)),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8abd22e-6255-4d56-b27f-1a0090645a08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(806), new TimeSpan(0, 3, 30, 0, 0)), new Guid("403dc90b-2f98-4878-8c47-470a46b6ff37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb7bf519-7eb7-4bed-ba34-8949933e9620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6de1e2b-2718-4e48-90ee-cdaad7b8416d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(821), new TimeSpan(0, 3, 30, 0, 0)), new Guid("624ecaf0-a357-4d8c-bd7d-a22bfefa4b39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32252c51-6ae0-4309-bcfe-d003c2d9785c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 786, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("067684fa-8eb2-4bbb-a328-3cb4ccf996f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77b52fb2-a166-4aef-b14f-e9ebd881e6b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b290454c-0662-43c7-b2eb-7103af9bae8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b881ebec-c7d4-4c33-b3f6-94e21e3a26aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bcaccf4-17eb-4bd4-bcfe-f7305bbab253") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(777), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e62f132f-fa7d-45a8-a27b-481e4d21cd35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 3, 30, 0, 0)), new Guid("359087e6-cf3c-400c-ad23-af7d202c44b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67af549d-02dc-41c9-8274-6bd1c52c8711") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ab65304-1c0c-445a-a91e-012c69610cac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(837), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8bd94ea-7224-4b2f-bc91-aaae544cc593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(842), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a0637c9-4ed5-43a3-abd3-f5a849a6399a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf96bbda-ca31-4200-a464-887af3eb5c87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eba76f3-7de3-4f90-99de-94905e3d2d30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7ef51cb-552e-4317-87d4-efcf52cdf2e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e20592e9-7b23-4da8-ae57-b795c9ed17d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("052721d0-470b-411c-ae95-d7e8c0116c10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("611f18de-1516-4a62-9953-8c9f52f8701f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1290c4de-2673-4bb1-98c6-a8b42ac216de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91c278ec-4f84-49c9-b4ef-b803920f3a3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cbee099-e612-48e6-a0e8-8b7da08b2773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f045b31a-d42b-4851-be4e-10af25df3a81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(4117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1569786c-2be1-42a6-8afd-f5a6119e6fc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 3, 30, 0, 0)), new Guid("145cc7e0-b089-438b-b097-0b7e2f031f53") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bcc6b4b0-5293-4c1d-9272-466a7ca724d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c18075f8-1c7e-429c-9ed1-896357e20f45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dca00ebd-1da4-44ad-8c0e-fa04c17e4a92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("029feef7-7efb-4171-977c-418936d8c3d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 3, 30, 0, 0)), new Guid("703488ef-5c1b-437f-9244-5713b437bdd0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c48a157-eec9-43c6-be1b-eb93751713fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca87e766-2dab-43d0-8811-1605a55e9290") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("085f5e46-f4da-4e81-b87e-660e8424d2b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d145f6d-c932-4787-85c7-ec3e09352e25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1332f21-bbc1-42bb-a708-16fac977be3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c776a1bd-bbed-41d4-a4d7-f389a20d5e12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0536b3d6-f1b9-4810-8013-2954bd18c731") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8772ab6-c3b1-4c6c-917a-9e802d9de1db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3061), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b945677a-8245-4f98-8d46-51b1e97600d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6907ec18-377f-41db-944f-2544dd2d7122") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f2f23b5-a1a7-4a46-a7d3-ce614e1b2c3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f6c554d5-e5c8-4692-9ca3-4852dd3db47b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1be3a2d9-1894-47e4-8608-640edda560ed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58357bcd-dc0a-4c0e-9c22-c7147b230008") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0206d1b9-3123-4c86-ba63-68ead46702df") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eced882e-db85-453e-a544-ab95e65abdea") });
        }
    }
}
