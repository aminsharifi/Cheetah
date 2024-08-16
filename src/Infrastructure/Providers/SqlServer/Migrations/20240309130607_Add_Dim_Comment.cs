using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Dim_Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                comment: "State of the WorkItem");

            migrationBuilder.AlterTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                comment: "Additional user information");

            migrationBuilder.AlterTable(
                name: "D_User",
                schema: "Dimentions",
                comment: "Cheetah's user");

            migrationBuilder.AlterTable(
                name: "D_TagType",
                schema: "Dimentions",
                comment: "Numeric, Text, Date, binary");

            migrationBuilder.AlterTable(
                name: "D_Tag",
                schema: "Dimentions",
                comment: "Entities like position, role, etc.");

            migrationBuilder.AlterTable(
                name: "D_Process",
                schema: "Dimentions",
                comment: "The name of the processes that the admin enters");

            migrationBuilder.AlterTable(
                name: "D_Operand",
                schema: "Dimentions",
                comment: "Operand name, like equal, greater, etc.");

            migrationBuilder.AlterTable(
                name: "D_Entity",
                schema: "Dimentions",
                comment: "Table's name in the Cheetah");

            migrationBuilder.AlterTable(
                name: "D_CaseState",
                schema: "Dimentions",
                comment: "State of the case");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e83a6052-74bf-4c5d-954e-5a858083f4b9"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8c20814d-a327-4dcd-9e6e-b7cf8efb1826"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 303, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 469, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("76f1b98f-31ba-43eb-92b1-1f1457e1350f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e451582-550d-44eb-9fe9-14329b05fb6e"));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ad7d68d2-db88-4d42-9a01-5e34afa4c622"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d9eb0a6-be66-4729-ab81-2b50fe2093de"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7e27b5d2-1019-4c5f-9826-f1030f0befa4"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("276256d0-b05d-4fd1-953c-f8aca5211ceb"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

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
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("315cc1a1-7b26-49fb-ae8e-ed15cd2aa222"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9f3468e6-0fb6-4eb6-91fd-661eded5c683"));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

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
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

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
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

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
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("51f57ee4-9bed-4236-91bd-545131e89058"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ade72968-a29a-4b9c-aa65-8a4477113bba"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("68510fa2-3fed-47de-ad22-ba03b71a9948"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("bb86e028-bb6e-4b48-b362-fa2744370985"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4ee68cf9-9b16-4bcd-b780-2ee9ecfa4bfc"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f8e73a98-49dd-4675-a1c9-bc5ba9ac43f8"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f1129aae-584c-4d11-92ca-eceaec994abb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2f66a1bb-698c-4f65-8ec7-2922194e6f3a"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d5f0aede-d792-4f3a-b842-e209bcc81906"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8e4e12ab-917f-484f-b915-353d83194e1a"));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(6446), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fc452553-97cb-4176-bca0-39d70ba3c9e2"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b2201335-d672-4671-a855-d9635b9985e5"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("74f041f4-d002-4f89-88f7-b8159e813277"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ef6b852b-4e97-478f-887a-e0966ddcb44f"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 463, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5fd8659d-a256-41f5-b537-768c0e8166fa"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b5e12f68-d277-4e55-b983-ef9abb9d0603"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8bb55a1c-bfc0-44f0-a9bb-5e39fa46ecb0"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9e8c861d-ba6b-4ddc-ad72-fd3f8a4ac40c"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd4974d9-2285-4ff9-9cf7-ce931890bf50"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b45e2ed2-e78c-4a63-a8b3-9c2e83255485"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ce21e291-ca54-47c3-9922-6b8c3a57e41d"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a5f40d5d-a41a-4db3-9cf3-5fce037a9a00"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3e570d92-e104-499e-b0a9-ca714753d2cb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1bb84a94-6546-4425-a939-9da87b503616"));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7b4d38fc-aaf8-4dd1-a396-954255ef7fca"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ff3542e4-7d96-4f61-ba7f-dd143e4e1f1f"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("794e6119-9d85-4712-8f18-390dc1c26946"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a09599b9-0071-4ce7-b528-59c58c7c0ab3"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValue: "",
                comment: "English name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d7c0a250-2717-4520-afed-876ebbeb48f5"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b648d985-0281-4c59-b251-a5ad7dda019d"));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a5d21dad-6579-40a3-8dda-2ffec5dd3b5e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f5cfadc4-cb34-4da5-83a8-38cb8d8d41ae"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 458, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("11368d36-63f4-491c-a5fd-35899cb3139e"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("280d590f-6344-40af-a508-e92d22bfdbbb"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 457, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9ae30f04-e8d0-457d-86fb-9542201190c4"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("005464e5-bdd3-4b8a-9a80-9e01de56ea7a"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 455, DateTimeKind.Unspecified).AddTicks(218), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("66f1463f-dc52-4929-ab9d-65c7a5f564ea"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("55b2a122-fdba-4b9b-b7ae-f7e3d2e7ab75"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("93c8b170-968b-4819-bb6e-65f2919d987f"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("85bd79ca-42bf-4d98-8fe2-da6ed6e884bd"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2b689da7-0d01-4e9b-9390-6d43a6a30465"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aedf52e4-d117-4f20-98d1-ce4418db89cc"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b7a1dacb-c78c-4d08-8210-39839947b2eb"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("118a6ba9-8931-422d-b5f6-a10e889116a2"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7d8b1016-5acc-40ba-a530-f8ec5d78df94"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b8e7ed3b-b191-484c-81d1-40551e1cf176"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                comment: "The sort index of the record",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L);

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
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "By which user has it been updated?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                comment: "The date the record was last updated",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fae2a328-8103-4917-8652-402e3f516168"),
                comment: "Unique GUID identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("39475924-973a-4581-915a-4b01dfc852e1"));

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
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: true,
                comment: "ID of this record in ERP",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "The localized name of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Created by what user?",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 3, 30, 0, 0)),
                comment: "Record creation date",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: false,
                comment: "The unique key of each record",
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4bf3ce5f-38ba-480d-be98-bfbf55ab6e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("067cc350-29bb-442e-85cb-2be4069fadca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33009fc6-ad4b-4b78-a695-87aae49375ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b5cbb7c-a008-4674-9579-e7fdf5e875c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("190201ff-a9eb-4576-9c93-2f31546541d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6a91df4-a15b-4aeb-aa72-42ded71930cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 864, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afc33b99-5df0-4049-baec-70fe9eaf1d63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afe3f8f1-2f2d-4228-9577-5c0ce0765f0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c83aab5-cb3d-463f-9485-e3b2787bad02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("414446c7-ae04-4931-81a7-7e94b32ae5e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e71b29b8-876b-478f-b391-261f0eb12c41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("934d8cc6-e94e-44c4-83c6-e07c7022b074") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2677b1e1-7298-4426-aeb2-69b0e49d2a5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 3, 30, 0, 0)), new Guid("847ca583-72b7-4858-a8e1-53c4da9d99d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11e1ffe6-5431-4660-9b52-c95af979072d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df90271b-5a92-459c-9947-2d1c1521d8eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("441dc90f-1d63-4843-8990-dd6bbdc21100") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4499), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4598faf1-42e4-4662-9b74-79ca52f7a130") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4503), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e951a42-c33b-4d00-9719-c5e11ea9241c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e8287b9-c56e-4f4a-8498-16e6dae973e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(4514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("36013ff1-708f-42ac-b195-e0b68f5b1b78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1240), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3e9c0c0-a3b9-477f-a234-a34b9c7b6d0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f41e5e5-d52e-4f79-ada9-bfe1ccbf8346") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fd0fc8b-48dc-449d-8efa-b61d2e0daa57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9f33820-9b25-41bc-9a51-6917fb5f864d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 3, 30, 0, 0)), new Guid("774e5497-c48a-4604-837c-980d0aa2f203") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01f54e1b-311a-4c05-a6c1-ed4e1d21f13d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 861, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7be9af33-a27c-4977-88b5-2372e03b85d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23b6eb69-f10e-456b-9fd5-be4013032820") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a5887ae-3540-4572-bb49-7151dd7c0748") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9c7437e-cb02-4677-8450-d776d6f49ea6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18fd424c-adeb-4e97-8e8b-39f00d816b0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2783ad86-f92a-460b-ae06-f33dd56de24f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba259b5f-4b9d-4662-b577-5ce48c514ca8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7f05707b-8483-4774-ae2b-a9715606b5fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("97f8cc6a-ed1e-47b6-a769-bc09363cf2c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6554), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6645a588-e9d1-4fa5-8579-7ae31dfcf676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c52e62c9-494a-4001-89e2-d09ad7ea559f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dcda295-4cf1-40ca-a185-e8ff0e5f3006") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(8421), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18319d17-d032-4f7e-a291-89908f911ec3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 865, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13c2f612-78db-443d-a0e9-124d92f33d8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85ec6385-d7f5-48c0-880a-4238556d70d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e1c22c1-1b34-4874-9550-fe6662b5ca58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad666407-3f96-4916-888e-5736c5331be8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 866, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e16ddf2f-acc9-457d-b636-8dd68a6ca560") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 862, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39b4dd0c-db98-4aae-94f3-c5fab06a2c82") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96d3409f-c3ef-4610-a940-1235c05a8a87") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35807aff-5252-4160-8fbc-a56b7f2eb7df") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc2d6cc2-318f-4b32-b332-c65ab7ce188f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 861, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0fd768a4-9dbb-4f7e-a8c3-033de3feca30") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4d93751-0b63-4aa8-8f9a-f35825e80808") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 863, DateTimeKind.Unspecified).AddTicks(4505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69a890e3-2749-44b8-8755-591007bf6fd8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 5, 860, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fb61b09-8300-4b0b-91da-64388780d19e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                oldComment: "State of the WorkItem");

            migrationBuilder.AlterTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                oldComment: "Additional user information");

            migrationBuilder.AlterTable(
                name: "D_User",
                schema: "Dimentions",
                oldComment: "Cheetah's user");

            migrationBuilder.AlterTable(
                name: "D_TagType",
                schema: "Dimentions",
                oldComment: "Numeric, Text, Date, binary");

            migrationBuilder.AlterTable(
                name: "D_Tag",
                schema: "Dimentions",
                oldComment: "Entities like position, role, etc.");

            migrationBuilder.AlterTable(
                name: "D_Process",
                schema: "Dimentions",
                oldComment: "The name of the processes that the admin enters");

            migrationBuilder.AlterTable(
                name: "D_Operand",
                schema: "Dimentions",
                oldComment: "Operand name, like equal, greater, etc.");

            migrationBuilder.AlterTable(
                name: "D_Entity",
                schema: "Dimentions",
                oldComment: "Table's name in the Cheetah");

            migrationBuilder.AlterTable(
                name: "D_CaseState",
                schema: "Dimentions",
                oldComment: "State of the case");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8c20814d-a327-4dcd-9e6e-b7cf8efb1826"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e83a6052-74bf-4c5d-954e-5a858083f4b9"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 469, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 303, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3e451582-550d-44eb-9fe9-14329b05fb6e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("76f1b98f-31ba-43eb-92b1-1f1457e1350f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9d9eb0a6-be66-4729-ab81-2b50fe2093de"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ad7d68d2-db88-4d42-9a01-5e34afa4c622"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 302, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_UserCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("276256d0-b05d-4fd1-953c-f8aca5211ceb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7e27b5d2-1019-4c5f-9826-f1030f0befa4"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9f3468e6-0fb6-4eb6-91fd-661eded5c683"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("315cc1a1-7b26-49fb-ae8e-ed15cd2aa222"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

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
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ade72968-a29a-4b9c-aa65-8a4477113bba"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("51f57ee4-9bed-4236-91bd-545131e89058"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 301, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("bb86e028-bb6e-4b48-b362-fa2744370985"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("68510fa2-3fed-47de-ad22-ba03b71a9948"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f8e73a98-49dd-4675-a1c9-bc5ba9ac43f8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4ee68cf9-9b16-4bcd-b780-2ee9ecfa4bfc"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 300, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_FlowTask",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2f66a1bb-698c-4f65-8ec7-2922194e6f3a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f1129aae-584c-4d11-92ca-eceaec994abb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8e4e12ab-917f-484f-b915-353d83194e1a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d5f0aede-d792-4f3a-b842-e209bcc81906"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(6446), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 299, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b2201335-d672-4671-a855-d9635b9985e5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fc452553-97cb-4176-bca0-39d70ba3c9e2"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ef6b852b-4e97-478f-887a-e0966ddcb44f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("74f041f4-d002-4f89-88f7-b8159e813277"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 463, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 298, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b5e12f68-d277-4e55-b983-ef9abb9d0603"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5fd8659d-a256-41f5-b537-768c0e8166fa"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9e8c861d-ba6b-4ddc-ad72-fd3f8a4ac40c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8bb55a1c-bfc0-44f0-a9bb-5e39fa46ecb0"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Task",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Task",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b45e2ed2-e78c-4a63-a8b3-9c2e83255485"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cd4974d9-2285-4ff9-9cf7-ce931890bf50"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 297, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a5f40d5d-a41a-4db3-9cf3-5fce037a9a00"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ce21e291-ca54-47c3-9922-6b8c3a57e41d"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Flow",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1bb84a94-6546-4425-a939-9da87b503616"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e570d92-e104-499e-b0a9-ca714753d2cb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 296, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ff3542e4-7d96-4f61-ba7f-dd143e4e1f1f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7b4d38fc-aaf8-4dd1-a396-954255ef7fca"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a09599b9-0071-4ce7-b528-59c58c7c0ab3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("794e6119-9d85-4712-8f18-390dc1c26946"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 295, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b648d985-0281-4c59-b251-a5ad7dda019d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d7c0a250-2717-4520-afed-876ebbeb48f5"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f5cfadc4-cb34-4da5-83a8-38cb8d8d41ae"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a5d21dad-6579-40a3-8dda-2ffec5dd3b5e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 458, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("280d590f-6344-40af-a508-e92d22bfdbbb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("11368d36-63f4-491c-a5fd-35899cb3139e"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 457, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 294, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("005464e5-bdd3-4b8a-9a80-9e01de56ea7a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9ae30f04-e8d0-457d-86fb-9542201190c4"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 455, DateTimeKind.Unspecified).AddTicks(218), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("55b2a122-fdba-4b9b-b7ae-f7e3d2e7ab75"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("66f1463f-dc52-4929-ab9d-65c7a5f564ea"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 291, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("85bd79ca-42bf-4d98-8fe2-da6ed6e884bd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("93c8b170-968b-4819-bb6e-65f2919d987f"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aedf52e4-d117-4f20-98d1-ce4418db89cc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2b689da7-0d01-4e9b-9390-6d43a6a30465"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("118a6ba9-8931-422d-b5f6-a10e889116a2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b7a1dacb-c78c-4d08-8210-39839947b2eb"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 290, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b8e7ed3b-b191-484c-81d1-40551e1cf176"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7d8b1016-5acc-40ba-a530-f8ec5d78df94"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "SortIndex",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldDefaultValue: 0L,
                oldComment: "The sort index of the record");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "English name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "By which user has it been updated?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldComment: "The date the record was last updated");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("39475924-973a-4581-915a-4b01dfc852e1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fae2a328-8103-4917-8652-402e3f516168"),
                oldComment: "Unique GUID identifier");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true,
                oldComment: "ID of this record in ERP");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "The localized name of each record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Created by what user?");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 16, 36, 6, 289, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 3, 30, 0, 0)),
                oldComment: "Record creation date");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "The unique key of each record")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2c54e896-13c7-4125-8faf-d57d1fd1a441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b96b7439-cd41-4147-b3fd-3d79dc98e0fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 3, 30, 0, 0)), new Guid("818bd141-cac0-4a0c-8983-76b7c879136c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("314a8bbe-09de-4940-a118-5255b266c0c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("039e9d14-2737-4eff-adcd-61420a9efca3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50fc23a8-b5b4-484c-a675-73d637c1882e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 911, DateTimeKind.Unspecified).AddTicks(3330), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c079a2d-ef3c-4af7-8e68-3539d769a7cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(4970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d563350-a9e9-4bac-9c27-e3861bd80f5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ceab1dde-6ace-4e81-9c73-6c227a0e8d81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bdb17869-0b32-4f9b-baf9-1d5b9cb3ae61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78682a30-5dd3-435d-86e7-0a663eee795a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5042), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5fda5edd-1c43-4433-9f1d-98e0c38a35f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efe7f472-7e0b-4cc9-b1e3-cbbcf19f90ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5088), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cee88d0-313d-432e-af68-60b30122457e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d472e33-d371-48e8-b3e5-ee0c92759545") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2391ed6a-5869-496f-80d4-a05a6d794234") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1ed9e15-f588-4bb1-8625-576c4ab939bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad9b10f4-4cea-40ef-94f9-453840042fa5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81464586-f9df-4982-bf27-5309bf569928") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("97a1c6b4-2732-411a-9cef-9183e2f9a09c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0d4a0a7-3943-463a-af14-858992ca36ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fea370d-91e5-40d4-b78f-9cae014e8826") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08b36b3f-f644-46bb-b26f-ff8048b36a5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce60c89d-f705-43eb-9bbb-7e2db4da37bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2e5f6d5-21e8-4634-87cb-7312642fba9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e82bd53-271b-4dbb-a191-04bbb94fe633") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9a75a41-3a3a-4b93-977b-249be2e7d802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 908, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2419ae4-060d-4e22-8c22-3d9e896d2e7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("809d69e6-6634-4870-8107-7a83de25989c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6884), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ac15aa2-246c-4f97-9cba-4749bae6d471") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40f4b0b4-29ee-44c5-b9cd-62e86170bbcc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e940e73c-ee07-4037-8405-50d61e6448d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7535498-dc2b-40bd-a8ae-e94d77389506") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bcf70f46-adcc-48ce-9a08-14c01e088fce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b357b23a-81e5-45e8-8825-604543c5929e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46d776d7-e207-42be-b33a-73b3fb18407b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6453), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f6cf299-aa38-47a9-9572-605fac2b8020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e641bc2-7009-4922-b836-79018160ff71") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b9fb7b1-d9cf-4f6f-9dae-c662d9e18038") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ec79e87-5307-49dd-aa38-f04e5cada9db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cb8fed0-043f-4a87-a192-af7dacf605ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c416e48-43c8-460f-a785-a79fb055b50e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5010d224-47a9-4162-88a0-dcacb0c54364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f42ffe3c-fcac-4aa6-ba86-6e98e3fd0648") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 3, 30, 0, 0)), new Guid("685bd59a-9a07-4050-9597-4571e56e8b8e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e2a16c6-7709-4b2a-bd49-d8b7798a021a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1256), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4adbec50-5acf-4c28-adfc-93c5552b096b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("713b1ae7-3513-462f-afa6-8c90903a2eed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7ffaf02-1b8d-46b4-8118-3fd415b1b073") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 908, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1a40636-7800-42b2-9bf9-d505c4bdbe61") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(3366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e6e8cd7-bbdc-4211-892e-618b8de224e4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfe841ce-af23-44a5-ad40-bf0e16c28e64") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 907, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c908a04-2ed7-4f3b-af28-4532cf618170") });
        }
    }
}
