using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class current : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AddColumn<bool>(
                name: "Current",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4697), new Guid("7e78bcc2-ca22-43bc-a14f-70aaeecea94c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4744), new Guid("e0a48cf4-7201-4f75-8ad5-11ba28348dd6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4749), new Guid("0904c363-3f3e-410d-ad1e-60bc85488bc6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4755), new Guid("6227f4e8-de96-4fdb-bc7c-ccd87f5cc34e"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4761), new Guid("a84a6bc3-25d9-4926-91d7-eecd3c39bb23"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4830), new Guid("dcea122b-274b-41ba-8176-c0a70e999d3c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4838), new Guid("efcd6647-dc1b-4827-8e4b-49db07cd9a42"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4846), new Guid("4af950c9-e438-441c-a71a-ac7712cf2ad4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4852), new Guid("bf427735-64ce-4301-a523-f84af7f54f14"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4857), new Guid("80b2e04d-8379-4f05-8e91-9d1206d06295"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4864), new Guid("2089379b-220e-4361-9679-3febd1b51c99"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4869), new Guid("fee83096-bb47-4a0b-84b9-79fe943c82d8"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4875), new Guid("ddde0e18-ffe2-47ee-8972-711a8535c2ec"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4880), new Guid("4c56683c-ed2a-4c14-b4a9-5632736443d2"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4886), new Guid("a9f075ce-1eba-4a12-b32f-198374a25c1a"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4894), new Guid("37cb36f3-6d56-43a8-b930-142316df7382"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4900), new Guid("962dd10b-2358-45a6-b441-341b9f890f31"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4905), new Guid("6c2bc688-4789-41b4-9c5a-a3c89b32ca5c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4911), new Guid("cf95de0d-565a-4420-977a-d7b66ea15328"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4916), new Guid("e1fee514-a82c-4a97-8a3d-d846a7ca3ccf"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4331), new Guid("3f9bcd4d-7b12-4c7b-9ad5-8df8d03195fa"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4334), new Guid("e241bcba-efa3-4cc6-b1af-5f832ba1d684"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4337), new Guid("fc27a7e3-067f-464a-bc2e-2f5352478c64"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4406), new Guid("0008ff75-236d-418a-8b33-00bed256240b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4412), new Guid("c11f7fbd-f198-4e50-babf-1e410a164524"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4414), new Guid("bf68b41b-007d-4b4e-8c42-9ee95b20b42f"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4417), new Guid("f80a33f2-c30a-4cfa-b9c1-45e8caf15c05"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4419), new Guid("d0b2dfec-97f8-4ffe-931d-5c960bc11a4c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4422), new Guid("630f7f37-4ed4-4114-b0b3-d10dccd14167"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4654), new Guid("2d7b23a4-80bf-4f60-a2d9-446d49dbed9d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4658), new Guid("070eb1e8-b36c-4ce9-b179-9c30819f797d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4660), new Guid("454c7165-4b6e-4656-beb8-2177bef0f023"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4663), new Guid("62d6c990-7b67-49e5-be93-abbe7d479ee3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4666), new Guid("346c45f1-f642-4ac1-9bc0-36383f74f989"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4668), new Guid("bc682979-e48b-4738-9e9d-bfe44e8f6e46"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4673), new Guid("701e3ab9-e0b6-4940-b660-cbf72c52fa67"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4037), new Guid("24a21a9a-46e6-434f-9456-2124c245f4c4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4087), new Guid("f6365af5-fa60-4da5-a367-797dc5aab768"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4090), new Guid("a585f0e9-712f-41fb-9119-61ef656fde21"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4295), new Guid("a38e9629-e24e-469c-bbaf-a19ba332e3eb"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4300), new Guid("4629301e-8b46-4a68-bd1c-60f9923ac209"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4303), new Guid("b18ca8e9-9f42-449e-b751-ee2a0a9e3735"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4305), new Guid("5d66d839-1443-4345-920f-f58d35aadd4a"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4613), new Guid("6a5e79a9-7da2-4bc3-b936-1723dae61412"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4616), new Guid("f8bb6bce-35c9-495b-a978-df94ea8c5548"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4619), new Guid("0331604b-b59b-4b31-aebc-c342bcd2ee87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4624), new Guid("b202bf81-ca86-4c12-98e7-42cb70c7568b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4628), new Guid("dce7f1a8-06e5-4b67-98a4-772b397f86f7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4488), new Guid("93865aa4-6e21-4e90-a3fe-dae35b5c5b06"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4492), new Guid("602867ca-85c4-4a9f-9fcd-1ee9707362b1"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4496), new Guid("0ad0e701-a1d3-4f2c-a294-67f404d23698"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4498), new Guid("5f87d533-b0a1-4bb8-9361-77fcf57b1cc6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4501), new Guid("d09142fb-556d-484f-a039-aa534c2152b3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4504), new Guid("dfc7993a-dc36-4888-ac0c-6145aba6e2a3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4507), new Guid("b3cf3646-f1a7-4c43-84d7-60e6470e6e82"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4511), new Guid("b99afb6d-a04a-4a09-b9c2-e727d4e87a57"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4514), new Guid("b5e984ce-c77b-4b29-a81e-52564295ce87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4517), new Guid("950c8255-1b14-4397-ae74-8cf99045af18"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4454), new Guid("54f79a2b-5a56-4992-9006-b2a98f0e0359"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4457), new Guid("5f902432-3f1a-41bc-85f3-9affece01cc4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4460), new Guid("732d1dad-5635-430f-a63b-18a89c2a872d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4464), new Guid("d11e4742-9e57-4096-a345-47d40ca8576c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4543), new Guid("5f7c2a7e-f599-404f-bd18-4714a6b927b7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4546), new Guid("ce69fba5-96c2-49d2-a587-bc88f2f4789b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5028), new Guid("47341d46-eb56-4ad0-8a68-933d4f4c82bb"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5036), new Guid("e1105e6b-1a2e-419f-af73-e7e64023fc09"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5039), new Guid("42367457-cac4-47f7-9da1-1b4635bfaa74"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5042), new Guid("a7a0c349-6efb-4af3-a67f-33d17192cfd7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5045), new Guid("c34850a3-4912-4fe1-af24-92981c0729c4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5069), new Guid("87eee395-7c82-42f7-80ec-9eeb837a0e56"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5073), new Guid("e2ad9229-05c7-4936-9c49-ecc816a0df3d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5076), new Guid("b5825fe9-0864-4c80-b5cd-0a157633c0da"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5082), new Guid("77286fda-7caa-497f-8280-1fdf51a8aa18"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4994), new Guid("e2109e8c-8e09-4425-944e-a47c5398ef9d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4998), new Guid("53d36338-b5ec-4171-8f97-f7a7a2f68c60"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5001), new Guid("722940a4-d256-4ba8-818c-0ab300146013"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5225), new Guid("bd3dc3f2-aa1c-4602-b5ce-f267c5f06072"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5229), new Guid("b37e4a22-ff21-4b3b-b574-184f2125a218"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5231), new Guid("98daaab0-f097-426f-a796-a8cda0dfbb90"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5234), new Guid("4df770b5-94ba-48f3-bfff-227feac5c606"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5239), new Guid("1cde15d0-8373-4941-973f-6e82c9184696"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5140), new Guid("75e61570-23ea-46f0-a394-b5244dd2ca87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5143), new Guid("adac8cad-d2c1-4761-b513-9470e8ec71c3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5146), new Guid("96ceed5b-d82d-46af-a589-35c696cd9012"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5151), new Guid("e3a251eb-949b-4243-a152-b288f35bb966"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5193), new Guid("91063d60-2b3b-4cce-be9e-a7281dae66e1"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5196), new Guid("efa8ee8e-39a6-4701-aaf3-0bc1f6fc2e70"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5199), new Guid("831e0f62-1933-4db2-9269-0311cfd226b4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5111), new Guid("77e43a2c-5f89-4955-8ab0-66e0bfc27f6e"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5115), new Guid("e96c9227-b911-4082-853a-c538a3122b67"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5117), new Guid("4ab4f1c4-b43e-4766-9131-5123efd98246"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5120), new Guid("2ef71d0a-9614-450c-aa3f-68686675d88c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5262), new Guid("3956909a-594f-40b2-a7f4-7442473f6543"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5265), new Guid("04f02903-eae4-4619-89be-c62c06c8d6fe"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5265) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Current",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3059), new Guid("a0823077-613a-4ed1-be70-834f230c2a73"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3110), new Guid("5e1a733e-8a4a-42dd-b241-bf1937e51602"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3126), new Guid("8739f5d7-7302-429a-96ee-786678cc25ec"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3138), new Guid("eac403f0-7d6e-468d-9c76-a211fe5fb679"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3149), new Guid("94a5245f-d92a-430e-ac1d-d521292a7576"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3159), new Guid("f62972bb-21a2-4790-aba9-2a3d27370a93"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3168), new Guid("0aebc7b3-8da0-465d-a567-013c2b5b4295"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3177), new Guid("979710ef-625e-4206-aa2c-e037ad41ceeb"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3185), new Guid("24487147-5809-4334-be2a-a8f50bf455ab"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3193), new Guid("33c5ebf5-5c6b-4a8f-8d5e-3b7e90539a48"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3205), new Guid("c0bb519c-1eb1-4a2f-8499-b4089e891e09"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3213), new Guid("dac83484-92a6-499b-a18d-fef12198e651"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3221), new Guid("dbf179ba-6675-4a5f-a02f-048e6b1ff1d2"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3305), new Guid("90849b1e-ae30-473a-b516-cd87518d4673"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3315), new Guid("9216d5bd-c620-46aa-b78e-332045095284"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3328), new Guid("31019f0e-0341-4092-b098-d3b315dad8d7"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3337), new Guid("0884edba-7d50-49cd-8f31-de01f43d9ecc"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3346), new Guid("563bf13c-5def-4318-a9e4-013f0f22e232"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3358), new Guid("3c04b009-dc90-4c65-92b8-cdd141410daf"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3368), new Guid("29e4ba7b-d90d-4ed3-bad9-9e06f1d5b45c"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2455), new Guid("ecc2870b-2d76-466c-aa2b-9bedec01627b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2460), new Guid("0df8dbc7-13ec-426e-92e3-2175720d5ad5"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2464), new Guid("4b74946b-32de-48c6-8cb3-e35e604d8159"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2504), new Guid("79781119-d0c5-482d-8e5e-174f098c106b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2509), new Guid("b6561731-8d5d-4cb9-bb4a-dc2d8417907b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2512), new Guid("3b3e39fb-a601-4148-9883-003836672c1b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2516), new Guid("1814fa10-2840-4e8d-bee2-7beac028dc9e"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2524), new Guid("e26df5da-1edb-4f53-9ee4-e0fecb34bec7"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2557), new Guid("cd9df75f-0381-4319-9033-c051cd61ac35"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2916), new Guid("a59a6a6c-fbba-4b8c-b1e5-2a8226e1370b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2924), new Guid("80b95f90-b2a6-4ad9-a5a5-7a23167eb8d9"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2929), new Guid("e9c6b603-ca70-4a1b-96e2-34b99826531a"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2933), new Guid("fdde8764-6b20-4bf4-9359-c380b69be7fe"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3010), new Guid("5ea63a40-ecf7-4849-a1f5-de627d199df3"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3017), new Guid("a68cec2b-6490-478d-b618-e785889248dd"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3021), new Guid("704448e9-dbd6-4129-88d1-59d3d24f255a"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1924), new Guid("aed17960-4985-460d-a557-14f068171425"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1981), new Guid("32585545-0aba-4678-9d2c-3898c9744b77"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1992), new Guid("185c2d6e-4f25-410f-88b6-f5974769bcdb"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2370), new Guid("6bacb3d9-af0a-45f2-84b6-55f3616d35ad"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2381), new Guid("6824f799-b672-47d5-80f7-29fb726f9664"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2386), new Guid("e6408ffd-5774-4285-8b38-e96e5176e871"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2403), new Guid("c197dbc6-f807-4c4e-805a-82228f77dfcb"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2865), new Guid("e3810836-b02b-40d4-944a-b67c5cb2d309"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2871), new Guid("8f57295e-a48d-4777-8ee1-4be9597dd894"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2875), new Guid("43d7eb8f-6397-45a5-8d1e-7b76d03bd2d7"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2880), new Guid("3fc07dd2-1550-48e4-a2e9-5206706e090b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2885), new Guid("d223a04b-9c05-4d89-a101-e9fa000ef2db"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2656), new Guid("99dd33b9-48cd-4783-94bb-70016de23b0a"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2662), new Guid("994d33bf-b08e-4a60-bb10-9aa15c48cfd0"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2737), new Guid("60724207-6003-42b7-8092-d81f82601bdb"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2742), new Guid("77d8696f-c40c-4866-a487-c6f345f1d49f"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2747), new Guid("06b3d31a-9a3a-4e35-afd8-d1a73461c364"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2751), new Guid("9cfa1f70-469b-44e0-ad62-2e3a26aae40d"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2756), new Guid("1e5803fe-cc69-40e8-b16c-0f3fc6507694"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2760), new Guid("3b8938e2-7717-4998-9c12-6f54c66a4334"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2765), new Guid("3be4636b-553f-48b3-90ea-3b78537d1a38"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2769), new Guid("1ed6586d-da85-4d6a-adae-5367c489d276"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2610), new Guid("42ea5c2c-abad-4969-b41f-ad07022c1f10"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2615), new Guid("748d6c8d-7a75-493d-a0f2-1aea13ccc975"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2619), new Guid("923df248-da80-4452-af4c-c998a358401f"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2623), new Guid("bee42bcb-1dab-4e3c-9ef7-dc88e2f586d1"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2824), new Guid("948a1e50-af9e-4e10-93ac-5be4ac58faac"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2830), new Guid("f0c7b6ef-6a8d-4f6d-9d3a-3eccc8a17bd1"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3473), new Guid("12e313ba-cd69-47c9-ba6b-b22e2f3ed992"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3481), new Guid("c7cc8867-00fc-4c27-b09e-25722ab11bff"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3486), new Guid("1d2330dc-7cea-48d1-b464-9ce750769607"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3494), new Guid("6f7a023f-6ceb-4379-9d41-7c100fcf8f53"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3502), new Guid("516ec6b9-7b26-42cb-8ba5-ce273a522009"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3605), new Guid("bea6a310-9bb8-4d0f-a40a-29daf7dd6bc1"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3613), new Guid("19c103e3-5453-4697-8547-fa47bc64c8f2"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3617), new Guid("851f58ec-1318-4ad9-88ee-edabb76a08b7"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3623), new Guid("c10ab6ed-37d9-4084-a83c-a7e63f027c9b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3432), new Guid("6c9df2f2-2caf-4851-9410-c28dd0a042fa"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3438), new Guid("615ef805-9156-40d4-8de0-94e355a2364d"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3442), new Guid("3207d1b6-e5c3-46d2-a296-74912e2d8e75"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3809), new Guid("ed2b1cf0-c408-453b-b48c-c6af6c39bc15"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3814), new Guid("37aa985f-a456-4cb4-bd8d-037216258350"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3818), new Guid("11ae471b-eb9d-4e54-b6ee-37e128560093"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3822), new Guid("6d77cb8b-1857-4842-8b78-6460d7a1fafb"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3826), new Guid("a30915e5-06aa-4c0b-bc04-ddf9f5bd3eea"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3713), new Guid("9bac53f1-168b-42ff-a5da-c50461413a43"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3718), new Guid("24f73a06-5374-426e-b3a5-8fdf66763502"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3722), new Guid("0b95951a-1c6e-47af-a405-f7d3469335f8"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3727), new Guid("d936cd87-a7ec-43b6-959f-693049e53fc6"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3732), new Guid("a928a876-0f51-4c9d-933a-1b033de85b1b"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3737), new Guid("d8a23bec-51c2-4c77-b11a-b95875b3e196"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3744), new Guid("e0215b71-d7ba-4af9-93b3-c99e9722a8a9"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3664), new Guid("d97f15bd-9466-46a1-87dc-b17c73eb78e1"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3670), new Guid("33b131bc-f7ab-4f91-96aa-7f330a6e1b01"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3678), new Guid("60711210-455b-479b-a674-2e32d1c26e8c"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3682), new Guid("1b901c06-49e9-48ba-81b6-648076df243e"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3861), new Guid("6971b8e0-13b0-4878-97a6-ba04318e99cd"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3867), new Guid("25b0a662-c2a8-429a-a02e-7f7c12f15a3f"), new DateTime(2023, 7, 10, 10, 7, 52, 316, DateTimeKind.Local).AddTicks(3868) });
        }
    }
}
