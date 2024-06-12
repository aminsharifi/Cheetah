using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Convert_Name_To_Nullable : Migration
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
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_TagCategory",
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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f5022c29-705b-4cc2-8705-848f6f478b28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 3, 30, 0, 0)), new Guid("961b3dd1-9983-4467-a682-2a7e0bb68ea2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec56bb4e-6fd3-451c-83af-51e891105569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bff82c18-b3d1-4509-8a90-56b5f726133a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c07944e-91d9-4d33-a052-799249fa298e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 3, 30, 0, 0)), new Guid("94be1b4d-2228-4882-87e1-eaa2ad04a487") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42a40bac-2355-46d8-a7df-e417cd080010") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80ca6d2e-f8c9-413d-a6fb-ac41de06bb0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11408147-2778-429c-8658-46ffceec8c1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd3dfe2b-3933-4900-a1d6-e03cede2f881") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 3, 30, 0, 0)), new Guid("623fb650-1983-4c42-975d-5cc77d64f7bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7baa5842-c730-4842-883b-2d9a25f39ba8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("f2cf9156-edc4-4dcc-883f-369634ffac70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("005a8bc2-1c78-4077-a51d-2f332f6caa00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86e010ed-d7e4-4868-8659-62e69ce39e92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3656), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d2c0cea-331b-456f-8be3-3462a876043b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, 3, 30, 0, 0)), new Guid("094d58ad-5d05-4790-a5cb-c93274edcec0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f109b487-0e97-42f7-b8dc-aa3c385b3a48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3667), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a1c64e0-10ca-4d39-9452-821928d0c89c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3671), new TimeSpan(0, 3, 30, 0, 0)), "سناریوها(Links)", new Guid("47a7615c-171c-4753-b652-324aa5c7aa7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f436423-38f2-4f2b-acdf-85331b60ef88"), "Equals" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc6b1acd-3205-43f3-ab2d-6bbc9ad1a41e"), "NotEquals" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5957), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bfe694c0-16bb-4c44-996f-b52d37eac991"), "Greater" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6d1a721-c76d-4e20-aa1e-6be1caf5bf50"), "EqualAndGreater" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d7f8952-c3e2-438e-a8a5-5eaa5c3a0b2a"), "LessThan" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5962), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eeb4df0a-b877-4a25-b453-3ace40432268"), "LessThanOrEqual" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 414, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("89c79736-2617-462c-ae15-1b710f222dde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 3, 30, 0, 0)), new Guid("242b00d2-0162-45b0-a700-75a8b071a776") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 3, 30, 0, 0)), new Guid("19d3df1d-d433-48ee-8d31-1b662de92744") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd9da134-0449-48b5-aeb6-7f6ddd4d5182") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5094), new TimeSpan(0, 3, 30, 0, 0)), new Guid("205c2adb-32a1-4c03-a9b2-458ce3a98e54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e94465b9-7b71-48d7-b6c5-11886a76a3e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cfc3c3a1-7b8c-4650-89c2-057ff1bdef9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04c37869-1d80-421e-b74e-4a881c371ac7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(3481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca9e7123-df08-4271-870b-533aa30bb693") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c89467f2-fd88-4fa1-931b-7b1d4885ae84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98e9be6b-7ac9-4444-8d7c-eb425ee6aec5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf7dc5de-f03b-40c3-b173-8570825e9404") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0686e62e-faae-44d5-a526-3941e7d9f990") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50c5e9fd-c286-404b-b1c6-f80becb959af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(7987), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f37d6e2-73bd-4743-9a4f-4c272d1be10e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(8051), new TimeSpan(0, 3, 30, 0, 0)), new Guid("10d787ca-a922-4e39-bd65-a9e0796f94b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35c43fe7-933d-4026-998a-0ddb8542ca5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3cec816e-9a2e-4978-877b-155c219a2d9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", new Guid("cf881ab9-44ff-49f1-a9da-87d65a761819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 3, 30, 0, 0)), new Guid("798df282-96b9-42b3-bcdd-bb70adbba7d0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("e36ef6ca-ea61-42fb-9e84-56fc81e8300d"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("05ff0ca7-09aa-4cf3-b376-8449c3462b6c"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("9c581bab-689e-409b-9e66-c2ab1f8e3afb"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("33e7c578-0886-4565-8f68-a11359fc40f7"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 416, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bcfa9643-2220-438c-ba85-1404829366f2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4dadded-f929-432d-9553-5a85a4223140") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(1475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1809e6c5-80ec-493f-a896-1ba69ac414a7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 416, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec5ede62-5626-4a55-9a78-09b22aff2f22") });
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
                nullable: false,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_TagCategory",
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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2708), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12c58cf0-2331-4eea-90f3-5bf9b7fef5c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e989fee-811d-4ff9-b077-1819a514e646") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3840f055-a00f-4d83-8a49-f1094d25a895") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("016c5c1b-c18c-4bad-9a29-2d318b08feae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e94aafa0-d32d-4fff-8ee4-ea65a21f4510") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a467784-aa7d-4eb8-afa8-678fe8426beb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 67, DateTimeKind.Unspecified).AddTicks(3447), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad784990-0f71-4b5a-aa49-31f201cbb28a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dd7ec68-8924-4527-812b-50eee30b4ba2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b38b14b9-a9d0-4114-a625-05ca9f81c975") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 30, 0, 0)), new Guid("499dc4ac-c0de-4e14-ae41-513a0c8603fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e337e54-b1a1-428d-bc93-87d739e7e876") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d50ac3c-40a9-4bbf-90b2-bfdff9d6a604") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("ab65ce69-0a88-41ba-91cb-4fb24141062e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("fe97e466-facb-4276-95d7-62d0704b98fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98e37f76-3bba-4f5e-a3b1-12402176d7a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79aaad94-fbfc-43eb-aff9-7bad86c229ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8608dede-dc3c-4081-b50b-ca755fe8d143") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1d0dd0f-789f-4b36-b4ab-bd6f9e51f401") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8df8080-284d-4be2-982d-e8ebced72f36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3259), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند-سناریو(Links)", new Guid("236ebfcc-71e5-4e54-9fa4-8dd205d76567") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ece65cd0-9fb4-4c32-9b13-c2058eac4287"), "=" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a05cc128-86d1-4f73-8257-9f2efdd39940"), "!=" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be76510a-37d2-421b-a9b4-303a5d60e4c4"), ">" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9dc4649-c5ad-4c57-90b4-d9cd2aecf405"), ">=" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb740d10-86fe-43fd-ae0c-2678cbc74a80"), "<" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f3b63a9-d411-419b-ad9b-f8131a692060"), "<=" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2863786c-7966-44a3-a2d9-125680cb3a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("acc61bf4-1c9e-4147-b968-5c642d0dc458") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea15f296-0087-49a7-904b-86088c15dddb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ad6b8ea-ee84-4eaa-91d2-b749d0f87e9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50d3b452-c813-4149-9ed3-0e76496a902a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5008), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a86ee54-5a4d-48a5-8c8e-89bfcd260232") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5011), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59503374-2777-4fd0-ad36-75d796fb0706") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f52fd3f-95ee-4ef5-8d9d-47b5b68c7655") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54d93f73-6961-44f2-8f03-bd571e67096d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e89a8e8-0343-411c-b4be-d628b2343cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ff5aed0-7039-40b9-b621-3f68f50b4145") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d62b481-11dd-459a-8afd-7e766de4b2d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3785b160-d98b-4e82-bba7-08f6367311fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c83bf3ce-5822-4ef9-8ea9-b898f27641c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef6f86e5-ada7-4db9-8ce7-6d3202b66dfa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e52f00ad-1c5e-4c1f-8c8f-c28d3c2fab88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3788), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ba0c969-7360-4a7a-9a9c-b7de615978de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3d0faed-83dd-4b52-a0a9-e9eefbfb83e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3799), new TimeSpan(0, 3, 30, 0, 0)), "خارج شده", new Guid("1c2ae80f-7163-4513-bb80-bc572eedb81d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e4c36a9c-e018-4a0d-8f04-a37afa65a0b6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(9559), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Approve است.", new Guid("f8eb9bb0-bc62-4851-8ef2-a2814c221dc9"), "ReviewState = Approve" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Reject است.", new Guid("3894a4c8-089b-4c75-ab5a-5f227026c68e"), "ReviewState = Reject" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Revise است.", new Guid("85f1c195-ba69-49a8-81ee-7e83cb522b69"), "ReviewState = Revise" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی SendRequest است.", new Guid("674d0c44-1fdb-45c3-84fb-27726b1eab9b"), "ReviewState = SendRequest" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2be57608-4d14-4063-8f08-24e2e5e2916e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26a3db3a-3cea-4ca1-a53f-9ee88c0952c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69df16ce-6069-49e4-be04-103155784167") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 62, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8069c563-c669-4006-b3e9-5a8a018790b2") });
        }
    }
}
