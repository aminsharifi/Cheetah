using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Scenario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Strategy_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_L_Process_Strategy_F_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy");

            migrationBuilder.DropTable(
                name: "F_Strategy",
                schema: "Facts");

            migrationBuilder.CreateTable(
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Scenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Scenario_F_Scenario_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1114), new Guid("b19d29d4-562b-4601-a5c3-af634c77a652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1391), new Guid("9260cc3a-4adb-473e-a540-23bd55e409c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1467), new Guid("087ba5d1-76cc-4fbf-85d1-2f54e9abd395") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1476), new Guid("588dd2da-dcc5-4191-a65a-3f7380fd0da7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1490), new Guid("98d15b8c-78cc-4a17-8551-727722955f4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1501), new Guid("5016b12e-4680-431a-ba4b-99f8d8d3e1cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1509), new Guid("8eccbb2f-546c-4ccb-aaec-e508c732329e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1517), new Guid("89f65dae-a1c4-4418-8502-8c5fa10788b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1527), new Guid("db2fbb53-a332-4257-b092-8e0393e80b8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1535), new Guid("0ffce2bd-24d7-4033-9a91-26b504598c7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1543), new Guid("b5989e2f-5569-4062-b2fe-06fa3aa7ab80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1551), new Guid("3a6c23f6-fd5b-4f55-ba4a-03870488c8c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1562), new Guid("ca75991a-c5fd-46b9-a7c3-06b0eae94a5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1573), new Guid("af2a2260-2502-4cd9-9999-37a7a29548bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1580), new Guid("f52e24ae-bedc-41c8-9c90-eb85230dc728") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1596), new Guid("224967af-705c-475c-aef2-69b1700dbc18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1604), new Guid("2a9434f5-bd5d-4d6f-b7e6-7122c41cb500"), "راهبردها(Facts)", "F_Scenario" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1621), new Guid("ac28346e-20cc-41f3-9d97-4daadd084098") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1629), new Guid("ddc0a612-6006-4f65-8db8-d719759cdb75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1637), new Guid("d8346a7b-db91-4cc5-b4a5-c53997ef2804") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1646), new Guid("b0b21dfd-afaa-48a7-961c-cfac2f19db38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(19), new Guid("5bc7ad04-0e54-4710-a347-55de8403b31f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(50), new Guid("64346d1d-1052-4c92-9698-37bf44b20171") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(58), new Guid("7c41bfc3-9eb0-4e6a-84d1-9bdcaedd4ac1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(253), new Guid("250e28e9-a8d4-4f50-9a5c-d932bdbd6caa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(276), new Guid("398963d4-1871-416f-bf11-64ce1ec4cc97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(281), new Guid("d10d35f9-fc16-48ce-b045-36d25e384f68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(287), new Guid("c298da8d-c2c1-4794-b23c-90a516411b87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(291), new Guid("c596c310-8f4f-4cf0-98a9-47df4a7265a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(361), new Guid("72328ce7-94bd-49ba-bfc4-0de348d3108c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(991), new Guid("38797bec-8150-4db6-ac55-61c7109a31a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1001), new Guid("90ee4420-6d5e-4a9d-8b9e-0291e7f97b23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1008), new Guid("a4f2dd6e-d8b3-4269-84a7-53615cad7cc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1014), new Guid("d7c918b3-f1cf-4d90-bf21-bc21cf6af84f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1023), new Guid("41134b98-98ff-43fd-a618-9801155f513d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1031), new Guid("5239b1a5-1970-4e60-b1ec-69c7822d9677") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1038), new Guid("ebca0757-4c5e-4c79-98e3-b6f37fd28b10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9555), new Guid("94d909e6-6dff-4618-ba0a-649d64e8f80c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9696), new Guid("0e9c5593-29a5-4ef3-ba2b-da73aae470eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9702), new Guid("0fea1f21-b087-421d-8411-dee59349d11c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9954), new Guid("c76a3fa6-fe64-4d57-8f8c-1be49edc0a8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9964), new Guid("bdec3e32-7b71-48d9-853b-7e618a4be7c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9973), new Guid("3d98253c-e117-4c37-a4f6-f73308a98794") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 432, DateTimeKind.Local).AddTicks(9978), new Guid("376ac75c-666d-468e-9bb8-6d3d481f9bb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(839), new Guid("3d1b4b50-c6c8-4f95-a09f-b79078c8b9d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(882), new Guid("56ab3eef-ccf5-4ead-8ab7-1a96b0b12dd9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(898), new Guid("f249237c-36ce-4781-9637-cd557e99ea64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(905), new Guid("eb9eeb01-49c8-40d6-af43-ee2516b88be0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(914), new Guid("2c5efa12-087a-4610-a040-89a10f78f4d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(504), new Guid("c2f34c4e-ffa1-4926-841a-b55e33dffb07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(515), new Guid("71374bec-7443-48f2-98c8-75595ab072e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(525), new Guid("08f90f7c-880b-491a-ba15-06ee8ac38179") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(532), new Guid("beea740e-7adb-4fca-8493-131a472bb7e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(542), new Guid("a5cb2171-1973-4989-bd14-ae2220069224") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(556), new Guid("ad43864b-10d8-4e39-a27e-6b14d3f05f4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(563), new Guid("efc4eaf2-9aac-4ca1-be0c-5d107f831c7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(570), new Guid("712bf478-ecb5-415b-a570-3494550b343c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(577), new Guid("9be96fd3-0c14-4e87-859a-77da9b7b001a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(584), new Guid("505a1f26-d259-49ba-a2d6-4c50f54fd350") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(443), new Guid("0f00228e-dd73-4033-8566-609011acd080") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(456), new Guid("5c0a3070-f5b3-49c6-819a-8c3489efba3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(461), new Guid("94812d8c-06e5-48a8-b274-8d38eff8aebc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(467), new Guid("f775316b-d908-4162-b810-dbb957329de9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(720), new Guid("20a79562-5cb7-4b6f-bb7c-6e9a55b54646") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(761), new Guid("51ab16c5-c4e6-4682-9d58-4ae7075e2036") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1799), new Guid("40162e20-e969-4773-9617-59497cdb9126") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1808), new Guid("0bf4aa0b-f94b-4ea7-ab18-2500d2a42975") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1814), new Guid("ce55d8a5-131d-49c6-815f-dd3ed523befd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1819), new Guid("82a24bc0-5e6b-4470-9761-e2296c297adf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1846), new Guid("cd3c93f3-7720-441d-9bf2-efa2b976c37a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1856), new Guid("00f3a941-846c-4c06-9f33-2509fe2583ff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1862), new Guid("b3c74944-ef7b-4837-a6f4-a5f8087786d2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1867), new Guid("7ec18b2f-adff-49c3-8032-523e869d4c9f") });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1748), false, new Guid("f7e3ae15-b780-4800-b465-f001e526436e"), 1L, null, "سناریو دارویی", null, 1L, "Med_Scenario", null },
                    { 2L, new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1757), false, new Guid("003a4751-c156-460a-b420-6a7d627a2a52"), 2L, null, "سناریو مصرفی", null, 2L, "FMCG_Scenario", null },
                    { 3L, new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1762), false, new Guid("cd388289-6cab-4672-889f-b51405f0a085"), 3L, null, "سناریو ستاد", null, 3L, "Head_Scenario3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(2046), new Guid("9c772f23-cbab-47c7-bc36-2ea4f83dfb67") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(2052), new Guid("32880b23-59d3-48a8-b7d9-7127f34d5a7d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(2057), new Guid("11c7a601-e7bf-4e16-8d90-f2a111b173c4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(2062), new Guid("eb109a86-50ee-4d31-9583-9de929dc0af3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(2069), new Guid("51c89b57-db2e-4799-8c73-8728a1d5aae4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1947), new Guid("0530f165-fa14-482e-bdbf-24cfca5ad895") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1955), new Guid("4775a993-813f-4514-9a1e-47d9b7483c12") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1960), new Guid("f2328f49-e2f0-450b-9fb8-a22edc1cdb8a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1967), new Guid("e00b3ca1-d593-4047-8e58-863e4650624f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1972), new Guid("955181b8-3fb1-4fff-ab3c-46c449314202") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1976), new Guid("b493b38b-70cd-4ec4-846d-641e88f6929a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1982), new Guid("8687a6d6-f9f3-4e62-91c7-55ccbb07dfb7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1899), new Guid("a338d235-148b-4563-95a0-afbb60404791") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 2, 23, 433, DateTimeKind.Local).AddTicks(1923), new Guid("57934cf3-bf04-4f20-83d1-fc3af0b111d8") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_CreateTimeRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_DsblRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PIndex",
                schema: "Facts",
                table: "F_Scenario",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PName",
                schema: "Facts",
                table: "F_Scenario",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Scenario_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_StrategyId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_Scenario_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_StrategyId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_Process_Strategy_F_Scenario_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Scenario_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_Scenario_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_L_Process_Strategy_F_Scenario_SecondId",
                schema: "Links",
                table: "L_Process_Strategy");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");

            migrationBuilder.CreateTable(
                name: "F_Strategy",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Strategy_F_Strategy_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Strategy",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1161), new Guid("ea73b813-38e7-48ac-925c-bbbb9604f876") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1311), new Guid("ec0d1be0-6895-4b29-802f-287be09551fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1324), new Guid("25c93fb2-bf33-4d0e-a392-299dd208d644") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1332), new Guid("00e25ca9-c6e2-42b5-b7d7-9bb7d8d76b99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1343), new Guid("7b9c0606-c906-4237-b4e5-ea6b9b13693a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1351), new Guid("70d32fef-9cae-4677-b942-eb6d3129d610") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1359), new Guid("831351a3-cf07-47ee-b4bc-e4c841b52c77") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1368), new Guid("e044134c-80bf-4991-ac35-4f0e9a60a190") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1376), new Guid("d822acd0-6512-44fb-a01f-663910c3e2ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1384), new Guid("1de95e83-d201-45ec-b342-ee18f1304b56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1392), new Guid("c40e0a51-3ee3-4d0f-8982-d6e1586b03f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1401), new Guid("0968ae97-f0b9-4fd7-a440-8a43e6cb52c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1490), new Guid("40d269bb-1c08-4ef1-a321-c849ef6e3ed9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1499), new Guid("297eb53d-fe6f-4940-a736-6efad3c2f5f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1507), new Guid("2be38490-706a-409b-a0ee-dbffc1347a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1516), new Guid("74e49466-e908-4363-98d4-8480761da3a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1524), new Guid("3167f568-000a-4afc-a516-3621f19adb8f"), "راهبردها(Dimentions)", "F_Strategy" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1531), new Guid("625a1129-47db-4c91-a7e5-b4fc78fb1d23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1539), new Guid("31a65e00-5b49-4e62-ae54-c654af5f289b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1547), new Guid("a814688d-7fce-4157-9fb3-05af5d58d041") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1556), new Guid("5fcf180d-7cdb-4087-900c-a63390cd8b9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(766), new Guid("1d8b9f88-44a2-4cea-aa8e-0a146bd0209f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(785), new Guid("3bff73c5-588b-408c-aa8e-ff8e45813cef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(790), new Guid("0d9ca05e-3713-4d9b-8432-9b383a3b0b3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(816), new Guid("7faee70e-04f9-4c0b-97d0-48924a163b05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(821), new Guid("49054676-ff69-4a5b-b47c-b6371ee162f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(826), new Guid("0a14be59-1923-4314-ac20-f8bd7ec23cd3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(831), new Guid("b338a0e0-4ecd-464e-844a-8cb385ff0e93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(835), new Guid("8f7bd6c9-de6c-4a49-8ee4-bcda8bd120c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(840), new Guid("9a08e3ba-3e74-49ab-a99a-478eb7fe3071") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1093), new Guid("78c819f9-3e3d-47cd-967a-baf4c726bb39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1099), new Guid("a25e5dbc-0972-4ded-a038-985faec7e49e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1104), new Guid("aa0a80cf-d54a-4192-b25e-17984d4aea2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1111), new Guid("402889d8-b396-4eee-918c-7a215a31fd06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1116), new Guid("99f4eec6-c99c-489a-933c-580ff240b61d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1129), new Guid("36a8d508-f9f2-457f-ae74-21ab89d42be1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1133), new Guid("23de9158-dc59-4d5b-a56b-26308a0eb824") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(281), new Guid("ef35f296-1c75-42d1-9623-7c0a0aa3822a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(384), new Guid("3a8d48e3-b662-4f86-888e-64b63b9316c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(389), new Guid("9c8e9e64-235d-443b-a8aa-997123e85e63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(720), new Guid("7bc8bb77-d114-4d89-8334-81c7c4da2beb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(728), new Guid("293e4877-16c3-44c4-b6b1-8fb3746257c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(733), new Guid("b592c64d-72f1-4642-a3e8-b164e8e3c2ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(738), new Guid("4d7ae739-ff17-4cc2-83b3-a43cb601c71a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1042), new Guid("577fdde2-5f5e-4127-bc20-66882fcee5b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1048), new Guid("79f122c7-e919-4cb6-811d-1582ca1598b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1053), new Guid("5a571a03-dc92-47a5-ab6a-ed7e6b142dc8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1058), new Guid("a9f796d0-8f00-43f0-8152-c844013c5411") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1063), new Guid("d34e324c-e7d3-47c6-8a89-c607563a28ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(920), new Guid("df38057d-2a78-4e19-8be5-549e92ff7a7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(926), new Guid("43ebc520-2785-4d63-8c8d-a4ae45259ffb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(931), new Guid("eb8070af-8f17-465d-b792-6b6e2e02ef4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(944), new Guid("2e97b12e-8d31-49b2-8cba-7026ee430a77") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(952), new Guid("504597b3-012f-4919-8452-0f4edaf41e80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(956), new Guid("47c1f2c0-3791-43c6-804e-ec9209c2ab96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(961), new Guid("ade4ebbf-896e-470f-885c-219afa1545b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(966), new Guid("bef0f461-1fb4-4bf5-b485-9948eb52f84a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(970), new Guid("e063c7f8-759f-4d4a-9142-bb6853b0f719") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(976), new Guid("c281cc1a-0331-4f0c-837a-39c8c92dc09f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(878), new Guid("bbeb526b-5ff4-4d82-990c-eed3d12b39b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(884), new Guid("41a5a355-937c-42d2-82e1-c6e18bfdccd7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(889), new Guid("eda1361f-a48f-4984-a9ea-168b6942b0a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(893), new Guid("c005df9f-59a6-4930-9384-498599e60486") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1008), new Guid("432949f1-cbca-4127-8d05-8d4c558dd78d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1014), new Guid("dafe933b-93d8-48dc-8f1b-7987076938dc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1649), new Guid("a97c9886-2405-4280-88b6-27de76c4302d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1657), new Guid("1fc6c9f8-f6e2-4e5b-a853-c91c7c48d6a5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1671), new Guid("397a2fc5-cc0b-4dbc-abdf-a6b5c50b5995") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1677), new Guid("41affb62-994d-47f6-b8f7-f4926e07df17") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1702), new Guid("371fc3ef-73d9-4c60-bbbf-f7f8acebd5fc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1709), new Guid("6adad2f6-fdc0-40d7-b108-d159dd521782") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1714), new Guid("34a12c28-189f-4bf7-a920-ec785235dce5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1721), new Guid("b7ac7b66-579a-44ae-b487-35c1c77f621e") });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1610), false, new Guid("2b91ef8a-3816-4bbb-b10c-e81c987e5922"), 1L, null, "راهبرد یک", null, 1L, "Strategy1", null },
                    { 2L, new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1617), false, new Guid("ebb4bb7a-e27c-4d6f-92de-1ccfdbd4bb77"), 2L, null, "راهبرد دو", null, 2L, "Strategy2", null },
                    { 3L, new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1622), false, new Guid("0a794d66-4988-4266-b780-57af770d29cb"), 3L, null, "راهبرد سه", null, 3L, "Strategy3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1830), new Guid("504093d7-bc96-4ae1-926a-5ef28086a517") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1835), new Guid("9c189440-e4ad-47c1-b968-a3579eadda5c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1840), new Guid("45f2bcde-e21a-4a34-afa8-e028359ea802") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1846), new Guid("f4da7880-6149-4f28-be31-981ceeef89f6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1851), new Guid("fa449881-ec2c-45d2-ba2a-33ec43199634") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1772), new Guid("2060d83d-ae89-4124-a351-8526fd42c457") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1778), new Guid("dae4f7b7-f1b4-442b-b802-d6f52ae83aab") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1785), new Guid("05a7079b-18f8-4f00-a329-ff064e907a43") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1790), new Guid("f3f3fd83-31b7-46d2-8bca-e3a53ec74206") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1794), new Guid("708af809-b3fd-48c2-887f-491c225f91f9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1798), new Guid("1517e782-6616-4872-be4d-cec1f59e3ff3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1803), new Guid("a45c523e-93ee-4ab7-99ff-003eb99bc8e7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1746), new Guid("63895ae6-4732-4c19-a6b1-74d3cdffa381") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1752), new Guid("1dcd6a2e-3cdb-4b6e-88c9-b248c14831b7") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_CreateTimeRecord",
                schema: "Facts",
                table: "F_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_DsblRecord",
                schema: "Facts",
                table: "F_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_Parent_Id",
                schema: "Facts",
                table: "F_Strategy",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_PCode",
                schema: "Facts",
                table: "F_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_PERPCode",
                schema: "Facts",
                table: "F_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_PIndex",
                schema: "Facts",
                table: "F_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Strategy_PName",
                schema: "Facts",
                table: "F_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Strategy_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_StrategyId",
                principalSchema: "Facts",
                principalTable: "F_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_StrategyId",
                principalSchema: "Facts",
                principalTable: "F_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_Process_Strategy_F_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Strategy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
