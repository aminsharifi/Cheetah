using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Convert_Annotation_To_FluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User");

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
                oldDefaultValue: new Guid("acc37f22-0fd4-4fb4-83be-460a9d6c81c5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("47f69809-62cd-49ab-9482-8dcf08878f6b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("007670c5-74fc-481f-a67e-ce7139de9308"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 462, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("aad2d81a-3aa0-4f05-a2c1-eda01dd51cad"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(7345), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5d3bf237-52e8-4461-8043-b7093a1d4bfa"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(4083), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f54f6ccc-5505-4ede-a64b-0d1cea56d962"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 461, DateTimeKind.Unspecified).AddTicks(1334), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b1abba8e-d53c-452c-9b24-abdcb0e19260"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ec626a9a-31ee-494d-9001-51a350932c27"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f96c6dfc-e849-4998-895a-a1932a276ab6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 460, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b9c0abed-6cf9-419c-b5c4-a59d348271f0"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("66b19d2b-f2ba-4856-9b94-2c2c467bdfd5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 459, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("610827ed-57c7-4587-b6ff-1a95a534f8c4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e7158a8e-2090-4b73-86a7-21f92421cc6f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7b8b6644-1051-4d19-8ed2-2aeeedf44347"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(2979), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("9bcc3944-455e-4c8a-9bd2-90fbfb732bda"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 458, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("00e78921-63af-4f75-b2c6-58f198d97f76"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6abba97c-5f70-482d-81fe-6c99227994be"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(6071), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("1e01d3fe-e759-45fd-87fc-bb2a752dcd5d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("cf5ae66f-a8c4-4623-a2ea-31bcb2a9e345"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 457, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f759e746-dd5a-4ec9-b48f-9ebb57e872ea"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4aeb3870-fbb6-4735-ba4d-6304bbc16624"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ada35bde-4004-48e2-bb2b-200bfde690dc"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(2921), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("1bf1954f-cea4-4614-8e0f-ee5de757eb86"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 456, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("94e891a2-42bf-4148-81db-11fd1e3ffa35"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(7655), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f8194d3c-7592-41f2-9ea6-a97fa20e5b53"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8d303d95-4268-458f-bf1b-030dbb24d32f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b1a716e3-4512-4f3d-b237-27ca73a11a6a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 455, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7e79be2f-e1dd-48a6-a5c7-3ebda285d5f2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("faae9549-01b5-434c-824a-13e452dac5da"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 14, 18, 0, 454, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 3, 30, 0, 0)));

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
                name: "IX_L_UserConditionGroup_D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "D_UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId",
                unique: true,
                filter: "[DelegateId] IS NOT NULL");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_L_UserConditionGroup_D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup");

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

            migrationBuilder.DropIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "F_WorkItemId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropColumn(
                name: "D_UserId",
                schema: "Links",
                table: "L_UserConditionGroup");

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
                oldDefaultValue: new Guid("9db19e69-73b3-460f-8de8-61d8ad796506"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 470, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("834f5256-7b72-4c91-b9ed-ca1682f11038"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e2cce8ef-a3a2-47b0-8112-e501cfbf7f68"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b183c903-4043-4a8d-87ab-9d31dacb2415"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6678004a-8a98-4a9f-ae3a-672fc32224d6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 469, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("872048f7-5ce2-4657-a24a-459107d40d58"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6fade4d2-2b54-4724-b066-1246fa1a2e6f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f756ea29-5e2b-4427-ae53-a9f372df9e3d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e93298ae-37f6-432c-8f6a-71aa74f82e82"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 468, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a2edf63e-0d2c-4be7-8f4e-1eb9693a7a0b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(7857), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a557078e-b591-4929-8949-c1ec0dd68487"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("845e37e6-580d-4ac3-a266-1467a68b0d02"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 467, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("096824b9-e79b-4a76-805b-f12940e47294"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0936b643-f414-4baf-af5e-45e49ed3a870"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("efd71dae-da17-4ac0-93a4-a074e82cbba2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(2036), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c1218229-df4f-4316-98d6-2731a9da14a6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 466, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("eba9be74-5705-4965-a428-669b838f92b9"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4a7810ab-ebb6-4c20-9b98-1a38ec122ab6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("83138504-5bee-4646-80ed-60b693d5a5ad"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6d245c2d-4954-4272-9ac3-8d47c61b2895"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6b135969-b0e2-49a2-b2ee-31e5b757e824"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 465, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("94ac8c57-48e4-4744-b4d9-4196ba7c3708"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("eb9aea06-fcac-44ee-a22f-a72f7ccd14fc"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("fea6d921-4aac-4f91-beee-936d6d51ddf5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c3a15283-3717-4392-b434-9fac4b9259e6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f33be890-db75-4060-811d-56915e6ac5fc"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 464, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c4cda7c7-ae79-481d-953a-a0d4298af6d3"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8348b205-bc99-4e55-b470-8442a5544812"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("be734bd4-fec6-437b-8cec-6f95b765745e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 2, 16, 7, 31, 463, DateTimeKind.Unspecified).AddTicks(6733), new TimeSpan(0, 3, 30, 0, 0)));

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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 2, 14, 17, 59, 988, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f936eee9-8a86-4472-9b0e-0619b71ea7cb") });

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

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId");
        }
    }
}
