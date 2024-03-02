using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_ReviewState_Predifined_Values2 : Migration
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
                defaultValue: new Guid("341e93cc-0d69-487e-a820-7e68545e68b0"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("00650265-e1ac-4261-8d62-8c94d04b20c7"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("0671dbe1-48d9-4815-a1b7-902a2cb664a3"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("d80e8cdc-1810-4d30-b00c-84c961a1f505"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(7835), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("622e831c-1f13-40ad-b755-2715ca7c76b7"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("63b58cc9-0a6d-449d-9727-d5fec652d47f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ba627d0c-dea6-46d1-b78f-3d004ff0c73a"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("008a177c-3b8a-49e2-a6d3-4939fbae9600"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("cc690b1e-5da1-445d-b93e-e443c15b1946"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e9c74efa-c353-4d75-8224-2b9a49a98f04"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("011093de-1c63-4d4e-aae9-042fa133a227"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("1e9a6887-38b3-4b29-b938-b1382f192e31"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("77e4ef9d-695d-4122-87a9-ba69642acbd4"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("25468956-295e-4917-b767-3e0a741f2cd2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3e58b397-2775-4f45-a74a-768be91581d4"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(1546), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("163e785e-0361-4ce6-bf55-295a3085c339"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("aed8d912-8e63-4d1a-ae61-b6058af03416"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("058e99e8-a3ec-4317-a6a3-b438d4a7501b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("51ab457c-128c-48d0-9e13-d24d5086d7bd"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7f48a798-4fe8-4fa0-aedc-2957152d0e1e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(1408), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7ddc4b4e-d368-46b8-9ca7-0482a69aca42"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("daaad324-f022-4ece-9a1c-6f1775a49437"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("1e2557d6-84c6-4bd5-a987-c15bd8bc6682"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("a2364c5a-5c29-4762-820b-4d4ce22722e1"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("69445e4e-0fae-4907-9289-d1b46f501a73"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e09b8ae4-b74e-41d5-a2fe-8ac0a338d740"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3612d0b6-4452-4141-8336-153f69882b18"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("8f9bda55-9109-4dc1-ad1f-48075ea1fb37"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("8aa0d42f-af88-4bb6-9a7e-07a32cbb4d29"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 30, 0, 0)),
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
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 28, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Approve است.", new Guid("0a89b853-2281-49b7-8b30-248e788d3404"), "ReviewState = Approve" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1229), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Reject است.", new Guid("82c931ae-3b72-461c-80b9-ebf2c4d5912f"), "ReviewState = Reject" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Revise است.", new Guid("cae2c3cc-e0e0-461b-9da0-41084db3b082"), "ReviewState = Revise" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 29, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی SendRequest است.", new Guid("3c3dbb65-3d36-43c2-b9c6-28ccc3e39a29"), "ReviewState = SendRequest" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new Guid("341e93cc-0d69-487e-a820-7e68545e68b0"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("00650265-e1ac-4261-8d62-8c94d04b20c7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0671dbe1-48d9-4815-a1b7-902a2cb664a3"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 441, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("d80e8cdc-1810-4d30-b00c-84c961a1f505"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(7835), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("622e831c-1f13-40ad-b755-2715ca7c76b7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("63b58cc9-0a6d-449d-9727-d5fec652d47f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ba627d0c-dea6-46d1-b78f-3d004ff0c73a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 440, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("008a177c-3b8a-49e2-a6d3-4939fbae9600"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("cc690b1e-5da1-445d-b93e-e443c15b1946"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e9c74efa-c353-4d75-8224-2b9a49a98f04"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("011093de-1c63-4d4e-aae9-042fa133a227"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 439, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("1e9a6887-38b3-4b29-b938-b1382f192e31"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("77e4ef9d-695d-4122-87a9-ba69642acbd4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("25468956-295e-4917-b767-3e0a741f2cd2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3e58b397-2775-4f45-a74a-768be91581d4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 438, DateTimeKind.Unspecified).AddTicks(1546), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("163e785e-0361-4ce6-bf55-295a3085c339"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("aed8d912-8e63-4d1a-ae61-b6058af03416"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("058e99e8-a3ec-4317-a6a3-b438d4a7501b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("51ab457c-128c-48d0-9e13-d24d5086d7bd"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7f48a798-4fe8-4fa0-aedc-2957152d0e1e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 437, DateTimeKind.Unspecified).AddTicks(1408), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7ddc4b4e-d368-46b8-9ca7-0482a69aca42"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("daaad324-f022-4ece-9a1c-6f1775a49437"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("1e2557d6-84c6-4bd5-a987-c15bd8bc6682"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a2364c5a-5c29-4762-820b-4d4ce22722e1"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("69445e4e-0fae-4907-9289-d1b46f501a73"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e09b8ae4-b74e-41d5-a2fe-8ac0a338d740"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 436, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3612d0b6-4452-4141-8336-153f69882b18"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8f9bda55-9109-4dc1-ad1f-48075ea1fb37"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8aa0d42f-af88-4bb6-9a7e-07a32cbb4d29"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 13, 10, 59, 435, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 30, 0, 0)));

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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6452fd2a-98d5-43f7-b2f7-54d7b1c1887d") });

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
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 377, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 3, 30, 0, 0)), "  Approve است.", new Guid("ea733f71-5b36-4687-b490-b93819d58f70"), "  Approve" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 3, 30, 0, 0)), "  Reject است.", new Guid("bb1a2fe7-d2bd-449f-bfa9-031b56fd5de7"), "  Reject" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 3, 30, 0, 0)), "  Revise است.", new Guid("b5bcb420-615c-4347-a314-133c5fb01bf6"), "  Revise" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 13, 2, 21, 378, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 3, 30, 0, 0)), "  SendRequest است.", new Guid("d497c7d9-ab6b-4854-8290-8671510b0cb1"), "  SendRequest" });

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
        }
    }
}
