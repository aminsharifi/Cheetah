using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Link_ProcessStrategy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_EndorsementPattern_CD_EndorsementPatternId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_D_EndorsementPattern_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_ProcessName_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropTable(
                name: "D_ProcessName",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_EndorsementPattern",
                schema: "Dimentions");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.CreateTable(
                name: "D_Process",
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
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PN_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    PN_ERP = table.Column<bool>(type: "bit", nullable: true),
                    PN_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Process_D_Process_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "L_Process_Strategy",
                schema: "Links",
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
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_Process_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_D_Strategy_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9167), new Guid("9d8fd051-220b-496b-a694-47b4d15c0fab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9388), new Guid("7dac1f8b-260a-4c85-9a27-3029945712d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9408), new Guid("4bb85e9a-689f-4b41-a4a0-1934d9fd2906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9419), new Guid("7c56927e-5ac4-4972-8f8f-ac1a78e83480") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9433), new Guid("bab7aa5c-0194-42ae-9a54-b667c4d65cef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9446), new Guid("c6ab375c-587d-4391-9c62-4639b69c7aef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9465), new Guid("15f3dfad-d18f-421a-a89b-5c5393c0dac6"), "D_Process" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9478), new Guid("3eea0dbc-161b-4af6-bcde-a216517be101") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9492), new Guid("b535b07d-04e2-45d5-bb09-3383bc2bb478") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9517), new Guid("4fcefdec-e89f-47e0-a9f0-25cfc9869dc0"), "راهبردها(Dimentions)", "D_Strategy" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9531), new Guid("fa2020b5-bf2a-4c58-9611-839301a8b312") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9544), new Guid("fc2577a3-33f0-467d-b693-6256123075ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9558), new Guid("82d17fda-27ec-4828-b2e6-b88890918c66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9570), new Guid("078eaa24-c891-46e2-9f45-ffba6e4672f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9587), new Guid("fdbb6e1a-bb19-4e7b-a9aa-776e113e2141") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9609), new Guid("28729a9c-b6ea-4f8c-8a02-3f8bb3ed9906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9621), new Guid("fec61037-bdfa-4adf-8099-4e1071913e23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9633), new Guid("66615571-8c83-4b09-b20e-1cad01ccfc3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9643), new Guid("808d65cf-7238-4e25-98f5-899a879fc5be"), "فرآیند-راهبرد(Links)", "L_Process_Strategy" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9655), new Guid("bcf5852d-fd05-43b7-b997-7d941770e688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9670), new Guid("4bfc9ec2-bfcb-4396-983e-f91fe9da9013") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8289), new Guid("b9b36afe-b701-47ba-828c-167b9e988318") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8299), new Guid("e7224dde-d548-4a52-b02a-12e32adb5ad5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8308), new Guid("1cabec59-0666-4bb7-8b87-3b03f7f667ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8354), new Guid("62f68c89-3d2d-410f-964b-5ab2e3d971dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8365), new Guid("654a1433-15ee-4e17-9d23-792b5a9bef0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8542), new Guid("14b44762-6166-4993-bc35-bbd020e8d557") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8553), new Guid("c8372165-d44f-42ae-bd12-becb2ad547a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8560), new Guid("b8c4c87e-76bf-4ae1-a9b4-e935c2789e4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8569), new Guid("15219968-602c-4db1-879a-ebf3d4c92cad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9052), new Guid("dd0bd028-d038-4091-adbe-66a7e37ff1eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9075), new Guid("269524f2-2794-4d91-b35b-a100bdb99a75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9083), new Guid("05de22c0-5823-450f-959c-33d2d9a4ef96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9091), new Guid("718b1d3e-c7f9-43f6-8ca0-4d62423ce829") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9099), new Guid("00b222c0-7edc-48c6-8c39-b8207f93ccbe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9111), new Guid("bdfedf10-4b5e-48eb-9488-07df4f83a1ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9121), new Guid("30fa6404-abca-474d-8414-b641aa49928b") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PN_ERP", "PN_RemoveRequestorApproval", "PN_ShowSupport", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8096), false, new Guid("00a7f711-d101-4c31-b3a5-bb4299b00050"), 1L, null, "تعریف/اصلاح مشتری", null, 1L, true, true, true, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8114), false, new Guid("302c6f12-eb2f-4866-97d3-2d8d816665c3"), 2L, null, "مجوزهای موردی", null, 2L, true, true, true, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8144), false, new Guid("6b34b80e-fef2-485b-9ce4-60bf699d843c"), 3L, null, "اعتباردهی مالی مشتری", null, 3L, true, true, true, "CustomerCredit", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8191), new Guid("955b7aba-ecf9-4b80-90df-e99085a1ebff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8201), new Guid("a09fcda5-00d0-4f3d-a92f-5e8c2ae96992") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8236), new Guid("c3830e9e-8d50-435b-870d-6742389a669d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8243), new Guid("ed2ddbf0-aedd-4aba-b968-22ea98da4411") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8933), new Guid("ff45a365-269f-4ec4-ab54-791cf9e069f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8945), new Guid("db1d3536-2e8d-4447-b3a9-a8628e3c22a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8958), new Guid("5d4a1a92-1719-4612-93d0-3c403d90c773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8966), new Guid("84771926-b22d-4383-8316-ad4261bc33f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8975), new Guid("949b3bbb-8fac-4eb6-969e-cda377218d8d") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7379), false, new Guid("b85041e3-fa18-435a-a0e5-be2ae25980b7"), 1L, null, "الگوی یک", null, 1L, "Pattern1", null },
                    { 2L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7519), false, new Guid("82573fbb-2706-40fb-bb6d-387eb92c9158"), 2L, null, "الگوی دو", null, 2L, "Pattern2", null },
                    { 3L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7531), false, new Guid("ad8da789-0fe1-4098-8a60-9263d29b22a3"), 3L, null, "الگوی سه", null, 3L, "Pattern3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8712), new Guid("04c25938-7866-46fa-ae82-f164a998b316") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8725), new Guid("d56594a1-d2ab-46fe-8bc7-41e5bc5a1830") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8733), new Guid("9dd7b9fa-b09b-41a8-9430-9abace772258") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8742), new Guid("1cb7f84f-5c3a-479a-893c-21c0e4ec072d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8752), new Guid("03331814-aa65-4881-afee-1627cbd22c87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8761), new Guid("24181150-a8e2-447b-93d0-efb1337ddf08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8777), new Guid("140c86c7-de19-437f-8d7d-aefb032bbf83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8804), new Guid("9bd42d08-4087-4abc-804b-19b76f425f89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8814), new Guid("4eb68fe6-5e8c-46d1-b89f-35b47f9ba338") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8824), new Guid("7a8bdaf9-69b4-4375-8f5f-c729aabc1569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8625), new Guid("88e99c99-5782-4d78-877e-7167f9627c62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8636), new Guid("720cd5e6-181a-4d38-956d-185555e89d35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8650), new Guid("d993899a-0e0c-4e26-af10-45b4c710b925") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8669), new Guid("e951f72c-3f25-49b5-8c39-557009ac8ec9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8874), new Guid("68c54a5a-1082-4432-a20c-4d58d68fdded") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8886), new Guid("1b4b2fa6-2a7d-4273-a4e0-9e077e2c1aca") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9815), new Guid("faea98d1-f2c7-44b6-afd0-fe97c77f9c0d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9824), new Guid("98848ab1-494d-40e6-a86e-74aa11c4bf76") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9840), new Guid("6154a43b-ec88-456a-a310-09c750fd22f9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9848), new Guid("21bdc805-c2e4-4d56-b620-ea6fafde2bb6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9856), new Guid("e1b25fb1-81be-4c66-a57e-e3b08914c69c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9863), new Guid("13cb4df9-3235-423e-ba3e-7eea78735af3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9869), new Guid("fc149227-d7c4-437d-a686-977ba42c6052") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9764), new Guid("e5a92884-5fe6-4520-a6d5-9dd0bf568b26") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9779), new Guid("e253d41b-e002-414d-aa63-418473085856") });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_Process_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9924), false, 1L, new Guid("6e2b6d41-9d51-4a98-a4f0-aa382ec18035"), 1L, null, "فرآیند1-راهبرد1", null, 1L, "Process1-Strategy1", 1L },
                    { 2L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9934), false, 2L, new Guid("46d038f7-2eff-4c6e-aa6b-54388fec5f88"), 2L, null, "فرآیند2-راهبرد2", null, 2L, "Process2-Strategy2", 2L },
                    { 3L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9943), false, 2L, new Guid("0eafb234-4a2d-46af-a9c5-4607847b4442"), 3L, null, "فرآیند2-راهبرد1", null, 3L, "Process2-Strategy1", 1L },
                    { 4L, new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9949), false, 1L, new Guid("892c02f6-56e5-4aac-af40-40168fc36178"), 4L, null, "فرآیند1-راهبرد2", null, 4L, "Process1-Strategy2", 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_DsblRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PIndex",
                schema: "Dimentions",
                table: "D_Process",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PName",
                schema: "Dimentions",
                table: "D_Process",
                column: "PName",
                unique: true,
                descending: new bool[0]);

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

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_CreateTimeRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_DsblRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_FirstId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_LastUpdatedRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PERPCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PIndex",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PName",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Strategy_CD_EndorsementPatternId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_Process_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Strategy_CD_EndorsementPatternId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_Process_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropTable(
                name: "L_Process_Strategy",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Strategy",
                schema: "Dimentions");

            migrationBuilder.CreateTable(
                name: "D_EndorsementPattern",
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
                    table.PrimaryKey("PK_D_EndorsementPattern", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_EndorsementPattern_D_EndorsementPattern_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_ProcessName",
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
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PN_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    PN_ERP = table.Column<bool>(type: "bit", nullable: true),
                    PN_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true),
                    PN_EndorsementPatternId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ProcessName_D_EndorsementPattern_PN_EndorsementPatternId",
                        column: x => x.PN_EndorsementPatternId,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_ProcessName_D_ProcessName_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessName",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8600), false, new Guid("199d966d-1a82-4fca-ac86-0d4747bcd052"), 1L, null, "الگوی یک", null, 1L, "Pattern1", null },
                    { 2L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8708), false, new Guid("fbc07104-7b75-4e61-8ea7-8c813f5f3601"), 2L, null, "الگوی دو", null, 2L, "Pattern2", null },
                    { 3L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8714), false, new Guid("40ef4bff-df88-48ab-ac03-ceede8c8fd32"), 3L, null, "الگوی سه", null, 3L, "Pattern3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9402), new Guid("872916c8-df2d-4997-87a3-99115ac7fd92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9573), new Guid("1cfa03b6-0110-4404-823f-8f4a4e05a0cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9584), new Guid("dbf6c98e-fa88-474e-97bc-55dc125358be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9595), new Guid("6fac7dbe-6ed2-4059-832a-5259a2009006") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9612), new Guid("dd25fc40-4744-44c8-bd3a-16e12debc2b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9620), new Guid("ada84772-e72c-48ac-9052-d84391867d5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9628), new Guid("efaece35-5198-4b87-bbcd-dc6e6495471f"), "D_ProcessName" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9638), new Guid("1b00c21c-20a0-43fd-835d-49ab3a572814") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9645), new Guid("09ec25d8-881d-40cb-881e-c20af3c8f96f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9654), new Guid("2cdb9e75-c685-4990-b82e-51017c36ab83"), "الگوهای تایید(Dimentions)", "D_EndorsementPattern" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9669), new Guid("b4786d1e-7ece-47a9-bddc-8517239221ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9677), new Guid("c3ea7f4d-8641-44a4-a211-471d60d65970") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9685), new Guid("6b564144-379b-4c4d-8d50-7b9b764f76ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9693), new Guid("ebbefd8b-9cff-4d1c-bc77-644868ded058") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9702), new Guid("9ecf888d-79bd-4b34-b2fb-a922a17bc9ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9710), new Guid("b48bf2d0-17d0-4401-a689-de603b0d25eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9718), new Guid("d33a4ca7-c025-4ac1-858d-355e10570edc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9726), new Guid("69892097-aa06-43e6-a9ce-bc014e287f6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9742), new Guid("567ff8a5-323f-49da-a474-2fa253d6e0a8"), "کاربر-واحد(Links)", "L_UserArea" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9750), new Guid("9c18dff4-7326-443a-8c4f-6facd1c82684") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9757), new Guid("172dc43d-6f70-405f-904a-7c56c59cf197") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 111L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9662), false, new Guid("bae1d0fe-2274-406f-96a9-08e35579e1a8"), 111L, null, "اختصاص نقش‌ها(Facts)", null, 111L, "D_Endorsement", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9025), new Guid("39c861bf-41d3-4e59-a17c-6808a6096f67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9032), new Guid("7236e027-8042-4edd-8dc1-9928d460f28d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9037), new Guid("49b4cbf2-ba28-485d-9386-c2382b3f8afd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9071), new Guid("5e04ac5a-042c-4dec-a1a9-7a0a3fc97b08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9080), new Guid("058edf64-65d2-45a4-a300-607e5ece0b29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9085), new Guid("918e1380-1e22-4c02-a265-469131ae12dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9090), new Guid("708547e6-d88b-4415-a6ef-6d6b23d21302") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9094), new Guid("36696123-e47e-4653-bc88-4a1125859e2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9099), new Guid("f909260f-46ac-45d6-b4d7-d7ddb1374d10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9345), new Guid("f8ebc9c8-be56-47e6-b904-98501f1b31fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9352), new Guid("ec481ed1-d463-41d1-91dc-a79492e86227") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9357), new Guid("a3f12c83-1c02-43bd-b6e5-0363dd774b4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9362), new Guid("0c475538-0fe2-4566-9c51-d94e7e2ba041") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9367), new Guid("793cd433-5725-4be7-957d-6da27958bd78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9372), new Guid("c7688e46-5077-4e41-8834-64064e4c708a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9379), new Guid("2118a51f-e923-40c2-93cc-01442a8bab70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8974), new Guid("05023a86-2d74-45ed-b97f-9f386d4e7247") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8981), new Guid("d8a81363-96a4-4503-a3c1-6fb2f5559dcf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8988), new Guid("1329a7e9-525a-4c1c-b72e-506fd2a824a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8993), new Guid("e79f3c7f-24d1-47be-8eab-5b1c967eff4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9296), new Guid("cb94cf51-6229-432a-abb9-9c5721e1ccaa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9302), new Guid("77be26eb-8262-4919-a432-731e757c1a48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9307), new Guid("455aef19-956d-4f4d-9a7e-bf3219473d9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9314), new Guid("956ccb5e-459b-466b-8b55-7f1947b323fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9319), new Guid("37f432e0-65af-4d44-86c2-be9c715698bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9179), new Guid("27df1ab6-1aeb-4a6c-b161-1bb9fee8cbd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9185), new Guid("be93d5e1-c741-4174-9ccb-11c4d2401f49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9190), new Guid("ac1aab92-8f48-4d86-919e-ee80f49e209d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9195), new Guid("f567ccea-1c5a-449b-9bb4-ed583cca1fde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9200), new Guid("d5e746fd-fb17-4891-ad13-624b69098e75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9205), new Guid("2f9d38f6-7682-43bc-90fb-d1e60797bf9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9210), new Guid("b1e46c7c-7905-45bc-bf2d-57953f7b82e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9218), new Guid("14fe3bce-b2b7-40b6-9e1c-af7f5901a1c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9223), new Guid("295ab83e-97f9-4370-b915-5b28f3af3114") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9228), new Guid("25bb685e-46c1-48b8-9059-824fb131becd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9134), new Guid("d5c9430a-bd05-4453-88a6-acfef09d3375") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9140), new Guid("e5723900-7ccb-4fdb-b283-beae12edcb63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9145), new Guid("569f7920-9a21-49a8-9b74-22c3aa106273") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9153), new Guid("b326f66a-9d98-42ad-b7c8-19a224a72529") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9256), new Guid("171d0eb0-51ea-4c05-837a-f2e72b8be381") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9262), new Guid("0e332f79-239a-4b62-86c9-583bffabb7ef") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9839), new Guid("51516b26-472e-4f8e-a100-1e25bb6dbd40") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9846), new Guid("1765f956-d38a-4efd-a05c-d01786a37c62") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9851), new Guid("8de4593b-3a31-4894-8b58-101f3649bc6a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9856), new Guid("c0d1c562-5237-4671-8897-d44d5ab516f1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9861), new Guid("41ad3a46-67fa-4c11-b40d-693bccb17f4e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9866), new Guid("8780b489-f424-4c14-a76a-3c1ead48ffc0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9870), new Guid("a1274962-78c5-445e-84ff-20c789588abe") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9802), new Guid("648260c7-98ca-4203-ae3b-5d86f99698da") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9812), new Guid("7a520a84-d36c-41cc-9cf1-c7c9fb492e00") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessName",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PN_ERP", "PN_EndorsementPatternId", "PN_RemoveRequestorApproval", "PN_ShowSupport", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8923), false, new Guid("77dee5b6-005b-4bea-a6cb-19b49671a29d"), 1L, "الگوی یک", "تعریف/اصلاح مشتری", null, 1L, true, 1L, true, true, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8931), false, new Guid("bafe0ce0-4609-43c0-98b7-d8b13c2a83c1"), 2L, "الگوی دو", "مجوزهای موردی", null, 2L, true, 2L, true, true, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8936), false, new Guid("2a817a04-4e3d-4c02-b1e1-d83bf490bf11"), 3L, "الگوی دو", "اعتباردهی مالی مشتری", null, 3L, true, 2L, true, true, "CustomerCredit", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_DsblRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_Parent_Id",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PERPCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PIndex",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PName",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_PCode",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_PIndex",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_PN_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "PN_EndorsementPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessName_PName",
                schema: "Dimentions",
                table: "D_ProcessName",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_EndorsementPattern_CD_EndorsementPatternId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_EndorsementPattern",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_D_EndorsementPattern_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_EndorsementPattern",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_ProcessName_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessName",
                principalColumn: "Id");
        }
    }
}
