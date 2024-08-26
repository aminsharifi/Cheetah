using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class DefaultBoolean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

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
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "NEWSEQUENTIALID ()",
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETDATE()",
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Task",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Form",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d351dd4b-87d6-43aa-a239-df1a706be089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb1e95b8-4704-409a-acda-d26718a28441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5050), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a71c3d23-cd9d-4a91-9e02-b812289ba1e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4eb73060-402b-4b29-afbd-b4ac33410e70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93d42d99-4d59-42ec-8cd9-8c32b5a79889") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("75d041ab-f72a-4347-9bcb-275f75bed4a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 207, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6059d615-052c-4fb5-ab2b-92e8077ceb6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bc9cdee-7cf7-4113-a693-f5fbb696e869") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec5e93e9-0e1c-48dd-bf50-11faa7745c2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2151), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ac7c42b-0dcc-4436-ab34-e844ddb36b93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f0df408f-e6cc-46ef-bbeb-51856ebcdf39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f734a55-4186-4ffb-8f1d-c35903cbcf13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16b9705b-b86d-46c1-a7cd-4a0facd3e31c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ffcb3c2-fabb-41b3-ad9e-7dd2a4ce8775") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3372bfd6-04f1-48b4-be5b-df745851245e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f48a7477-ee13-4219-b3d5-3cac961dc709") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33b498a4-d6a4-4840-b284-a14dc37fb97e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("834732cb-c1b6-491a-87a6-ce28defb152a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5229c19-7451-4f88-95a1-45bba968a908") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 3, 30, 0, 0)), new Guid("237b1c19-aa05-4de3-a588-37133d517f8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6996865-e552-434e-ab0b-27ce2f174c44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5760dc62-d5cb-4fc2-9c7b-3c16a04765da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("450d270a-15ac-44fa-9772-e619ebc6e156") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6e2b91a-a1c1-4809-a16e-7776af5742e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e08d1554-bb53-4d34-a1d7-093a4eadf01e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa20bc5c-57a5-40b1-9df1-0b819d7ea467") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("947cb0f3-b7fa-450d-bef3-7e49f8aaa1a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f382ad2-bf96-4f94-964d-43f693964be3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("259e45ab-c86c-4c22-a826-2709a53b9f13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0c0d1fc-d875-457b-83d4-c57b050c0815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c76acdf-997c-4a82-99a6-30b29b9747e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 3, 30, 0, 0)), new Guid("842b39f2-034d-495e-a2c1-6d03728bd39f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eb6194f-6f3f-4429-8487-1969a1985e2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65c95757-8ec3-4e8b-91bf-f534bc469baa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78df80f5-af1b-4c2c-960f-85711d64a74d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(8134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59e913a8-788d-4166-9067-27109c539ccd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7249644f-ab65-44ca-81c0-85ef5eabcbb6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ca995b7-4f91-4235-bbd6-3e0409425d64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("722eccbe-bf55-40d5-b1aa-cba4a8b463ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77720ff4-4ca3-4d17-a333-371d1ab099d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6997), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ddd77e3-69bf-48fc-a04f-0376d72435cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 200, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7645731b-eacc-4152-bd1b-a22019acca1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 203, DateTimeKind.Unspecified).AddTicks(4952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1723b4c-f0f6-433c-b7af-51882d2dc322") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52b20f7f-a2b5-4d75-96c4-c065b71aad39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bfbb440-b83a-4b1e-bfa3-20936c80d006") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6573), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e8bbe52-108b-48f9-9d30-be97c899573f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6602), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b586d56-97c7-4fc0-a7c4-b8aa56ad994e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(1935), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9490f77-e3b1-430a-a22b-bd859b8f5408") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b741fcde-27cb-4a7b-9e9f-5fb8caa91b16") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb10f06a-cc75-4b8c-8f90-d19f7b1d2320") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3944), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c678e93-e63a-4fd1-96fa-37b6ba058d3b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("520674c2-371c-4f7e-bf0c-5e5d53b5b547") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("041b1afd-0dff-4e6c-aea7-a9f1826d7166") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8483fe1c-3371-4bce-9e55-b0bbf5185352") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be32664b-2d6d-4ac3-8bbc-286ad63c341b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96b37113-6b1d-454f-ae7e-8f64b7b1f591") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a763d0e6-5e57-4c09-ba7b-7e697df20aa3") });

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_Created",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FifthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FourthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_Name",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ThirdId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_Created",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_EnableRecord",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_ERPCode",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_FifthId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_FourthId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_LastModified",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_Name",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropIndex(
                name: "IX_L_TaskCondition_ThirdId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "NEWSEQUENTIALID ()",
                oldComment: "Unique GUID identifier")
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Record creation date")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Task",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Form",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("199425b8-3be0-4198-948d-f82a86b237b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ce726b4-cf1d-4a62-a109-3c688a67336c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47bbcf71-dd44-4cd8-9ed8-d1543299ef5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3298d0be-1805-4274-9445-0791ab9dbd81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30b30a49-904b-45b7-b527-d94f499df44e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afc2b62e-7154-404e-9f15-2a1f11671082") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 3, 30, 0, 0)), new Guid("155acce7-e65c-4e07-84f0-aa2e545c7e81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6ab833c-b31f-47c9-b1fd-2be3e13d9e46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b6eb1c5-318e-4e3f-baf1-680ee15b6aef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bad065fb-8841-420f-ae43-cf631f4f7452") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 3, 30, 0, 0)), new Guid("150886c5-690a-475e-8398-76ebe2f2bd27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 3, 30, 0, 0)), new Guid("38801330-4554-4960-a594-f4911792904a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f254c00f-b1df-4c7c-b8ac-1829bd4e7372") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be0795a2-b94d-46ad-9566-0c8aa6ff89a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99c0e965-5161-46c6-b1c4-3f7e1071938d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab67ac09-186c-4d34-bb75-e7a228bfbddc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0967c20f-2d84-4b9d-9f20-a67be72decaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e5fa109-d619-473d-ad23-82918faccca0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8b6ff63-899d-4b54-9d3e-97c000ecb0a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa34b8b4-4122-4c49-baa7-60957819f5e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b08d904-59df-428f-b94a-b08485840ad8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05c36914-130f-42ae-b425-6c3d3ab3af0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e0c85958-047f-494d-82e9-d89ce82bbeaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d9ca666-7a74-45e1-9f8a-28584aee355d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba55c9ab-f06b-4741-b6d5-34c040d5cb00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1382), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83b1a046-b0b2-4c79-80f2-11083644c16f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13b18793-0af0-43bd-9ca8-cc2f83df71e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc64cf34-2f09-41ca-aebd-710498d59096") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e586ff1d-ddac-45b9-bcb2-bf150bdfd01e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b4f8644-2e2a-48ba-bf5d-4ff42ee14868") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ad2484e-482a-45bc-9681-7e740dad0b07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eddb0081-3956-476f-a57c-d36ae7c27636") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 3, 30, 0, 0)), new Guid("702ddb79-f8df-4aa6-9b71-3da15349d0d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6da03d2d-d7c6-4d28-aa73-39ddddd478e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbc774fc-31e5-4233-b7c5-9b0b982ec7df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("88754cf6-ce75-4f17-a551-99a86107d189") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(6146), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1aea205-eeb0-4bf0-b1e6-97366b2964bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 3, 30, 0, 0)), new Guid("34e2d8e4-8b93-47e4-85e3-2ce8ffb73d81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a73bb95b-9666-460e-b420-4c38c1a8a075") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b2b38a3-600a-495f-9c3c-0a3377373e48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fbc57390-283e-478a-aa7f-3eb104c2ca27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1029b5fa-f21f-4460-a897-4a49076e7205") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3bdb4b0-f5f6-4c84-ac9c-0a87b224e303") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d6c5c58-cb6f-4a96-a498-d8ef1ffbaf70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba66c74d-da43-42e8-aa40-98d38c17f91e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 3, 30, 0, 0)), new Guid("018d6bea-b4ef-48c0-901a-6a1dbfca362f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 3, 30, 0, 0)), new Guid("94b1bf9f-4043-4103-997d-b3297b0f20e0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(9859), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84bd44a5-54e5-4749-88a8-f9b1ef6e82f4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae5ea875-e7a2-48cb-a63b-281cd57427bf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4be83c6c-9ae4-4e27-8476-d03395497c30") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2168), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bac20e48-701e-4065-a90f-33b02b97cf52") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69993e19-812f-4034-a5c3-3cf2f8a8dee8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(3292), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73339f28-ffd3-4fd9-b4fd-ee121daf2c33") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("87053da0-62c3-40a6-8e07-c4001f89ffae") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b81a94b-9c28-4d2f-bb92-8d14fe81220d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f86204f4-6b3a-4453-87b5-cd01c7f80e0d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 521, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d8a62a9-bb23-4446-b93d-0041e9ee0151") });

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId");
        }
    }
}
