using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Rename_To_CaseStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_ProcessState_ProcessStateId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.RenameColumn(
                name: "ProcessStateId",
                schema: "Facts",
                table: "F_Case",
                newName: "CaseStateId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Case_ProcessStateId",
                schema: "Facts",
                table: "F_Case",
                newName: "IX_F_Case_CaseStateId");

            migrationBuilder.CreateTable(
                name: "D_CaseState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_CaseState", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "LastUpdatedRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8827), null, "در دست بررسی", false, null, new Guid("987f089b-5897-4ec4-b330-a78e877f2f44"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8828), "Ongoing", 1L },
                    { 2L, new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8842), null, "منتظر بازنگری", false, null, new Guid("7ecb1c3d-1b58-42f0-bdc8-cf2205f09334"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8843), "Editing", 2L },
                    { 3L, new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8845), null, "کامل شده", false, null, new Guid("fcda8d5a-2382-4420-a00b-b2c5742970e2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8845), "Completed", 3L },
                    { 4L, new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8847), null, "ابطال شده", false, null, new Guid("f1b6ec76-ef20-4070-9532-b59c19b0d9c6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8848), "Aborted", 4L }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9254), new Guid("4b03633d-3cd8-43a5-859c-fb48abad1cb7"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9295), new Guid("e3846a46-59e7-40c5-8f0e-aed92ec35ab9"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9301), new Guid("42a257e6-7e45-48ec-bf87-c7d496ec0203"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9309), new Guid("355035c1-02c9-4d95-b899-a736bb003747"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9316), new Guid("2ff50fee-c285-4397-9921-99bd03e6df5c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Name" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9321), new Guid("8f1e6da7-dd97-433e-95b0-c2b0443a0aa6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9322), "D_CaseState" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9327), new Guid("5ba2ab16-74fa-4219-866d-47ad7a3b3943"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9332), new Guid("89b81e3e-825f-4f24-8e7c-af8cea5a6a75"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9337), new Guid("1c2fb9cb-2dc4-4f00-bfd4-d5f2065232c5"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9343), new Guid("2e7fa003-a035-4cf0-b9ca-cb6f866c5397"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9349), new Guid("d9638123-1fb9-497c-9339-bee916bf998f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9357), new Guid("14862b70-8c64-43b3-8ffb-3fbb114031c3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9362), new Guid("cf448cbc-57fd-4a19-be00-b8cb4e134d99"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9367), new Guid("82161cca-f461-4089-b145-de0f547939a8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9372), new Guid("e668342f-e647-4664-80fb-cd9244a4290f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9440), new Guid("fc339916-a5b4-4c09-9a92-03aa0c3832bb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9447), new Guid("334e1432-0e66-4744-b94f-4f7323722116"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9452), new Guid("30e53385-c51a-4b00-969a-8d0a18f15570"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9458), new Guid("75f4cdc6-1ff7-4f6a-9546-4033c593be93"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9466), new Guid("9d0082ba-9eb4-46a5-9aa7-155ca5444659"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8914), new Guid("287e0a6d-802a-4938-ad5a-c3712f11639d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8918), new Guid("077d8728-521a-4751-8b15-991086313a1e"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8921), new Guid("67dd1cd4-16a2-4fb0-bb84-63f64439880c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8940), new Guid("71cada4b-e19b-405f-a537-091cd51b3ffc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8943), new Guid("737303ff-b1e6-40ca-8278-853a560fe292"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8945), new Guid("0189be6a-ff8a-4355-abfe-15758722e6ad"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8947), new Guid("1735dcab-b977-423e-b748-38f859fd7158"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8950), new Guid("8018a45b-5238-4d38-b6cd-767e4a65405a"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9015), new Guid("ac7ea85b-6545-4f07-b122-e22c8a075cf0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9175), new Guid("88cd8d68-f1a8-470d-a993-c18899f71212"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9177), new Guid("0826dae9-cf13-40a3-82c1-7289f27870f0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9182), new Guid("999acc74-ab2f-40c4-8adb-afba3a8190cc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9223), new Guid("cdd5bf0a-4d1c-4308-b127-745d37411feb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9226), new Guid("b4da10d6-d51d-4a96-aa8e-082cbbec26f3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9229), new Guid("9697615c-f93e-4c31-8708-e0b0c9f2008d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9232), new Guid("c9ce6815-4849-4188-b75c-f762866db458"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8567), new Guid("a0af0fc7-8e3a-4658-bde0-a50f39f7a00b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8615), new Guid("fa721d5c-8101-486f-b626-63ea71e8c79c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8618), new Guid("bc801f95-7a4f-41d1-b02c-99580d07fda3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9143), new Guid("aa59a8aa-d175-4c75-96f7-571fcf98ebea"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9146), new Guid("d9f03a76-0893-4aa2-a33b-c0b8db3df72d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9149), new Guid("1ed9278c-c501-45b2-a6b1-1b00bf60965a"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9152), new Guid("b7199767-48ae-4a9a-854a-29984d088a5f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9155), new Guid("2e112793-3322-4b35-8f24-f319fb88d505"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9067), new Guid("ed724af5-6e5b-42af-ac43-15eba188a5af"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9070), new Guid("a67240e1-cb60-4e5e-9e91-e2c74000b760"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9073), new Guid("44bee986-dd3f-4140-a1bf-3426beedbdd1"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9078), new Guid("80925a33-8bed-4fad-8c49-9a10b589b665"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9080), new Guid("cfc94fc5-ca68-4717-9f14-e5fe6db4630d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9083), new Guid("5f3d6f14-6aa7-430a-9cc5-874ad9204704"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9086), new Guid("6c614301-940b-4a43-bbd2-2b6cb9949434"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9088), new Guid("70ca33a2-b7ec-4772-9a56-32e318216315"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9091), new Guid("cf5ef45c-1a8e-4ecc-9a08-866cec6ee892"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9094), new Guid("e7e70b65-7303-4e5e-9410-a570b6e454fa"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9045), new Guid("2ddf18ed-b758-4cf2-95f6-6bdc5609793f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9048), new Guid("378ea968-57b7-477f-9331-d82e4dd866e0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9050), new Guid("0fc89a85-3115-4086-976c-761b760445fd"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9053), new Guid("e0916af9-33f5-4adf-84a6-ccbac535ae15"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9118), new Guid("20e0b0ca-2fe1-4571-857e-eb7e624d27fd"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9123), new Guid("23ad0422-c29c-4bf9-989a-bae7d43fe5d3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8875), new Guid("5c362e7c-ab3d-44bf-be33-8a409c6f4ca0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8877), new Guid("8be5bc18-1533-405f-b674-e86329714255"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8881), new Guid("2768dfb5-0c3d-4560-b86d-afd47f760679"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8883), new Guid("86a375bb-e183-45e4-9f08-a9df61fa0cf6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8885), new Guid("946e087e-7f63-42fe-a5c4-96b1d60f70de"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9533), new Guid("6fcf2f50-d93b-4340-b6bc-20cb33797ecb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9540), new Guid("0fb5885d-0ffa-45ed-8bb2-89834aaaae5e"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9543), new Guid("1f9cbb90-9bb7-4bdf-8cac-9c04624f6210"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9546), new Guid("bb234a96-40f4-4571-96c2-fedf730f7e2b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9552), new Guid("7320693a-bb72-4726-807e-31f67f1ac92b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9574), new Guid("d5746a8e-0694-4daf-8fbb-3f3da6f2345f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9578), new Guid("23124d72-9d11-4749-a684-9407b8c61237"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9581), new Guid("46680f62-de83-49ca-951e-42411fcd87bc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9584), new Guid("ea33b23e-a5cb-4a83-a5d2-b2a1ba386145"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9508), new Guid("cfe9b08f-5847-4335-aa1a-7f016a365036"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9511), new Guid("06678728-310c-4560-8b04-a354a87224f2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9514), new Guid("390b718b-9a48-45b1-a426-48b30ecbe8d1"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9724), new Guid("6b5cf4cb-f26a-4044-bb48-68f2d7a026f8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9727), new Guid("d62477fa-0da3-481c-9548-d2fa288d970f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9730), new Guid("06d01b98-585f-4e72-be65-75f622dcdbda"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9732), new Guid("03f7048b-f0b7-4d08-b17a-7c87f368f51b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9735), new Guid("ac032b67-e60a-4537-96ff-c7716d1bb3c8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9680), new Guid("09a2bdbd-ed7c-4e29-9e0c-db7d585cdd7c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9684), new Guid("23a782f3-5fbd-4523-9aaa-97c6f97c3294"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9687), new Guid("4f479140-aae1-4c22-b3be-e1864e8e7b83"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9689), new Guid("177bdf0c-ed44-42fb-922c-eb19954694e8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9692), new Guid("5f624d38-a73c-4e4c-a3d5-921fc9ac63a9"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9696), new Guid("e2d808ad-1918-4190-92fd-5e6c790cceac"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9698), new Guid("1274cdfa-5b6c-4a55-a2bc-684f1e55586f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9608), new Guid("839c1526-26ce-43ed-955c-f133b1991159"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9612), new Guid("951c869b-db4f-47cb-b38b-8ed412fdb019"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9615), new Guid("c415277c-a9b8-436a-a36d-6ee33ab5ba17"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9620), new Guid("41f95e4e-a048-4267-8f13-2351fed8dbe2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9754), new Guid("8a874634-b103-430f-9817-4a4bc195c703"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9758), new Guid("67e47ad4-4f98-4b24-a34a-26f62650d96f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_DsblRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Name",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropTable(
                name: "D_CaseState",
                schema: "Dimentions");

            migrationBuilder.RenameColumn(
                name: "CaseStateId",
                schema: "Facts",
                table: "F_Case",
                newName: "ProcessStateId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Case_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                newName: "IX_F_Case_ProcessStateId");

            migrationBuilder.CreateTable(
                name: "D_ProcessState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessState", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7711), new Guid("0f0d7e1f-f7b5-47f7-a883-34249a2e8228"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7754), new Guid("9653fe1f-bd21-4353-94f5-041858cd726e"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7763), new Guid("ee8a3197-8a81-402e-9a43-7ef33183d3eb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7768), new Guid("8f9648ce-c4f0-49f1-a44c-c48916862ca8"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7775), new Guid("0bd070d0-5106-49ce-8003-4ae7ce9815ea"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Name" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7780), new Guid("92c86249-4379-486b-9269-5a401dba6571"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7780), "D_ProcessState" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7785), new Guid("6d443429-2a59-4bfb-b302-6a82460d0adc"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7791), new Guid("1159a521-b672-4b34-ad20-53a072165baf"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7796), new Guid("baaf6384-58e4-487d-8a4a-8d58e5ea58a9"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7801), new Guid("cea35885-ef17-47fd-b9f8-4ca27b58f34d"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7808), new Guid("8804f8c0-798e-4560-bafe-87af1d3b185f"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7814), new Guid("8ca46cb9-e332-4266-a49d-42ead1be7a1d"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7820), new Guid("0d8379c7-94dd-43b0-b412-202958bcd41a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7825), new Guid("e12e9d2c-7b49-4f97-8c0e-52ab63a7937a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7831), new Guid("47c0c24a-dd5a-4e92-ba20-06af7d2a197b"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7837), new Guid("0c70e430-474e-4602-8015-04303f2b5ee6"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7841), new Guid("ab89c54b-1da1-408f-a33e-3491a7967a3a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7847), new Guid("3e9c9e67-e960-46e5-a3bc-37b192e1cf80"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7933), new Guid("6bde767d-5bcd-45b8-a532-20336a9d8aeb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7940), new Guid("204b0aa6-463c-43e3-82f2-f1f133dde0e6"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7365), new Guid("b6217b0a-b6c3-457f-9f16-1939860d1883"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7368), new Guid("f37efb03-04d5-4dec-84a3-f0d1f8fd2488"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7370), new Guid("7720f997-e012-4f31-84f3-ecda61d5a18a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7390), new Guid("3660e7b7-de0e-4a47-a0d1-ccb8a439b051"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7393), new Guid("9d06e292-02c5-4aee-a743-5016566bc39e"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7395), new Guid("b6fbd498-12a2-4b7b-b2a1-b218a787265c"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7397), new Guid("e46e877f-7145-43eb-8673-c4884a741bb6"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7401), new Guid("f46493ba-dbac-4d1e-b58f-2c6b17627250"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7403), new Guid("194fc082-2315-42b8-9b02-f34f81b85b5a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7634), new Guid("d079462b-346a-4dc2-b781-cbe5c7e67bdc"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7640), new Guid("2aaedf1e-51cd-49ac-8ce1-120c040bba1f"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7642), new Guid("77e0d7cb-2017-4b6e-b646-7fe8e29b5d10"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7645), new Guid("f5944509-a270-4dc5-9e92-cc3125322b81"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7647), new Guid("2a6912f1-517b-4516-b843-2197a6fb28ce"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7649), new Guid("00eb80ae-b985-40fd-805c-31313c4728e0"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7685), new Guid("4194ad84-dcaa-461c-b050-eec691bb8711"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7041), new Guid("e93fa67e-6160-47a0-b090-9eff36168094"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7086), new Guid("542a081d-980c-4945-a4b7-1477ecde83c3"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7089), new Guid("80144870-7122-4fcc-b9f1-cb8b2a810742"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "LastUpdatedRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7292), null, "در دست بررسی", false, null, new Guid("c61e5492-b74c-4fd9-a659-b6715473843c"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7293), "Ongoing", 1L },
                    { 2L, new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7297), null, "منتظر بازنگری", false, null, new Guid("7a006183-6efa-44a3-8390-d6892df4393b"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7297), "Editing", 2L },
                    { 3L, new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7299), null, "کامل شده", false, null, new Guid("d684ecfc-6d43-449b-982e-6df56def0c55"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7300), "Completed", 3L },
                    { 4L, new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7302), null, "ابطال شده", false, null, new Guid("7659bbcb-4bd2-4331-befb-7842d2230dc8"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7302), "Aborted", 4L }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7603), new Guid("0e71cc0d-6c35-42a4-b6b3-274427c56e54"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7606), new Guid("c37d6d81-deb9-4d3b-bb4a-9a8fc0ee26c9"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7608), new Guid("32f207ac-cbaf-4dfe-99e4-82c98ecde227"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7611), new Guid("bc0e202e-32c8-4abb-b4dd-e14567d62398"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7613), new Guid("4d437d62-5438-47f0-b4b2-c239a1615c8b"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7524), new Guid("384bab8d-cc94-4af9-a6ae-2ef29248f6a9"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7528), new Guid("f846003b-fc59-46b9-a859-7a460d76e5a4"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7533), new Guid("d3f8ff55-314a-494a-b620-18c72ec4db67"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7535), new Guid("d14a83f9-8f92-4d2d-9325-5f13e5aa6201"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7538), new Guid("4f5df4d6-5b23-499a-a510-8ec183d6e8cb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7540), new Guid("a51b125b-e21e-4904-a7dd-b93432139a52"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7543), new Guid("e1c97d3c-9650-4562-96a4-feba267addd5"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7546), new Guid("daf7b5b7-4875-4798-b097-079fb5a80775"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7548), new Guid("de0a8e36-0fd2-488e-975c-b0c203c35b92"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7551), new Guid("8357104d-1c67-492a-86f1-4345ab3ab3fb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7430), new Guid("93848eee-6bf2-4896-b975-083de2ef9b0e"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7433), new Guid("625c52ea-c153-4115-ba00-068619ea5a39"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7500), new Guid("3a55952c-654c-4697-827b-31258f1598fc"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7503), new Guid("df69d2ad-2e1d-4c27-a98a-f20cc16e45fb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7580), new Guid("845eb457-f12c-4ba4-a101-6367214a7e97"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7583), new Guid("1aa9d0d8-af20-4fac-97fd-e26a863238cd"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7324), new Guid("d1b716f3-20cc-4b86-933a-0dc61a9c986a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7326), new Guid("83fe1627-9094-43a2-aa0a-f1aba2e9cf2a"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7329), new Guid("8ea9532a-713d-46bf-b32a-c1f5f8c37c77"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7334), new Guid("6a2b504e-0204-4676-8004-9c22cb59a6c5"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7339), new Guid("a490d53c-e1ac-49d0-9a10-e5a82af1978b"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8046), new Guid("785495f8-4b47-4e98-b748-91cf2efb0119"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8052), new Guid("0ba573d8-f738-4741-971b-41c7ef18abd4"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8055), new Guid("c0c15885-58e5-4596-9fc1-8d03623cb148"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8060), new Guid("00ff75b6-6fb8-4960-8f9b-74cc0c31e0f5"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8063), new Guid("163efa29-a6ab-4c79-94ab-6f31b26294df"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8083), new Guid("f31fac64-079f-4dfd-8d72-e2748ca8edda"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8087), new Guid("4fe3d363-8caf-4973-a8a0-2613f46d6a95"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8090), new Guid("46c79fff-cf10-47fc-9aa9-3a952a3bdd27"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8092), new Guid("d2496ea7-d8ba-4ca0-aaea-4cc649bbdacb"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8019), new Guid("10d19fcf-75f1-4605-bc21-94055fe8f8c8"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8022), new Guid("4896e921-78b2-4c9a-8237-8086ac18036c"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8025), new Guid("6ac24140-84ce-43c9-9151-cd1d8c089145"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8235), new Guid("0cdf7651-3a94-42d9-9ac3-f059970c5735"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8238), new Guid("b378d05a-45a4-413c-ac0f-cf804335edb4"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8241), new Guid("c070a0d0-8f8b-4061-a5f6-0f29d07f6e80"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8243), new Guid("a68d7a51-6245-431a-9ddb-81cd38e5e0fd"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8246), new Guid("ab715061-db48-4f15-9696-ab0682be9ccd"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8153), new Guid("53e24bfb-edae-4b92-8868-9dcad87c3645"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8157), new Guid("d5b00e3e-a222-498d-b36a-c5ca9ec76497"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8159), new Guid("88d2d109-a738-4a18-bf83-ccff3a0f6fda"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8197), new Guid("62ddded3-ff1d-47c1-a293-ad13d0b55c30"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8200), new Guid("0ede255e-b4c8-4dac-96ed-5ef4b3589d07"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8203), new Guid("3690fe7e-bb81-43dc-8462-ff4aed9476a1"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8208), new Guid("d4e53bbf-9f6b-4609-b546-c64c1aadb2f6"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8121), new Guid("dddee876-ac3d-405e-be77-05520f1d61f2"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8124), new Guid("d407c3b3-c0dd-42ce-9a34-40c5c64cecc3"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8129), new Guid("71baef38-b75e-423d-aa2f-7855f62f5ae9"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8131), new Guid("d5bb7eee-6ac4-44ee-add0-eacc0a88af61"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8267), new Guid("4d913219-4b69-4428-b129-280513a41548"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8270), new Guid("683c42c5-fcfc-4533-af57-bdff357ed412"), new DateTime(2023, 7, 10, 12, 43, 33, 813, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_ERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Name",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_ProcessState_ProcessStateId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessStateId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");
        }
    }
}
