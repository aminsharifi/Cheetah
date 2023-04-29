using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Rename_Process : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropTable(
                name: "D_RequestTitle",
                schema: "Dimentions");

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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8600), new Guid("199d966d-1a82-4fca-ac86-0d4747bcd052") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8708), new Guid("fbc07104-7b75-4e61-8ea7-8c813f5f3601") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(8714), new Guid("40ef4bff-df88-48ab-ac03-ceede8c8fd32") });

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
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9628), new Guid("efaece35-5198-4b87-bbcd-dc6e6495471f"), "نام فرآیند‌ها(Dimentions)", "D_ProcessName" });

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
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9654), new Guid("2cdb9e75-c685-4990-b82e-51017c36ab83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9662), new Guid("bae1d0fe-2274-406f-96a9-08e35579e1a8") });

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
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 30, 58, 833, DateTimeKind.Local).AddTicks(9742), new Guid("567ff8a5-323f-49da-a474-2fa253d6e0a8") });

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
                name: "FK_F_RequestInformation_D_ProcessName_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessName",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_RequestInformation_D_ProcessName_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation");

            migrationBuilder.DropTable(
                name: "D_ProcessName",
                schema: "Dimentions");

            migrationBuilder.CreateTable(
                name: "D_RequestTitle",
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
                    RT_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    RT_ERP = table.Column<bool>(type: "bit", nullable: true),
                    RT_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true),
                    RT_EndorsementPatternId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_RequestTitle_D_EndorsementPattern_RT_EndorsementPatternId",
                        column: x => x.RT_EndorsementPatternId,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_RequestTitle_D_RequestTitle_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(5942), new Guid("0c9a4362-e93b-47b6-a9f6-4d5f7f301513") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6053), new Guid("99180ca2-9923-4707-9ea2-986c5ac47eff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6059), new Guid("19debf24-0b88-49ce-bde9-e8a6ce1eee10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6922), new Guid("6e081dee-1cb5-4db6-a893-6bf2c72a31e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7119), new Guid("e4abe0d1-f8c5-4597-8974-ab1057f335f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7131), new Guid("b3fb085f-af8e-44be-91c1-1e18e39d4f6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7139), new Guid("57d765eb-b0e9-4f2c-8669-b10cc664ddad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7160), new Guid("35349317-8b38-40dc-a7b5-9e583dfe6a1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7168), new Guid("febe74ca-38cf-4352-92f1-65cb5703cd94") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7176), new Guid("4088ff71-9ded-44b6-9c06-2b3f088306e9"), "عنوان درخواست‌ها(Dimentions)", "D_RequestTitle" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7184), new Guid("1bab6f48-379f-401a-b30f-b3b33e719551") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7193), new Guid("f58fd426-217b-494c-8c2f-f6796b12ae4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7203), new Guid("af6c9a31-e630-4da5-ba06-b1be8e24f4e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7212), new Guid("a01126dd-555f-4562-8180-714283e033ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7220), new Guid("44e06948-330e-4218-a52f-71165de8915c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7228), new Guid("5d362c63-0877-4a09-b9fd-79c1a2bec81c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7235), new Guid("6972e08e-a648-4241-9dc3-1711e7737d74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7242), new Guid("523b6ad1-c431-45ab-9bb7-51cc0116e6e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7250), new Guid("bd79cf68-f80c-4a42-a735-59671acf1d7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7258), new Guid("2d49408a-7797-4ac8-89db-accd1410ae5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7268), new Guid("68f115c6-e76d-40ab-b479-9df269a1bce4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7277), new Guid("40085d67-3866-4669-874a-91f38c8d01dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7285), new Guid("4fe76ec1-18e1-477e-a255-2a4721e36992") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7300), new Guid("3eb22593-3e8f-456b-af7b-8c4cfa4878fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7309), new Guid("de54bd0e-42d0-47e3-90b3-c33be9a4f2ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6553), new Guid("e01116e1-3c8b-4426-8c31-c267465a738f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6559), new Guid("fea675bf-3045-4a8e-b7a4-3b47e70b69e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6563), new Guid("cca508d6-1359-4ec0-bb97-8f59405031b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6596), new Guid("c7f4b730-e3b8-4da1-bb1d-3c27297fc690") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6602), new Guid("f1fb105f-90d1-4cd7-8cd0-1983f08a5874") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6607), new Guid("96593524-f6d2-40d1-bf26-e336c385fd86") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6614), new Guid("89274d0c-1a1a-4bdc-8995-c515367f0917") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6619), new Guid("c66e1b42-9da3-4685-b42d-6b5d4cad60d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6623), new Guid("a90fa42b-09da-4a3f-8a0f-e14ae30c2a52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6868), new Guid("e1f5c8f7-ab35-4e6b-be2f-a909fc3a546e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6873), new Guid("0bfe9bec-ef3f-4af6-9a4d-44a2f02ebc31") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6878), new Guid("a4d08e14-d4ee-407f-860b-4ae95347750d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6883), new Guid("f2a9a68d-b792-40ba-9c90-2b84adb59d47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6888), new Guid("a08b9a0d-a834-436a-99e8-1d45ebd82343") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6892), new Guid("52c1dac6-7b80-42d5-98e7-f203f8a3f6d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6897), new Guid("3062054f-ded9-4673-b789-aa1b6229bad0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6488), new Guid("210e22f2-b577-48ef-b12f-4778b4d0f180") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6495), new Guid("8212741a-f257-42fb-bd4e-aab298168e0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6517), new Guid("716bec48-1142-4a90-89a6-4986de8ad773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6522), new Guid("b6c29a13-d040-4dda-aa97-c5deda85a311") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6443), false, new Guid("5a4acc09-7670-42d8-94af-af65af8408bc"), 1L, "الگوی یک", "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null, true, 1L, true, true },
                    { 2L, new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6452), false, new Guid("73815608-0513-4a65-9553-2897deab8c59"), 2L, "الگوی دو", "مجوزهای موردی", null, 2L, "PolicyCenter", null, true, 2L, true, true },
                    { 3L, new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6458), false, new Guid("e5595536-91b4-47b8-ac6f-314940849669"), 3L, "الگوی دو", "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null, true, 2L, true, true }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6815), new Guid("6daa0422-3560-4cfe-8508-b56d884bdd2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6825), new Guid("b489255b-a515-400e-9a3a-fd84f8b7c3c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6830), new Guid("7a072b8b-72a9-4471-acf1-b591e1740fc4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6835), new Guid("f4c32217-5ff9-483c-9680-912fc8954f68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6840), new Guid("59a26a0a-efd4-424b-a905-d715869bd848") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6699), new Guid("99fc0113-0a1c-4294-b5d6-56c4ede1cabc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6708), new Guid("10118bcc-de49-42c1-8c60-fc2684eed0a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6713), new Guid("0e99a011-2721-4239-b567-0d9684113578") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6718), new Guid("10cb6139-7e0a-444d-ad35-758ed4ff7b47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6723), new Guid("bb61bc0c-032e-4760-8da3-ba6f11ddd438") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6727), new Guid("66ba8e37-3efb-4e00-b413-9ce6cf03680a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6732), new Guid("62cf9913-f527-4233-bc39-61d94e1e1cd9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6737), new Guid("0a304065-7320-46f6-a216-705c45758a97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6745), new Guid("8dee5c48-1cd7-48c1-b048-7c1ce6f28888") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6752), new Guid("9b1df1bc-6db8-4c41-8866-9390f4d8423c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6657), new Guid("848d08d2-b129-4789-9aeb-f079b5764e15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6663), new Guid("171a07a5-e2a5-4a21-a12b-50bf863c5931") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6667), new Guid("3ccf96ef-1324-4d8f-ba29-9c66b7808bdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6672), new Guid("8d40bf6a-2240-44f5-a0a4-fb2bc29ab899") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6779), new Guid("c289f124-0a73-4a0a-b534-6fc32edbe2e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6785), new Guid("e44f70e6-5666-491d-89db-28dd39bacd23") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7386), new Guid("c149d495-717a-42e9-bc3c-082b190e093e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7394), new Guid("d0f3657b-38fb-4dce-bfdd-1037462ab01d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7399), new Guid("9e6a790d-cf22-4131-ba84-160154dc4196") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7404), new Guid("848740e2-fa6b-41cb-b3e4-45fcc552ec92") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7409), new Guid("39128b94-acaa-4465-ad65-09c4116b847e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7414), new Guid("940e785b-cc7c-4ebb-b5db-d3603e144f00") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7419), new Guid("aa8f786c-95ef-44e8-9bbe-e23eb0f1d441") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7355), new Guid("011d9039-f3d2-4c52-9b38-147c82055c53") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7363), new Guid("9c1c6efa-8aa9-4c44-9312-ad4b626a5cb2") });

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "RT_EndorsementPatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");
        }
    }
}
