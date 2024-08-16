using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Form_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AddColumn<long>(
                name: "TaskId",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AddColumn<long>(
                name: "FormsId",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "The date the record was last updated");

            migrationBuilder.CreateTable(
                name: "F_Form",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Form", x => x.Id);
                },
                comment: "Entitiy for forms");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("4a4fabd2-e6e4-4aeb-8e34-3a2d9f803004"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("6c45a085-a3a6-42cc-a419-db8e39d7e1b7"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 3, 30, 0, 0)), -3L, new Guid("5413233e-b93d-48fc-90ae-f9ea67ab0cf8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 3, 30, 0, 0)), -4L, new Guid("aaa3bd60-997f-47b3-94b2-e179a4d17cda"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, 3, 30, 0, 0)), -5L, new Guid("70dd8a98-bd8c-405d-a0fb-3f387921e661"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 3, 30, 0, 0)), -6L, new Guid("3997aba5-3fd9-4bb4-9489-296260906e92"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc5d6706-5bc2-41f9-a3ba-e5d90c3328ff"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8384), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c371442-b482-4726-8483-b6b88de32256"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af5cacde-354b-4551-9fa0-83cef56dd828"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fba2ae7d-2a22-48a7-afd6-5f4d391dbd19"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8431), new TimeSpan(0, 3, 30, 0, 0)), new Guid("610efc5d-15e3-4af0-8d8b-b33b1a1a82de"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a9916d2-d536-4a1a-b1dc-54dd118e4079"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 3, 30, 0, 0)), "اطلاعات کاربرها(Dimentions)", new Guid("e783b856-e27c-4869-80c0-5c4117fce7bd"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fed079b6-6242-45ea-a61f-874b8e216d1d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8464), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cdb9ef4-f995-4aab-8737-9dd27ebce720"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 3, 30, 0, 0)), new Guid("986e3e71-8800-481d-8a6f-735cf0e45ef5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72b37075-3734-4c12-81b8-f49d46ffe396"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, 3, 30, 0, 0)), "اطلاعات درخواست‌ها(Dimentions)", new Guid("2a4d089b-9d50-4271-a5bb-87a6c5b06d47"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "DisplayName", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 3, 30, 0, 0)), "سناریوها(Dimentions)", new Guid("6060ff53-ded8-4687-8e04-1e9d75f64624"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "Display", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("65f891c6-73de-4c6c-a20a-0490eba2911f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("c746247f-6b6c-48f9-abef-e69e6cf45f87"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("58cb509e-f175-49b7-b15b-e7aca666f727"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 3, 30, 0, 0)), -3L, new Guid("65452e0d-12e2-4cf6-81df-0ce02a00f517"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 3, 30, 0, 0)), -4L, new Guid("547030cc-f6b3-437b-a7a4-5019df2d3e56"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(142), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر از", -5L, new Guid("b4fceba9-57d6-4550-a2b6-fdb145881af5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(145), new TimeSpan(0, 3, 30, 0, 0)), -6L, new Guid("5fa4573c-da10-4b5d-aef7-d1e56d08aaeb"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 775, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("243290fa-c7e0-433e-bed8-4f800323c020"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 3, 30, 0, 0)), -4L, new Guid("59e3e968-dfcd-4059-8ad1-ee73c6bc5024"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 3, 30, 0, 0)), -5L, new Guid("ed3a1002-a47a-4076-b83c-25203b14f162"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 3, 30, 0, 0)), -6L, new Guid("6421f3e8-1814-4f9f-a5bc-ba6297101862"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 3, 30, 0, 0)), -7L, new Guid("8d41c5ce-7fcb-486a-a762-442ffc6eedb2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 3, 30, 0, 0)), -8L, new Guid("6a9bb5f8-4fc2-4101-85ef-209b85bbefac"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 3, 30, 0, 0)), -12L, new Guid("3a1ee0e2-7b63-4a87-b49b-9779c665ed05"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6113), new TimeSpan(0, 3, 30, 0, 0)), -13L, new Guid("03b73076-e20c-41da-b5b2-a8b6e091c09f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(5062), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("40b074b4-4002-4d94-90b0-5e6a089be9a6"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("c8afe500-f109-482b-9766-d0d0a0afdc9e"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("f4d0671e-8562-41d8-8038-fd4080eb9305"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3798), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("8055b522-3e1d-49e5-bc9d-62a32bfd850d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", -3L, new Guid("45a5a001-604f-4a93-9a61-336ec799c2ae"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 3, 30, 0, 0)), -4L, new Guid("5e5c0ed4-a9fe-4990-87d3-e0b0c0cc9c76"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("56271a52-4649-4826-bf8f-61e437bf603f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("af61f573-916f-41c1-b8a5-a7885b8a9758"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("8fe44cc9-d5e8-449a-beee-0580c7444500"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 3, 30, 0, 0)), -2L, new Guid("978df255-eee4-4ada-b30a-6920b7fd7a1d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 3, 30, 0, 0)), "خروج", -3L, new Guid("082f80dc-c9fd-4671-b9d1-7606bc181bc9"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 30, 0, 0)), -4L, new Guid("2caabb72-a13e-4ab7-ad08-d103ad5d57ca"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 776, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Approve است.", -20L, new Guid("3838265c-365a-4c96-a2e6-2a71701d28df"), null, "ReviewState = Approve" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Reject است.", -21L, new Guid("0b6b82f1-1768-41ca-abf9-4133733a22cb"), null, "ReviewState = Reject" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Revise است.", -22L, new Guid("7e67fef1-68de-466f-a028-993ebe4530d9"), null, "ReviewState = Revise" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "LastModified", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی SendRequest است.", -23L, new Guid("d64e59e7-bd25-42b3-bb72-19bffa2535f6"), null, "ReviewState = SendRequest" });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Form",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, 3, 30, 0, 0)), "اقدام کارشناسی", -1L, true, new Guid("f2bcdc05-292f-4e04-a557-81b62664410b"), null, "ExpertForm", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", -2L, true, new Guid("30c35661-98fb-44fe-972f-feb86f18d03b"), null, "ReviewForm", 2L }
                });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 776, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("d10b0c9d-1020-4fd1-960b-a27353a8e022"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "FormsId", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 3, 30, 0, 0)), -1L, null, new Guid("0098ca01-c103-424d-9c23-4a569abd4698"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "FormsId", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 3, 30, 0, 0)), -2L, null, new Guid("65f338a1-ba20-4356-a9ee-8b6e86f6a3b2"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 774, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 3, 30, 0, 0)), -1L, new Guid("a52ecf22-c736-428b-86cc-ba210632d8c6"), null });

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_TaskId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_UserId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_FormsId",
                schema: "Facts",
                table: "F_Task",
                column: "FormsId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_Created",
                schema: "Facts",
                table: "F_Form",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_EnableRecord",
                schema: "Facts",
                table: "F_Form",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_ERPCode",
                schema: "Facts",
                table: "F_Form",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_LastModified",
                schema: "Facts",
                table: "F_Form",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_Name",
                schema: "Facts",
                table: "F_Form",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Task_F_Form_FormsId",
                schema: "Facts",
                table: "F_Task",
                column: "FormsId",
                principalSchema: "Facts",
                principalTable: "F_Form",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_D_User_UserId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_TaskId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Form_FormsId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_D_User_UserId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_TaskId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropTable(
                name: "F_Form",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseTaskUser_TaskId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseTaskUser_UserId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropIndex(
                name: "IX_F_Task_FormsId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.DropColumn(
                name: "TaskId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropColumn(
                name: "FormsId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("f5022c29-705b-4cc2-8705-848f6f478b28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("961b3dd1-9983-4467-a682-2a7e0bb68ea2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 3, 30, 0, 0)), 3L, new Guid("ec56bb4e-6fd3-451c-83af-51e891105569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 3, 30, 0, 0)), 4L, new Guid("bff82c18-b3d1-4509-8a90-56b5f726133a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 3, 30, 0, 0)), 5L, new Guid("0c07944e-91d9-4d33-a052-799249fa298e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 3, 30, 0, 0)), 6L, new Guid("94be1b4d-2228-4882-87e1-eaa2ad04a487") });

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
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 3, 30, 0, 0)), "اطلاعات کاربرها(Facts)", new Guid("f2cf9156-edc4-4dcc-883f-369634ffac70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 3, 30, 0, 0)), new Guid("005a8bc2-1c78-4077-a51d-2f332f6caa00") });

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
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 3, 30, 0, 0)), "اطلاعات درخواست‌ها(Facts)", new Guid("f109b487-0e97-42f7-b8dc-aa3c385b3a48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3667), new TimeSpan(0, 3, 30, 0, 0)), "سناریوها(Facts)", new Guid("5a1c64e0-10ca-4d39-9452-821928d0c89c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 420, DateTimeKind.Unspecified).AddTicks(3671), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("47a7615c-171c-4753-b652-324aa5c7aa7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("5f436423-38f2-4f2b-acdf-85331b60ef88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("bc6b1acd-3205-43f3-ab2d-6bbc9ad1a41e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5957), new TimeSpan(0, 3, 30, 0, 0)), 3L, new Guid("bfe694c0-16bb-4c44-996f-b52d37eac991") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 3, 30, 0, 0)), 4L, new Guid("c6d1a721-c76d-4e20-aa1e-6be1caf5bf50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 3, 30, 0, 0)), " کوچکتر از", 5L, new Guid("7d7f8952-c3e2-438e-a8a5-5eaa5c3a0b2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5962), new TimeSpan(0, 3, 30, 0, 0)), 6L, new Guid("eeb4df0a-b877-4a25-b453-3ace40432268") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 414, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("89c79736-2617-462c-ae15-1b710f222dde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 3, 30, 0, 0)), 4L, new Guid("242b00d2-0162-45b0-a700-75a8b071a776") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 3, 30, 0, 0)), 5L, new Guid("19d3df1d-d433-48ee-8d31-1b662de92744") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 3, 30, 0, 0)), 6L, new Guid("dd9da134-0449-48b5-aeb6-7f6ddd4d5182") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5094), new TimeSpan(0, 3, 30, 0, 0)), 7L, new Guid("205c2adb-32a1-4c03-a9b2-458ce3a98e54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, 3, 30, 0, 0)), 8L, new Guid("e94465b9-7b71-48d7-b6c5-11886a76a3e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 3, 30, 0, 0)), 12L, new Guid("cfc3c3a1-7b8c-4650-89c2-057ff1bdef9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(5105), new TimeSpan(0, 3, 30, 0, 0)), 13L, new Guid("04c37869-1d80-421e-b74e-4a881c371ac7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(3481), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("ca9e7123-df08-4271-870b-533aa30bb693") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("c89467f2-fd88-4fa1-931b-7b1d4885ae84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2700), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("98e9be6b-7ac9-4444-8d7c-eb425ee6aec5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("bf7dc5de-f03b-40c3-b173-8570825e9404") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 3, 30, 0, 0)), "تاریخ", 3L, new Guid("0686e62e-faae-44d5-a526-3941e7d9f990") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 3, 30, 0, 0)), 4L, new Guid("50c5e9fd-c286-404b-b1c6-f80becb959af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(7987), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("9f37d6e2-73bd-4743-9a4f-4c272d1be10e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(8051), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("10d787ca-a922-4e39-bd65-a9e0796f94b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("35c43fe7-933d-4026-998a-0ddb8542ca5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4874), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("3cec816e-9a2e-4978-877b-155c219a2d9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", 3L, new Guid("cf881ab9-44ff-49f1-a9da-87d65a761819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 3, 30, 0, 0)), 4L, new Guid("798df282-96b9-42b3-bcdd-bb70adbba7d0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 3, 30, 0, 0)), "", 20L, new Guid("e36ef6ca-ea61-42fb-9e84-56fc81e8300d"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 3, 30, 0, 0)), "", 21L, new Guid("05ff0ca7-09aa-4cf3-b376-8449c3462b6c"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, 3, 30, 0, 0)), "", 22L, new Guid("9c581bab-689e-409b-9e66-c2ab1f8e3afb"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "ERPCode", "GuidRecord", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 417, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 3, 30, 0, 0)), "", 23L, new Guid("33e7c578-0886-4565-8f68-a11359fc40f7"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 416, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("bcfa9643-2220-438c-ba85-1404829366f2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("d4dadded-f929-432d-9553-5a85a4223140") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 418, DateTimeKind.Unspecified).AddTicks(1475), new TimeSpan(0, 3, 30, 0, 0)), 2L, new Guid("1809e6c5-80ec-493f-a896-1ba69ac414a7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 10, 15, 51, 58, 416, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 3, 30, 0, 0)), 1L, new Guid("ec5ede62-5626-4a55-9a78-09b22aff2f22") });
        }
    }
}
