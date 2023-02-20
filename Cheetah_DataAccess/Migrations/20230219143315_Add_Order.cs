using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserSkill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserSkill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserRole",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserArea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserArea",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Skill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Role",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Location",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Area",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Area",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RequestType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RequestType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_Operand",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_FieldType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserSkill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserSkill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserRole",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_UserArea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_UserArea",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Skill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Role",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Location",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Systems",
                table: "S_Area",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Systems",
                table: "S_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Systems",
                table: "S_Area",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RequestType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RequestType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_Operand",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_FieldType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "DsblRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "IdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
