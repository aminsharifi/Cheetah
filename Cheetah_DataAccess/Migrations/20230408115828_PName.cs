using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserSkill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserRole",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserRelatedLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserLocation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserArea",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_RolePosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8829), new Guid("17301fc2-856f-4093-b31d-313ba6d2445c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8845), new Guid("319ed47f-05e4-4971-a2e0-262904659e5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8912), new Guid("9b67c0ae-74e1-4ec3-9bfd-d54c366546f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8921), new Guid("e37afac0-d792-4bba-a0c6-874867fedc3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9714), new Guid("f307bcc1-6200-480b-9226-41d35ea75a0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(20), new Guid("4652b777-6623-4711-b79e-73076f476504") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(41), new Guid("7f8d3988-cd9f-4f62-bdb7-38f14cd33ab9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(53), new Guid("98e20a8a-282a-4eb6-8f11-f17e54eb4cfe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(82), new Guid("c8a8bdc6-ae85-4191-83dc-8658935c7cbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(95), new Guid("2c35745b-226f-4f8a-b641-9377ca882885") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(108), new Guid("922c51da-284c-4fd4-86c1-c19709eaa43a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(121), new Guid("65c35806-782a-4156-934f-a5f7a7373516") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(133), new Guid("a21a170f-3c7f-4e1e-9255-a7ecfa470dfa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(146), new Guid("93865890-248a-4d1d-baa8-aa065f9b4556") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(158), new Guid("c30e4990-20e4-4ddb-a01b-cfc722c97bed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(170), new Guid("965b0dac-62f9-4e72-87d5-7392e852b8c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(187), new Guid("2921cb67-27a7-4761-9f93-da57e906d04e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(200), new Guid("d391a44f-5926-49a7-907e-c77f8ec676da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(212), new Guid("90919ad5-e0e9-43e1-a63c-3173fa4221bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(230), new Guid("1ecea76c-b95d-4b08-b9d5-5fdb66baaae0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(243), new Guid("908ed0e9-ed18-4bcd-9605-29204f734bb8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(254), new Guid("fc2d4b06-cbda-4e5d-8a63-8043a0ff8502") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(266), new Guid("106e8290-a353-4dce-9375-307d33217539") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(288), new Guid("0532c304-9755-4455-ba71-fd51c677d0a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(304), new Guid("09e21540-f001-4cb1-a5a7-ab25d24dd618") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(317), new Guid("ddcb052d-eaee-4b5f-80b4-add5d0bec480") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(329), new Guid("aa84ac43-2114-4d92-b4ce-d04972eadac0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(342), new Guid("c68b3518-5690-45f8-8d47-b08bcec8d128") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(354), new Guid("0708c74b-44d2-4288-bcce-41dfa8cbe887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(366), new Guid("bb8f700d-95bf-42eb-b426-47be6c1393b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(379), new Guid("217144ce-4f1c-4a74-9585-a453c7693a3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(407), new Guid("071dcc02-6862-40e3-b749-0aa7ce0591fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9053), new Guid("1a3001d6-8855-4b61-8907-d8ef4f0ae470") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9062), new Guid("c27c1faa-d1bf-49e7-884a-b0faf06310f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9069), new Guid("f98c47fd-8116-4e9e-a603-9f14b10eb397") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9084), new Guid("e4adced2-adbe-4fa3-8e8a-4da34baae001") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8961), new Guid("65ea25ee-cce4-4e16-9eae-0a6ca8b8aa4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8997), new Guid("de51df95-c355-4b19-8588-13f331039fd5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9004), new Guid("cdf0c0a2-233a-454f-95d1-6abbfca0975f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9138), new Guid("5639dc56-dfc5-4482-bb3b-cb292232ef01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9217), new Guid("f162964d-7728-44ae-994d-29d05c8f293b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9226), new Guid("28c0b266-a59a-4abe-8438-ed5e57dead22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9233), new Guid("56c8b7b6-14f6-4b88-b1e5-755838a7661f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9245), new Guid("24341174-35a3-4f6b-87be-4cd18ab4c0a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9252), new Guid("e94753a1-197b-4640-9252-7aee8121f98e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9293), new Guid("865ca2fb-8ec7-48c4-90a7-f6a0ad424a2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9301), new Guid("048a8a61-e9af-4133-90b8-57a2145607ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9309), new Guid("6aace53e-67de-440b-8040-27c62d40dddb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9316), new Guid("a51551c3-8ca0-46dd-8723-da8c8417b61c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9324), new Guid("20a8d591-954f-4173-9c7f-1fb640317673") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9333), new Guid("cb91cb26-106f-4d27-a1d9-754babd4ff8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9343), new Guid("99e2831c-e6b8-4819-8e21-97664c128327") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9351), new Guid("5a57d792-6827-4348-bd82-72a2da2c06ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9359), new Guid("74f873f2-169c-48ca-9556-a667e4372bc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9371), new Guid("e9600562-45b1-47b5-9fb1-57b02ad3728a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9620), new Guid("a1221abd-9395-4103-9fa3-301596ba50bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9630), new Guid("e48ee690-6ee8-4cdb-bd3e-25f3c9c1da5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9638), new Guid("4e6c4f48-d9e4-4e01-865d-c33c49a3db4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9650), new Guid("ba1872df-8cd1-43d9-b749-8226533906d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9658), new Guid("c65b3084-9622-4014-80f7-fcf160e47dbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9666), new Guid("316238a8-6494-49e2-af0f-af30629816dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9674), new Guid("0cabbfc3-8147-4957-b16f-f2c31a5917eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9546), new Guid("f817a319-4f12-4d00-a873-e302621df183") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9555), new Guid("aba532f6-c446-49e4-aab4-509ff504b9cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9563), new Guid("f5a085b6-7942-4792-8561-9e700e88fb44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9571), new Guid("b6da56c6-504a-43c2-b898-c35c9a3410b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9578), new Guid("2e5e61c4-d95b-42ba-8088-f9fff274b30b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8154), new Guid("f1b31beb-e9e8-4fef-87c2-ea59366ad7a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8296), new Guid("80d92afb-b577-455d-ae68-f7b94cc7078b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(8318), new Guid("746f4f2c-0c10-4edb-938e-31ad0afd8d41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9426), new Guid("9d05f55d-d36d-400d-ad52-61da4e304259") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9438), new Guid("883c07fb-28d4-4315-9c59-884696aa34b8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9478), new Guid("1afcfa37-68a8-47ba-b11e-beb2e37d66e4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9488), new Guid("322d5740-c380-4c66-886a-fb8614f63dff") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserSkill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserRelatedLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserLocation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_UserArea",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Links",
                table: "L_RolePosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_EndorsementPosition",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Attachment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Facts",
                table: "F_AllApprove",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_UnitType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Skill",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Position",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Operand",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_FieldType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Entity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                schema: "Dimentions",
                table: "D_Area",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4904), new Guid("24747454-0e71-4233-b1fd-33fb9bc684fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4920), new Guid("420c5667-42e7-4541-9e84-fc2013220e47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4952), new Guid("4762f0a4-6780-4b8c-8970-926a8567634e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4961), new Guid("a5d48bf7-7a2b-4ff0-b621-4540a821812d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5883), new Guid("d40cb603-f537-4394-b60a-24a0258691e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6118), new Guid("18da25be-11dd-4305-9c91-5f901cc69581") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6137), new Guid("8419adae-daf5-4c06-9aa2-fb75cfce0377") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6151), new Guid("07696eee-7697-421d-8669-f1a9c70d9764") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6163), new Guid("1263b2e1-723e-4365-9cd5-789bf7cbcb4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6175), new Guid("5bb940c4-df22-4b41-8eb9-46cf02b5e044") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6188), new Guid("810c854d-aae6-4c7f-b60e-52fc82420ceb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6207), new Guid("61003fcb-3b51-4e24-b7d3-c38965efc5cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6220), new Guid("90f4d122-904d-4d5f-9aef-8ecb1179d122") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6233), new Guid("149e5343-843e-47ba-89ce-caf765275247") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6247), new Guid("629c47e6-d74a-4d33-9e5d-1f6f0b41c0a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6259), new Guid("cc50808d-75e9-490a-b134-3fc8dae0b85e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6271), new Guid("c2d1135d-de75-457c-a7bf-2758210b82ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6283), new Guid("48b34b08-61a2-4429-9026-221c82d94966") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6304), new Guid("731a3df7-c850-41a1-b8b4-bfc41ee7a663") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6329), new Guid("0cf045b9-a26b-45e3-acb4-87d76818f887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6341), new Guid("9aed5c42-dda6-47b7-8d53-3317dd551df8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6352), new Guid("b32c53b3-dfdc-41a9-a256-f2ccf48aca79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6364), new Guid("39b54d15-2585-4baf-bbb5-333113e0c3cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6376), new Guid("5cce1d45-7423-4b44-8d01-c3a61badc6cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6388), new Guid("baec47e8-1368-4882-9d5b-24d6b30fdf5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6630), new Guid("39a62427-c95d-4af2-a67d-4491746fe210") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6657), new Guid("9715d98a-4959-4f6d-92d5-450b6e366af1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6675), new Guid("865b0e40-08e6-4e9f-9747-cc6944b7ab89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6687), new Guid("8a9020d2-a627-456e-9dae-cc2c9ad12afe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6700), new Guid("bf515837-309b-41a5-ab47-22f648d5c9da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6713), new Guid("d7fef6dc-bf8b-4ab1-a298-83513ed14f0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6724), new Guid("f82cebdf-dc2b-4fdf-bd57-64d436610b1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5099), new Guid("6175ecf9-d56d-4045-888f-d16a01284e21") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5108), new Guid("670240d5-e66d-43b8-8bf3-35c1875940e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5115), new Guid("cd2c5e07-4a6e-41a2-82ea-38643309abdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5127), new Guid("32cba0e9-9df2-48a8-b761-de0ff81e7154") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5012), new Guid("d0f0d642-41ae-4de2-af92-568aee45dbe1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5052), new Guid("934cecec-edf3-48eb-9b5d-3d24a9f8016b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5059), new Guid("149a0613-140a-4427-b7f1-69c1fa2788c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5164), new Guid("dc940afb-7c02-4cf5-a73e-dc4b911541c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5284), new Guid("6f8776fd-c52f-49f2-b5e2-472fbab3f8e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5293), new Guid("d5ee53af-17d2-4d9a-8c93-4dbd2c22fc2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5301), new Guid("30c9a08e-09b9-4040-9af9-f8ee63fc13fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5308), new Guid("a30472b5-3edd-4bd2-bdec-cce0a45d1dc1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5316), new Guid("5e729bca-fabe-4a13-b325-65dc2a8c9871") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5361), new Guid("ee5e9374-11e0-4cde-bc1b-c6f18d8b03b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5374), new Guid("73876be5-0006-4ca4-83ba-bad23d50c7e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5382), new Guid("1d104f77-bee6-4b33-9592-5f6174f46ec8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5389), new Guid("0a795761-b3f0-43df-a71f-0b6ae4494caf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5397), new Guid("e6037e40-ee4e-437a-82f4-72a083429ee4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5404), new Guid("d2f9ae1c-f5a0-49d5-91df-92b855458c93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5412), new Guid("37dcf670-a3b8-4345-afdb-ae063d60d8e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5420), new Guid("3e92c48a-f017-4cc1-a083-19e743707519") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5428), new Guid("31ee6e0b-cc54-4c21-aafe-e1c555badb7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5439), new Guid("4a76e5b5-0ad3-4b0f-b271-5311b3441802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5780), new Guid("7299df42-6de0-4a43-a23c-7305ae8af2c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5791), new Guid("c0503a9b-8e1c-43dd-b117-399e0af71185") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5799), new Guid("4ecb09a4-95d4-4129-89ad-d6d27c688db0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5807), new Guid("8ac21161-7da6-405e-bd61-a6b1cac87e6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5815), new Guid("2c510408-b190-434a-8007-12dd9b664d01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5824), new Guid("da5f2f53-3b4e-451c-9193-b0e841890b32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5836), new Guid("f4662974-ce84-45eb-a196-05a42ba25429") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5685), new Guid("5ea3540d-8f70-437e-8854-e0bbd8a0e52d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5694), new Guid("16fe2d82-541b-4c25-b80f-fe27f4fed95f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5702), new Guid("80a53490-d670-4c39-850d-389a393d98be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5713), new Guid("4d8a4db5-12ff-482e-b3fe-f80ea7253f07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5721), new Guid("01e92d75-b372-4403-8103-6d70f2b615be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4331), new Guid("27ae765d-98c8-41ca-9a45-20cbde0c7691") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4479), new Guid("2babc751-ab36-497f-b8e1-50b61b6b4af2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4488), new Guid("c318e76f-4bee-4e56-858a-2927284b18be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5568), new Guid("3851c92f-10d4-4314-a584-5f7bdc846459") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5580), new Guid("922eb61e-dea4-48e6-bf77-1394190d3dd8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5634), new Guid("95507873-47d6-4b81-85e3-6398e1d3b73b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5644), new Guid("7fe82c02-b566-4fce-9d9a-fb3b02824912") });
        }
    }
}
