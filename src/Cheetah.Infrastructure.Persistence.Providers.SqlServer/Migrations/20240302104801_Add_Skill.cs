using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Skill : Migration
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
                defaultValue: new Guid("acc37f22-0fd4-4fb4-83be-460a9d6c81c5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("341e93cc-0d69-487e-a820-7e68545e68b0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("47f69809-62cd-49ab-9482-8dcf08878f6b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("00650265-e1ac-4261-8d62-8c94d04b20c7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("007670c5-74fc-481f-a67e-ce7139de9308"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0671dbe1-48d9-4815-a1b7-902a2cb664a3"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aad2d81a-3aa0-4f05-a2c1-eda01dd51cad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d80e8cdc-1810-4d30-b00c-84c961a1f505"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(7345), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(7835), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5d3bf237-52e8-4461-8043-b7093a1d4bfa"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("622e831c-1f13-40ad-b755-2715ca7c76b7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(4083), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f54f6ccc-5505-4ede-a64b-0d1cea56d962"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("63b58cc9-0a6d-449d-9727-d5fec652d47f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(1334), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b1abba8e-d53c-452c-9b24-abdcb0e19260"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ba627d0c-dea6-46d1-b78f-3d004ff0c73a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ec626a9a-31ee-494d-9001-51a350932c27"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("008a177c-3b8a-49e2-a6d3-4939fbae9600"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f96c6dfc-e849-4998-895a-a1932a276ab6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cc690b1e-5da1-445d-b93e-e443c15b1946"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b9c0abed-6cf9-419c-b5c4-a59d348271f0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e9c74efa-c353-4d75-8224-2b9a49a98f04"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("66b19d2b-f2ba-4856-9b94-2c2c467bdfd5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("011093de-1c63-4d4e-aae9-042fa133a227"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("610827ed-57c7-4587-b6ff-1a95a534f8c4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1e9a6887-38b3-4b29-b938-b1382f192e31"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e7158a8e-2090-4b73-86a7-21f92421cc6f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("77e4ef9d-695d-4122-87a9-ba69642acbd4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7b8b6644-1051-4d19-8ed2-2aeeedf44347"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("25468956-295e-4917-b767-3e0a741f2cd2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(2979), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9bcc3944-455e-4c8a-9bd2-90fbfb732bda"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e58b397-2775-4f45-a74a-768be91581d4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(1546), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00e78921-63af-4f75-b2c6-58f198d97f76"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("163e785e-0361-4ce6-bf55-295a3085c339"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6abba97c-5f70-482d-81fe-6c99227994be"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aed8d912-8e63-4d1a-ae61-b6058af03416"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(6071), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1e01d3fe-e759-45fd-87fc-bb2a752dcd5d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("058e99e8-a3ec-4317-a6a3-b438d4a7501b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cf5ae66f-a8c4-4623-a2ea-31bcb2a9e345"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("51ab457c-128c-48d0-9e13-d24d5086d7bd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f759e746-dd5a-4ec9-b48f-9ebb57e872ea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7f48a798-4fe8-4fa0-aedc-2957152d0e1e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(1408), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4aeb3870-fbb6-4735-ba4d-6304bbc16624"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7ddc4b4e-d368-46b8-9ca7-0482a69aca42"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ada35bde-4004-48e2-bb2b-200bfde690dc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("daaad324-f022-4ece-9a1c-6f1775a49437"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(2921), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1bf1954f-cea4-4614-8e0f-ee5de757eb86"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1e2557d6-84c6-4bd5-a987-c15bd8bc6682"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("94e891a2-42bf-4148-81db-11fd1e3ffa35"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a2364c5a-5c29-4762-820b-4d4ce22722e1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(7655), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f8194d3c-7592-41f2-9ea6-a97fa20e5b53"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("69445e4e-0fae-4907-9289-d1b46f501a73"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8d303d95-4268-458f-bf1b-030dbb24d32f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e09b8ae4-b74e-41d5-a2fe-8ac0a338d740"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b1a716e3-4512-4f3d-b237-27ca73a11a6a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3612d0b6-4452-4141-8336-153f69882b18"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7e79be2f-e1dd-48a6-a5c7-3ebda285d5f2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8f9bda55-9109-4dc1-ad1f-48075ea1fb37"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("faae9549-01b5-434c-824a-13e452dac5da"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8aa0d42f-af88-4bb6-9a7e-07a32cbb4d29"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3c69183-6afa-4e9b-bf0f-18309a068792") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 3, 30, 0, 0)), new Guid("deaaddaf-78bb-422f-8d28-68f0402e0d7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8298), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18015acc-0b63-41e7-bc9c-95c4dee17d94") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9412162-9b97-480b-907b-1897bfcad0f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8303), new TimeSpan(0, 3, 30, 0, 0)), new Guid("657f6d2d-3edf-4d66-84b0-6670733c96a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(8305), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b53b49ce-d106-4d13-8599-01ad0dd814f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 990, DateTimeKind.Unspecified).AddTicks(6095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6a3d47d-b828-4f8f-a5a6-38cbea8a653f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5563), new TimeSpan(0, 3, 30, 0, 0)), new Guid("969181e1-de25-4ea7-977c-bfd0772777b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20eff5f8-4860-443c-b76a-d09ffafde6a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dce1c76c-4033-4227-be4c-1fdc34c89813") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e44e68b-35a1-45a8-a7dd-1a07cd39f303") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58c7afcd-7ea6-48ab-9554-43386719fe10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5667), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee701d4b-5a4a-4715-95f1-e7a11439a124") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4fd411b-4a36-49fe-b467-15a968c2d10a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 3, 30, 0, 0)), new Guid("658a7b45-53bd-47cc-a8f0-c58c7c55fa76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8c07acce-28a9-4a53-90df-8c01b62152fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1249ccb-dea1-4cae-823b-2410cb71bca9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a1f1e09-27ef-4962-a4cf-dedbb8f58472") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c850bd4-1fcd-45f4-96cb-ed339c3f07e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d24db43e-8871-4d26-8a42-213da1662b19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e9bcfa72-62a0-47e7-bca8-1acb35cd4cb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bdd9cd9e-3332-42e2-b04b-c8a84d80ec99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64bd181c-4956-4fde-8260-4fe12a97df94") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f49061d4-aa1e-4ded-90e7-71c04e740a5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c443c070-23d6-430b-a518-dfd3b12b7704") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 3, 30, 0, 0)), new Guid("768eee2b-5ba8-4366-aa56-32170009f5b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fb9f48a-2ddd-4fde-a405-6882cd622e1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 987, DateTimeKind.Unspecified).AddTicks(8785), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01882594-79a9-4cd1-9463-7cabe7409670") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(8086), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7335acef-a06a-4ee8-8c3d-681c2e65c935") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa96df4c-70f4-4388-ad62-44dd55389690") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eb2dcaf-dffa-4bcb-8c7f-3b76cbf06ba5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9786), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31e9f8ff-72d4-42e9-a76a-cd8c90e9ce37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 3, 30, 0, 0)), new Guid("821d0043-68ca-41f4-b477-8116980f77f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f942636c-9512-4737-b9a5-fd72796a9a21") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[] { 13L, new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "حرفه", 13L, true, new Guid("f936eee9-8a86-4472-9b0e-0619b71ea7cb"), null, null, "Skill", 13L, 4L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9994d258-611b-4420-8079-8ad1b9368813") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9375), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9fa13a2-bd79-4234-bc9a-4ccde492e5f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04fdba67-3762-447a-8309-34efe72fbf3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9381), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47beb908-c5f1-41ce-ae73-99c29d7356c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(9384), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cb0ca58-d93f-4a0f-b66e-a522c4d179f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 991, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef81df8b-8709-4c90-8758-ebffae37b149") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 992, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f10dad9-1348-4b74-8d0a-ca7b3ebaa5dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 992, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f051caf0-a8a5-445c-924f-134ca5f6c0bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 992, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ecab2cc-8a80-4ec5-bc15-4da94b274347") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 992, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b1c36f6-45cb-4025-a452-45b789146b8b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(5374), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e1d459d-7b44-4e53-935c-3be0ac11ecb2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(4247), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cf81eef-2ace-49ea-9757-b3e4a0ada52a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(4287), new TimeSpan(0, 3, 30, 0, 0)), new Guid("89086766-559a-4731-a91c-cff6ec4dfea3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(4291), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be218c91-f9ef-47ec-8b13-51fa885016a0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cc6dccf-ff95-490f-a95f-e870902861a2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(6215), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2694379d-f2ed-4672-b322-426142c2a181") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 989, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 3, 30, 0, 0)), new Guid("775cafdd-83a0-4952-9336-a976b6ddea95") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 987, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a79db737-7691-4d02-8527-89d101ddf4c7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("341e93cc-0d69-487e-a820-7e68545e68b0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("acc37f22-0fd4-4fb4-83be-460a9d6c81c5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00650265-e1ac-4261-8d62-8c94d04b20c7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("47f69809-62cd-49ab-9482-8dcf08878f6b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0671dbe1-48d9-4815-a1b7-902a2cb664a3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("007670c5-74fc-481f-a67e-ce7139de9308"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d80e8cdc-1810-4d30-b00c-84c961a1f505"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aad2d81a-3aa0-4f05-a2c1-eda01dd51cad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(7835), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(7345), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("622e831c-1f13-40ad-b755-2715ca7c76b7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5d3bf237-52e8-4461-8043-b7093a1d4bfa"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(4083), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("63b58cc9-0a6d-449d-9727-d5fec652d47f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f54f6ccc-5505-4ede-a64b-0d1cea56d962"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(1334), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ba627d0c-dea6-46d1-b78f-3d004ff0c73a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b1abba8e-d53c-452c-9b24-abdcb0e19260"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("008a177c-3b8a-49e2-a6d3-4939fbae9600"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ec626a9a-31ee-494d-9001-51a350932c27"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cc690b1e-5da1-445d-b93e-e443c15b1946"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f96c6dfc-e849-4998-895a-a1932a276ab6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e9c74efa-c353-4d75-8224-2b9a49a98f04"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b9c0abed-6cf9-419c-b5c4-a59d348271f0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("011093de-1c63-4d4e-aae9-042fa133a227"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("66b19d2b-f2ba-4856-9b94-2c2c467bdfd5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1e9a6887-38b3-4b29-b938-b1382f192e31"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("610827ed-57c7-4587-b6ff-1a95a534f8c4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("77e4ef9d-695d-4122-87a9-ba69642acbd4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e7158a8e-2090-4b73-86a7-21f92421cc6f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("25468956-295e-4917-b767-3e0a741f2cd2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7b8b6644-1051-4d19-8ed2-2aeeedf44347"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(2979), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3e58b397-2775-4f45-a74a-768be91581d4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9bcc3944-455e-4c8a-9bd2-90fbfb732bda"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(1546), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("163e785e-0361-4ce6-bf55-295a3085c339"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("00e78921-63af-4f75-b2c6-58f198d97f76"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aed8d912-8e63-4d1a-ae61-b6058af03416"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6abba97c-5f70-482d-81fe-6c99227994be"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(6071), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("058e99e8-a3ec-4317-a6a3-b438d4a7501b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1e01d3fe-e759-45fd-87fc-bb2a752dcd5d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("51ab457c-128c-48d0-9e13-d24d5086d7bd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cf5ae66f-a8c4-4623-a2ea-31bcb2a9e345"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7f48a798-4fe8-4fa0-aedc-2957152d0e1e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f759e746-dd5a-4ec9-b48f-9ebb57e872ea"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(1408), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7ddc4b4e-d368-46b8-9ca7-0482a69aca42"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4aeb3870-fbb6-4735-ba4d-6304bbc16624"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("daaad324-f022-4ece-9a1c-6f1775a49437"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ada35bde-4004-48e2-bb2b-200bfde690dc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(2921), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1e2557d6-84c6-4bd5-a987-c15bd8bc6682"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1bf1954f-cea4-4614-8e0f-ee5de757eb86"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a2364c5a-5c29-4762-820b-4d4ce22722e1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("94e891a2-42bf-4148-81db-11fd1e3ffa35"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(7655), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("69445e4e-0fae-4907-9289-d1b46f501a73"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f8194d3c-7592-41f2-9ea6-a97fa20e5b53"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e09b8ae4-b74e-41d5-a2fe-8ac0a338d740"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8d303d95-4268-458f-bf1b-030dbb24d32f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3612d0b6-4452-4141-8336-153f69882b18"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b1a716e3-4512-4f3d-b237-27ca73a11a6a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8f9bda55-9109-4dc1-ad1f-48075ea1fb37"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7e79be2f-e1dd-48a6-a5c7-3ebda285d5f2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8aa0d42f-af88-4bb6-9a7e-07a32cbb4d29"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("faae9549-01b5-434c-824a-13e452dac5da"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64643024-cc5a-429d-aea0-526d39956b7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 3, 30, 0, 0)), new Guid("22d55937-841b-4c4a-8285-e2b4e1920109") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 3, 30, 0, 0)), new Guid("815f290e-84e8-41e6-ad06-bb00e4787e09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5302), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df599854-772a-4330-9c44-b46dd2b186a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7bd91699-e968-4b94-a788-1558b1033906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d1ed529-0ec5-4cf7-8eeb-aa374a9e2188") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 30, DateTimeKind.Unspecified).AddTicks(3233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0ec9a7e-fb42-4b0f-9e48-36bbb3465102") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4011), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d1e357b-6cce-498e-8a37-1a5444b500a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f701dde0-a5c6-4bab-8d41-8b6828eea5c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4b46693-b156-47ae-9a7e-881d459b3bc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39269fca-ff8c-417b-8a09-8ddf2e3f29f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1208472b-4028-40cc-ad03-f78f7df94489") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1bbe2857-58c1-4555-85b2-4b43a30d78d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f3be485-7ee9-450c-98ea-523e8cb82285") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fae8bf5d-f4b6-414c-974a-432a9e556a87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8db68228-7764-44d4-8ee4-8923b8dbc53a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("25953386-298e-4505-adac-39ae3c07cef7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec352d90-b9a0-460c-bcce-1479a8cb91ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40e957d0-8981-4ce6-b230-97180145ea6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31de62eb-42f4-4717-8c9f-f61055cb1d34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dec07c7e-5456-42b2-b570-02cb581c9f54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5ac263a-4df0-4686-9682-93c633c3147b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b894e707-5e2c-4ecf-8389-965d0162a5e9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(833), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86501886-70dd-42bf-9c96-2b4592d0a85f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(835), new TimeSpan(0, 3, 30, 0, 0)), new Guid("362e3a8d-fc43-47f5-ba31-4cfe667abd9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 3, 30, 0, 0)), new Guid("872766c8-45ec-474a-bc1d-02808574673e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eaf28e01-56a2-41ca-acf9-f20ef3327388") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 27, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a51775f2-5d70-4dba-918a-3d716bbd6e87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec628721-0018-478c-8424-8068f592bcd7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba5d993d-b9da-4474-9e7e-03b5f3158270") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a728149a-378a-45af-bfca-b7afcc94dd00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 30, 0, 0)), new Guid("29423a17-9d4a-47e2-ac71-ff232cfc0265") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6646), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6282f193-9f70-42bb-bd88-c89026324eb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a514ce23-1316-4af1-aa87-92fe4a103270") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("691274ac-4613-46ad-81ba-59505a1b8246") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1fe3cf5-1811-400c-acb4-430dd21dd770") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("715e3f26-4f60-485b-a5e8-a44713ad842c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab506cc4-d2bc-4591-a96c-302cf1395b01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(8562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e711725c-a72d-4ceb-97dd-546cf27f01b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 31, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7bdbd8ce-e40d-4f62-b6a9-97c10a48a77f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 32, DateTimeKind.Unspecified).AddTicks(422), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd23aa83-ea47-404b-a69a-a50e5b7ce4b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 32, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66ff4ab0-859e-4cb6-a0a4-b3af953d5558") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 32, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb50d554-199d-4910-945e-b6f1447e418d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 32, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c276adf2-8e04-4ff8-a428-ff10db1dc17f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a89b853-2281-49b7-8b30-248e788d3404") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1229), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82c931ae-3b72-461c-80b9-ebf2c4d5912f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cae2c3cc-e0e0-461b-9da0-41084db3b082") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c3dbb65-3d36-43c2-b9c6-28ccc3e39a29") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 27, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d153c513-f96b-4b28-b20f-6aaa162fb485") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59f4ba10-3afb-4ebf-8bcf-964dd354c139") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 3, 30, 0, 0)), new Guid("faa9e522-02c8-4849-a011-73d353a0eedb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 27, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 3, 30, 0, 0)), new Guid("891ecd28-a604-4791-8885-0589dca54d25") });
        }
    }
}
