using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingOrder : Migration
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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<byte[]>(
                name: "UI_UserPicture",
                schema: "Systems",
                table: "S_UserInformation",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.AlterColumn<string>(
                name: "UI_RegistrationNumber",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(215)",
                maxLength: 215,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(215)",
                oldMaxLength: 215,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 113);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByEmail",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByCell",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<string>(
                name: "UI_NationalCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 109);

            migrationBuilder.AlterColumn<string>(
                name: "UI_LastName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<string>(
                name: "UI_InternalPhone",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 111);

            migrationBuilder.AlterColumn<string>(
                name: "UI_FirstName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactEmail",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactCell",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UI_Birthdate",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 110);

            migrationBuilder.AlterColumn<string>(
                name: "UI_Address",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 112);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "User_UserName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<string>(
                name: "User_LDAPDescription",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "User_IDPersonel",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<string>(
                name: "User_FullName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "User_EnabledForAssignation",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<string>(
                name: "User_Domain",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<long>(
                name: "User_DelegateId",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 109);

            migrationBuilder.AlterColumn<bool>(
                name: "User_DelegateEnabled",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "User_CreatedCasesSkipAssigRules",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<long>(
                name: "User_BossUserId",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 108);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ShowSupport",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_RemoveRequestorApproval",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ERP",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_CheckList",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_AnotherRequester",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Transcript",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_SendAll",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_SMS",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_NeedApprove",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Mail",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Automation",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<bool>(
                name: "PSO_Independent_Location",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_RequestFinishDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_RequestDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<byte>(
                name: "RI_PE_Level",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_OldDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_NewDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_LastTimeModify",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.AlterColumn<bool>(
                name: "RI_IsCancelled",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<long>(
                name: "RI_ERPID",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsTest",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<string>(
                name: "StringValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<float>(
                name: "FloatValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "BooleanValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<bool>(
                name: "CPE_Active",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ATC_Name",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ATC_Data",
                schema: "Masters",
                table: "M_Attachment",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101);

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
                .Annotation("Relational:ColumnOrder", 51)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 52)
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
                .Annotation("Relational:ColumnOrder", 53)
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
                .Annotation("Relational:ColumnOrder", 54)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "APV_Subject",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100);
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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserSkill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserRole",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserLocation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<byte[]>(
                name: "UI_UserPicture",
                schema: "Systems",
                table: "S_UserInformation",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 108);

            migrationBuilder.AlterColumn<string>(
                name: "UI_RegistrationNumber",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(215)",
                maxLength: 215,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(215)",
                oldMaxLength: 215,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 113);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByEmail",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "UI_NotifByCell",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<string>(
                name: "UI_NationalCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 109);

            migrationBuilder.AlterColumn<string>(
                name: "UI_LastName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<string>(
                name: "UI_InternalPhone",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 111);

            migrationBuilder.AlterColumn<string>(
                name: "UI_FirstName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactEmail",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "UI_ContactCell",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UI_Birthdate",
                schema: "Systems",
                table: "S_UserInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 110);

            migrationBuilder.AlterColumn<string>(
                name: "UI_Address",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 112);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserInformation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_UserArea",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<string>(
                name: "User_UserName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<string>(
                name: "User_LDAPDescription",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "User_IDPersonel",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<string>(
                name: "User_FullName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "User_EnabledForAssignation",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<string>(
                name: "User_Domain",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<long>(
                name: "User_DelegateId",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 109);

            migrationBuilder.AlterColumn<bool>(
                name: "User_DelegateEnabled",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "User_CreatedCasesSkipAssigRules",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<long>(
                name: "User_BossUserId",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 108);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Skill",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_UserAction",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RolePosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ShowSupport",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_RemoveRequestorApproval",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ERP",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_CheckList",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_AnotherRequester",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Transcript",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_SendAll",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_SMS",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_NeedApprove",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Mail",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "PSE_Automation",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<bool>(
                name: "PSO_Independent_Location",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_Operand",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_FieldType",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_RequestFinishDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_RequestDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<byte>(
                name: "RI_PE_Level",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_OldDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_NewDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 107);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RI_LastTimeModify",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 108);

            migrationBuilder.AlterColumn<bool>(
                name: "RI_IsCancelled",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<long>(
                name: "RI_ERPID",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsTest",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<string>(
                name: "StringValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<float>(
                name: "FloatValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "BooleanValue",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AlterColumn<bool>(
                name: "CPE_Active",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Attachment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<string>(
                name: "ATC_Name",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ATC_Data",
                schema: "Masters",
                table: "M_Attachment",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 101);

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
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 51);

            migrationBuilder.AlterColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 52);

            migrationBuilder.AlterColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 53);

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
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 54);

            migrationBuilder.AlterColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.AlterColumn<string>(
                name: "APV_Subject",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 100);
        }
    }
}
