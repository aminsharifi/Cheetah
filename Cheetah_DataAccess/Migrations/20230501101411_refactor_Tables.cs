using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class refactor_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Strategy_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_L_Process_Strategy_D_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy");

            migrationBuilder.DropTable(
                name: "D_Strategy",
                schema: "Dimentions");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L);

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
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1359), true, new Guid("831351a3-cf07-47ee-b4bc-e4c841b52c77") });

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
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1384), false, new Guid("1de95e83-d201-45ec-b342-ee18f1304b56") });

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

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 206L, new DateTime(2023, 5, 1, 14, 44, 10, 399, DateTimeKind.Local).AddTicks(1524), true, false, new Guid("3167f568-000a-4afc-a516-3621f19adb8f"), 206L, null, "راهبردها(Dimentions)", null, 206L, "F_Strategy", null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.CreateTable(
                name: "D_Strategy",
                schema: "Dimentions",
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
                    table.PrimaryKey("PK_D_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Strategy_D_Strategy_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8637), new Guid("98a83871-9020-4a0f-a249-a149f5d89ab6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8894), new Guid("8c4a9d42-e5b1-46b8-88fc-d1c36c729903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8913), new Guid("2a1df279-84c7-4c55-8117-3823e99a4eff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8926), new Guid("2241c57b-b226-4d36-abaf-73a2c24074eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8938), new Guid("6305af76-ca8f-4450-8a5a-73f29c688aa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8949), new Guid("d4896d6b-544f-4192-83e8-4faef1c9f3d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8973), false, new Guid("1f420d01-3897-497c-8a00-e2e0ea380358") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8986), new Guid("8d035d9f-ed6d-4d7d-a0e9-601dfc1a8d69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8998), new Guid("475b1020-e10a-4710-89c1-70b39d092476") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9023), true, new Guid("f21d75a2-172c-4ffd-9d92-46c7025638c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9035), new Guid("0b616453-bba7-4263-b347-f34e0bf03425") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9047), new Guid("08c6e67e-eb8f-4ed2-831d-c385072b86c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9060), new Guid("53882a3f-14e7-4ae9-82c0-6bfcd91b75d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9071), new Guid("a1bb7602-8be1-4a15-9e20-21b950bc043b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9090), new Guid("965a9c8d-a57f-4376-a38e-da0171c2c85b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9101), new Guid("bf2e0432-46e1-48fd-805e-bc5197151281") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9112), new Guid("61773bc7-4e96-4d3f-b35a-704c2243fa9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9125), new Guid("4f3eee43-ea78-4aff-879a-90e2a64aa0f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9136), new Guid("8491d46b-fd7c-44db-a7b7-a57b376718d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9147), new Guid("707a0501-ad41-4430-86bd-53554ed6b5da") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 110L, new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9009), true, false, new Guid("4eedb9c6-646f-4407-adca-50c1387a0e72"), 110L, null, "راهبردها(Dimentions)", null, 110L, "D_Strategy", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7939), new Guid("5a32a4c6-a246-4abd-a822-0c34b9cccee9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7950), new Guid("51bc98b7-cff1-49c2-812f-bfe4b3717941") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7957), new Guid("e97626c5-15fb-4061-bd96-66584ab59def") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8004), new Guid("69224e3c-fde7-4864-9ea4-be86d2309431") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8016), new Guid("700eab94-7570-4259-a0a3-8cce77e69eae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8095), new Guid("fad1a0f1-3ba9-444f-8363-09b03f622da8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8105), new Guid("7258f77c-c87d-40c1-bacb-d03d3f154e51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8119), new Guid("2ee2cb10-d66c-4af0-ba52-2dd03c4aba12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8141), new Guid("a423a9bb-8890-4db0-add2-106329299623") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8549), new Guid("c592ef01-d3b9-446e-a0f5-b9a456fcf5ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8561), new Guid("5789b0cd-6f53-4af4-9ed6-c8cc6d845493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8570), new Guid("ac7145b9-6289-486f-aab0-b471d81bfb56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8577), new Guid("ec238c9c-6ddd-4615-8fe5-e6d01ef54d48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8584), new Guid("2beab5eb-90e3-496a-9bfc-ee331aa01488") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8591), new Guid("85bef866-9807-49d4-8387-c353cb4aae91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8598), new Guid("69339d3f-bb49-4001-b63c-7a6e950031dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7759), new Guid("0316ebe9-2a91-4318-a17c-6ce0dab27c0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7779), new Guid("f3bf7619-d480-45c4-a02b-e80f02d208b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7794), new Guid("4ca4f836-ff21-49b5-8419-a5327bef67b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7836), new Guid("d9d1a6b3-92b3-43c7-9241-7b818bee821f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7848), new Guid("52cdaac1-1074-44d8-bf12-cc8b44958fea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7884), new Guid("83aa79cb-c111-4b8a-908d-8ae888c863dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7896), new Guid("6f131e21-c801-4bc1-a3b9-9895661b0b8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8462), new Guid("356eac83-9702-4800-bd11-cbb83da7e2bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8477), new Guid("8486d1e0-35ce-4614-8634-1ec845849790") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8485), new Guid("38eabc9a-231a-421c-9ec8-98833b6d990d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8504), new Guid("827e2f8c-1e22-4b99-92cb-00d10b30e6f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8514), new Guid("eae9f8df-a440-452d-8df0-22df00a7723c") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(6877), false, new Guid("a43406b7-6949-444d-b398-1676fdd54054"), 1L, null, "راهبرد یک", null, 1L, "Strategy1", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7057), false, new Guid("e7567c32-cecb-4cf7-aae4-f4db4fc3e348"), 2L, null, "راهبرد دو", null, 2L, "Strategy2", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(7071), false, new Guid("f3f619e0-1d88-4095-86b0-8bd5092325c2"), 3L, null, "راهبرد سه", null, 3L, "Strategy3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8266), new Guid("d8d4d086-9f68-456b-bd52-23fdff86a62d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8277), new Guid("4d1b1b6d-1a29-4332-a620-e9392c7db00a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8289), new Guid("48bf66a4-ceea-41f7-b45c-d7456f952472") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8296), new Guid("29b52d75-6e06-4ac7-ac68-dd9c4e07c4fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8303), new Guid("898a2c71-29ab-4a12-9748-eef4000d26d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8311), new Guid("2e0dc772-5206-450d-aed1-1771417551ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8319), new Guid("64de7af5-9b5b-45e3-b771-fcf1182ab77d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8344), new Guid("93ea7462-13b1-4bf4-964c-9174f6f3fad9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8355), new Guid("1e71db7a-6115-4a16-b8d3-4ef352e38a6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8363), new Guid("be6c3235-be98-439d-93ae-3955392b28e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8200), new Guid("b5bb8463-e8c6-43f5-b25f-45daea78f25b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8211), new Guid("2ad321fb-8b83-4f8a-aaa0-98e4f150863d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8219), new Guid("d432d049-afc5-4ad8-8a27-6afcb073373c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8227), new Guid("a00789f1-38ab-4174-9914-76646803f11c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8414), new Guid("30b454cb-ac35-492b-80fc-c69efab5ff6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(8424), new Guid("91ef34d2-351b-4e12-b39b-461a332306ac") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9228), new Guid("ebf794af-fd03-41e2-9e07-3b448c0189ea") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9241), new Guid("03fb5c2e-826a-4e61-80ef-5b29c7798d61") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9248), new Guid("55be097d-566c-4497-a953-165b74123e83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9256), new Guid("094dbbe8-6ff1-49ac-90c4-fe9ad9d479e5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9293), new Guid("79df8d5b-75a6-4ad0-940e-6824fbeefc3d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9307), new Guid("ae7e24c6-684b-422d-b428-e9a35572e69b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9315), new Guid("be99020c-7a2b-4ef1-bee6-caf6bfb380ce") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9322), new Guid("b8f510da-04ec-4625-b813-487ed03fc379") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9551), new Guid("d50f1929-82fb-4a71-a15b-47a1eeda8d53") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9561), new Guid("d697e9de-3330-4e53-b3ec-68a3beb20e3c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9568), new Guid("32fe0662-8196-4fcf-afaa-86dd1728318d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9575), new Guid("74473c7e-9175-4f6e-97fd-890d8a78ae02") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9585), new Guid("75aec373-8246-40ae-84b1-5eaa235aac03") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9412), new Guid("62e31b97-916b-4aea-a32c-605f5ad2d6c1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9422), new Guid("be19840b-e532-439e-99ce-d1c795272b56") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9429), new Guid("5cfa4303-ec6f-4269-b99a-7cb3220bde50") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9440), new Guid("d0b40a92-e6dc-489f-8a15-df6b7ffe88dc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9448), new Guid("59b4b539-2dae-4344-b79c-4f1a8ed14e3f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9458), new Guid("75fbccc0-ce40-4020-8f05-f4eb35db4283") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9468), new Guid("ce94abe4-bf44-404c-b6ab-18d179cff955") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9369), new Guid("9b2a890d-e86a-42bf-9605-80921bf86362") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 18, 55, 2, 14, DateTimeKind.Local).AddTicks(9381), new Guid("d9ec38de-ec2e-44ed-afa2-be2e08f15701") });

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_DsblRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_Parent_Id",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PCode",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PERPCode",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PIndex",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PName",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Strategy_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_StrategyId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_StrategyId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_Process_Strategy_D_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
