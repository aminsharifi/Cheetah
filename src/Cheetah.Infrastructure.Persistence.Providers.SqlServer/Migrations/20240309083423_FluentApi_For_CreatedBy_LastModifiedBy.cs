using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class FluentApi_For_CreatedBy_LastModifiedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("8580f234-f852-4d3d-a961-4a76c88db957"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 129, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("2b9a2ff0-905e-48cf-a2a1-bf9e4154a1a8"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("5780a78a-dcb1-4c14-86e5-3049388b086a"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(5547), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("24364985-7c87-4ce5-a3ca-52057821c3da"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("dbae1bfa-1f56-47eb-b5e2-d2f410d83149"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 127, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("81dc79cf-9e9e-4e41-ac54-bcf5d9e392f4"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 127, DateTimeKind.Unspecified).AddTicks(3049), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("ed458b31-8bb0-43e7-ba60-de3fbffbb7f0"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("6d2c4d40-149c-4bff-994a-500ec49083db"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(4491), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("1941a7f7-0c02-4fec-92b6-8275d5b2aa5e"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("8d946108-addc-4691-ad80-f838e7168e35"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 125, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("11abf628-d9b7-4f21-8e79-4bcd513a6d93"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 125, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("770b385c-75df-4aad-a505-67cb999b9453"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 124, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("267d380a-d9a3-4d85-b515-b8921d34abe0"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 124, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("86162d67-05fb-4c69-9cd4-705118a7b990"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(8016), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("d69ae1b6-a189-4ef1-a14a-8984910e7533"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("53b24a13-db49-4bb0-b4b4-37908250c2e1"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("d22a2e3e-a203-4265-836b-c3ea7cf84c4f"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 122, DateTimeKind.Unspecified).AddTicks(6839), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("215eecde-324e-44fb-9d3c-44a6670a060c"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 122, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("27c5ceec-620f-4d27-ae34-949bf8b0ecd5"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 121, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("d0b354dc-b2a8-474f-b034-6c468fa1f2ad"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 121, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("acd13836-158c-4a00-bec2-aec32a08c54b"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 120, DateTimeKind.Unspecified).AddTicks(9618), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("63f4cb9b-c9e1-475e-8283-565461cde068"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 120, DateTimeKind.Unspecified).AddTicks(6067), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("3ee364dc-5cbd-4fca-8195-abcffedf6dec"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 118, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("12b8c14c-d4cd-4d58-a470-3813ba74fdf1"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("738c094a-90c9-4fd2-8db4-47e2c9c2ae57"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("ad427966-8ae7-4ea8-b6c9-1c2eae3c3952"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("75097b8b-7adc-4c5e-973b-29d1847749b7"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 116, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("e0602d30-4f77-4541-8487-7f882e054c62"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 116, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11);

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
                oldDefaultValue: new Guid("ade53689-3fac-4e9a-9d06-9e48df84619f"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 115, DateTimeKind.Unspecified).AddTicks(9622), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("2c54e896-13c7-4125-8faf-d57d1fd1a441"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("b96b7439-cd41-4147-b3fd-3d79dc98e0fd"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("818bd141-cac0-4a0c-8983-76b7c879136c"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("314a8bbe-09de-4940-a118-5255b266c0c2"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("039e9d14-2737-4eff-adcd-61420a9efca3"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("50fc23a8-b5b4-484c-a675-73d637c1882e"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 911, DateTimeKind.Unspecified).AddTicks(3330), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("9c079a2d-ef3c-4af7-8e68-3539d769a7cd"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(4970), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("7d563350-a9e9-4bac-9c27-e3861bd80f5e"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("ceab1dde-6ace-4e81-9c73-6c227a0e8d81"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5023), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("bdb17869-0b32-4f9b-baf9-1d5b9cb3ae61"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("78682a30-5dd3-435d-86e7-0a663eee795a"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5042), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("5fda5edd-1c43-4433-9f1d-98e0c38a35f2"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("efe7f472-7e0b-4cc9-b1e3-cbbcf19f90ba"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5088), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("6cee88d0-313d-432e-af68-60b30122457e"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("2d472e33-d371-48e8-b3e5-ee0c92759545"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("2391ed6a-5869-496f-80d4-a05a6d794234"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("d1ed9e15-f588-4bb1-8625-576c4ab939bc"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("ad9b10f4-4cea-40ef-94f9-453840042fa5"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("81464586-f9df-4982-bf27-5309bf569928"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("97a1c6b4-2732-411a-9cef-9183e2f9a09c"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("b0d4a0a7-3943-463a-af14-858992ca36ae"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("1fea370d-91e5-40d4-b78f-9cae014e8826"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("08b36b3f-f644-46bb-b26f-ff8048b36a5d"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("ce60c89d-f705-43eb-9bbb-7e2db4da37bf"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("b2e5f6d5-21e8-4634-87cb-7312642fba9b"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(879), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("1e82bd53-271b-4dbb-a191-04bbb94fe633"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("d9a75a41-3a3a-4b93-977b-249be2e7d802"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 908, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("e2419ae4-060d-4e22-8c22-3d9e896d2e7f"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("809d69e6-6634-4870-8107-7a83de25989c"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6884), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("8ac15aa2-246c-4f97-9cba-4749bae6d471"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("40f4b0b4-29ee-44c5-b9cd-62e86170bbcc"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("e940e73c-ee07-4037-8405-50d61e6448d5"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("d7535498-dc2b-40bd-a8ae-e94d77389506"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("bcf70f46-adcc-48ce-9a08-14c01e088fce"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("b357b23a-81e5-45e8-8825-604543c5929e"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("46d776d7-e207-42be-b33a-73b3fb18407b"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6453), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("3f6cf299-aa38-47a9-9572-605fac2b8020"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("6e641bc2-7009-4922-b836-79018160ff71"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("1b9fb7b1-d9cf-4f6f-9dae-c662d9e18038"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("7ec79e87-5307-49dd-aa38-f04e5cada9db"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 913, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("6cb8fed0-043f-4a87-a192-af7dacf605ee"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("9c416e48-43c8-460f-a785-a79fb055b50e"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("5010d224-47a9-4162-88a0-dcacb0c54364"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(488), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("f42ffe3c-fcac-4aa6-ba86-6e98e3fd0648"), "" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 914, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("685bd59a-9a07-4050-9597-4571e56e8b8e"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 909, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("2e2a16c6-7709-4b2a-bd49-d8b7798a021a"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1256), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("4adbec50-5acf-4c28-adfc-93c5552b096b"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("713b1ae7-3513-462f-afa6-8c90903a2eed"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("b7ffaf02-1b8d-46b4-8118-3fd415b1b073"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 908, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("c1a40636-7800-42b2-9bf9-d505c4bdbe61"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(3366), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("5e6e8cd7-bbdc-4211-892e-618b8de224e4"), "" });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 910, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("dfe841ce-af23-44a5-ad40-bf0e16c28e64"), "" });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 21, 907, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 3, 30, 0, 0)), "", new Guid("7c908a04-2ed7-4f3b-af28-4532cf618170"), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8580f234-f852-4d3d-a961-4a76c88db957"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8c20814d-a327-4dcd-9e6e-b7cf8efb1826"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 129, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 469, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2b9a2ff0-905e-48cf-a2a1-bf9e4154a1a8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e451582-550d-44eb-9fe9-14329b05fb6e"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5780a78a-dcb1-4c14-86e5-3049388b086a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d9eb0a6-be66-4729-ab81-2b50fe2093de"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_UserCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(5547), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 468, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("24364985-7c87-4ce5-a3ca-52057821c3da"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("276256d0-b05d-4fd1-953c-f8aca5211ceb"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_TaskFlow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 128, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dbae1bfa-1f56-47eb-b5e2-d2f410d83149"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9f3468e6-0fb6-4eb6-91fd-661eded5c683"));

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
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 127, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 467, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("81dc79cf-9e9e-4e41-ac54-bcf5d9e392f4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ade72968-a29a-4b9c-aa65-8a4477113bba"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 127, DateTimeKind.Unspecified).AddTicks(3049), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ed458b31-8bb0-43e7-ba60-de3fbffbb7f0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("bb86e028-bb6e-4b48-b362-fa2744370985"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 466, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6d2c4d40-149c-4bff-994a-500ec49083db"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f8e73a98-49dd-4675-a1c9-bc5ba9ac43f8"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(4491), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1941a7f7-0c02-4fec-92b6-8275d5b2aa5e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2f66a1bb-698c-4f65-8ec7-2922194e6f3a"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_FlowCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 126, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 465, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8d946108-addc-4691-ad80-f838e7168e35"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8e4e12ab-917f-484f-b915-353d83194e1a"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 125, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(6446), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("11abf628-d9b7-4f21-8e79-4bcd513a6d93"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b2201335-d672-4671-a855-d9635b9985e5"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 125, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 464, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("770b385c-75df-4aad-a505-67cb999b9453"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ef6b852b-4e97-478f-887a-e0966ddcb44f"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Links",
                table: "L_CaseCondition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 124, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 463, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("267d380a-d9a3-4d85-b515-b8921d34abe0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b5e12f68-d277-4e55-b983-ef9abb9d0603"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_WorkItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 124, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("86162d67-05fb-4c69-9cd4-705118a7b990"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9e8c861d-ba6b-4ddc-ad72-fd3f8a4ac40c"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Task",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(8016), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 462, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d69ae1b6-a189-4ef1-a14a-8984910e7533"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b45e2ed2-e78c-4a63-a8b3-9c2e83255485"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Scenario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("53b24a13-db49-4bb0-b4b4-37908250c2e1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a5f40d5d-a41a-4db3-9cf3-5fce037a9a00"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Flow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 123, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 461, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d22a2e3e-a203-4265-836b-c3ea7cf84c4f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1bb84a94-6546-4425-a939-9da87b503616"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 122, DateTimeKind.Unspecified).AddTicks(6839), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("215eecde-324e-44fb-9d3c-44a6670a060c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ff3542e4-7d96-4f61-ba7f-dd143e4e1f1f"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 122, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 460, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("27c5ceec-620f-4d27-ae34-949bf8b0ecd5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a09599b9-0071-4ce7-b528-59c58c7c0ab3"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Case",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 121, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d0b354dc-b2a8-474f-b034-6c468fa1f2ad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b648d985-0281-4c59-b251-a5ad7dda019d"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 121, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 459, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("acd13836-158c-4a00-bec2-aec32a08c54b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f5cfadc4-cb34-4da5-83a8-38cb8d8d41ae"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 120, DateTimeKind.Unspecified).AddTicks(9618), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 458, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("63f4cb9b-c9e1-475e-8283-565461cde068"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("280d590f-6344-40af-a508-e92d22bfdbbb"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 120, DateTimeKind.Unspecified).AddTicks(6067), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 457, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3ee364dc-5cbd-4fca-8195-abcffedf6dec"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("005464e5-bdd3-4b8a-9a80-9e01de56ea7a"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 118, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 455, DateTimeKind.Unspecified).AddTicks(218), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("12b8c14c-d4cd-4d58-a470-3813ba74fdf1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("55b2a122-fdba-4b9b-b7ae-f7e3d2e7ab75"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_TagType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("738c094a-90c9-4fd2-8db4-47e2c9c2ae57"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("85bd79ca-42bf-4d98-8fe2-da6ed6e884bd"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Tag",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 454, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ad427966-8ae7-4ea8-b6c9-1c2eae3c3952"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aedf52e4-d117-4f20-98d1-ce4418db89cc"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Process",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 117, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("75097b8b-7adc-4c5e-973b-29d1847749b7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("118a6ba9-8931-422d-b5f6-a10e889116a2"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 116, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 453, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e0602d30-4f77-4541-8487-7f882e054c62"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b8e7ed3b-b191-484c-81d1-40551e1cf176"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 116, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ade53689-3fac-4e9a-9d06-9e48df84619f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("39475924-973a-4581-915a-4b01dfc852e1"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "")
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 38, 115, DateTimeKind.Unspecified).AddTicks(9622), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 3, 9, 12, 4, 22, 452, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("8f896456-0b9c-4145-a7af-7e8d461d28d2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1432), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("97b9376e-e769-408e-a133-2e72010b8359"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1435), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("84fd0bdd-e50a-4026-bafb-4120117cff86"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("c7b2a5f1-a388-4e47-948a-3c46f4cb1413"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("bd478d51-a5c9-46c0-88cc-ae94ef7ca14a"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(1443), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("08970142-e761-4143-8f1b-4f14a6fd3961"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 650, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("9402b5af-3df8-4f57-a25b-7ee7be937844"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8740), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("6ac29853-e7a3-4cd9-ba57-5c8cbd63a1e8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("1a65c703-845f-49b9-b8ac-d99719b8efba"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("c393dff4-bb70-41e5-9bd0-0a552e4c20a0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("c8435cb5-c636-462a-8c3f-678ba00e76d3"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("995706c3-eaed-48d0-a8d0-24e89b878501"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("b7544b18-abe3-40e9-8a7d-d102dc599060"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("15c4b513-bca1-4f22-b09d-830922c17b6f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("eb087271-4143-4d57-89bd-46c78f165928"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("b141bdb9-fda8-408a-b4a1-0fd2c939f25f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8838), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("3407356c-72e5-4d59-9ada-21bfd887bb85"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("273f3eb7-9714-4082-b11b-5bbe2061f7f1"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("79437fac-c01d-42b5-aa2b-889727860029"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("41a5d86e-571b-4dc3-b85a-1faf4411f607"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 651, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("507a67ab-5ee5-482e-a8d4-765ae858d3a9"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("2dfaf55d-9271-45d6-97f5-8c459c03e0ea"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("3c9d21f4-e3ea-40fd-baaa-5a53d2dccb70"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("61d1b931-7adf-4698-b643-8f51cda389b3"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6758), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("27e85d97-eaa7-49d2-870a-ad3995412289"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("403cfbe8-29dd-4f55-93a5-fa3736b9c9b8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("dd34546e-1f8e-4fa6-b497-543c2d320058"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 647, DateTimeKind.Unspecified).AddTicks(9917), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("22a5119d-5abe-47f8-80ff-78ac30a3a2b9"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("e8e99695-c82c-44c5-9437-7699a288086f"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("90e748c1-ecac-4bb6-89db-5bb6135996a4"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("99177327-bfa5-4e29-a71a-681898fdf3ac"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("7d489426-3fb9-4f36-964d-032983573ea2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2734), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("180dbfcc-e278-41ec-bda5-ed22370f7a3c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("4855a7e5-5e99-44ed-8b73-b4f4758a27c8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("6f017ff3-15d9-470f-ac3b-0fbe138c11ef"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2306), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("a26c72a4-771e-4a3c-a486-3cb91fd6746b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("7bc9bfbb-1007-4221-b0b7-734460610b8c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2322), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("3f6064cb-90fd-48b2-b128-fee879777d49"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("a303d13a-471b-4d23-aaa7-7d3a273bafc5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(2552), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("209d6262-4b5d-476b-a1e6-769ed8813231"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("7d1aea09-fee1-4336-ab0a-a98b490e46fc"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("35394f08-a66e-4964-aef3-38a1e5aef274"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("b1a29efa-1c21-44c1-9e36-214767fb3685"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("f51dc0b7-1ae9-4906-ac57-1571f17548c0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 652, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("f2fe24ff-b255-498f-8f98-dc47e56a5ecf"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 648, DateTimeKind.Unspecified).AddTicks(7881), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("0ad94c51-cb57-426e-9e55-3581888cd3d4"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("ccf49725-931f-4127-b24d-1ec5f3d59f77"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("e142e3d9-931c-4ef1-a78b-2c27c14e4faf"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("1c12af1c-7266-41d1-a5ab-6d141168cb06"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 648, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("327d79f1-08da-4d04-b9cb-3051c8c05491"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("f49ea6fb-3e86-45cc-99e6-b6e82be75362"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 649, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("1b565567-7286-4a10-bc5a-a00fd32ba2c9"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "CreatedBy", "GuidRecord", "LastModifiedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 3, 3, 11, 2, 37, 647, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 3, 30, 0, 0)), null, new Guid("fbceb78c-2a1f-427b-b81e-02da06b8c058"), null });
        }
    }
}
