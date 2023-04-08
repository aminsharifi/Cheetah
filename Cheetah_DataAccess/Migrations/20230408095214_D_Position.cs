using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class D_Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_D_Position_D_PositionId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_L_UserSkill_D_PositionId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropColumn(
                name: "D_PositionId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropColumn(
                name: "PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.AlterColumn<bool>(
                name: "PSO_Independent_Location",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2227), new Guid("af9050a4-8850-473f-8043-9f5638783fe4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2245), new Guid("2bec77d9-a4b6-4504-a310-a2a02c8ca2b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2292), new Guid("381d8fb1-d0d9-4ee2-ac1e-2b3a02b9ce8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2300), new Guid("a476b02a-0724-4063-94ce-2e93545a232a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3042), new Guid("f82c6377-8764-4021-9a9f-45be898e0e5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3349), new Guid("19763c8d-d825-4230-aee7-ffa6a4784697") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3368), new Guid("5471fdc8-fd31-48d6-9f67-fd27ed817828") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3380), new Guid("bf9ff09e-797d-4ba5-962c-4134f9e9f731") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3396), new Guid("7c068c51-efda-443f-a9c9-8584fdb9b02f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3408), new Guid("29b7e821-913c-4e90-9c29-01a667130552") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3420), new Guid("8adad282-ccca-4032-a85a-164d80e839f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3432), new Guid("3dce1678-b121-4499-874d-eb03361af691") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3446), new Guid("55049574-6c6b-4984-a1f5-0f8bac21e0ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3458), new Guid("7e95dc72-daf6-453b-b048-90a0b2989a62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3469), new Guid("fa6aa8b5-07f6-446e-848a-3531586cb4f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3492), new Guid("e350d373-a361-4631-929c-d81535c1f977") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3510), new Guid("cd79ec99-58f6-4530-8573-d2aa74d931e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3522), new Guid("17d0aba4-3ca8-4aa3-855c-cc0537c917f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3534), new Guid("7a106c6f-9009-49be-be8b-d5ea0fec700d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3554), new Guid("5517fc79-2801-43d1-815b-5639c0a2e727") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3566), new Guid("75733aed-26ae-4ddb-9249-622792d235b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3577), new Guid("72f389df-b0fa-491e-b2f4-e85c9fbfea9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3588), new Guid("fec9e4ff-c672-4545-b105-c359da86073c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3600), new Guid("c48c2b39-2018-417f-8e46-3b4759cd34f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3615), new Guid("7af140c6-eb21-4cfb-8f3f-2b9f617ccb7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3627), new Guid("360e1c40-6342-4200-a54e-bb92becee588") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3639), new Guid("e144189b-a281-4a29-a0de-09915e60485f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3651), new Guid("e2464413-f44c-4d3c-b6f5-2207d695f903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3663), new Guid("e6da19e3-ae43-4cdf-95e6-6497ee4dfa01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3674), new Guid("9e47a18d-1c9d-4325-8b2b-b241b241cd8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3687), new Guid("10aa81f8-7206-4803-ae78-09b37f946c1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3707), new Guid("185d1658-809a-447e-bbb4-342273178688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2474), new Guid("4c50d4ab-7b06-48fb-88d7-62cc8fa64dee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2488), new Guid("097173d0-b0f6-4098-990f-bf0a2d0e1976") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2496), new Guid("e3754ebf-ae34-45ad-9488-1ad456a4ca18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2504), new Guid("25c8ba28-ccbd-4967-967e-bc58bc08df0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2392), new Guid("74f3a395-c4dc-45af-bf09-80db77e82003") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2430), new Guid("f9880c9f-a1e0-4b8c-b033-d18efc8d2aa0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2438), new Guid("1e5bd01d-dd28-43d1-b03a-9b0181a0eefc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2538), new Guid("ad1a7ed7-b260-4203-8691-cebdec17fd95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2625), new Guid("5dcaf849-3421-4744-854d-aa1d4b3a2e18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2634), new Guid("b3e025f2-310e-498e-aec1-f25ab1311d55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2641), new Guid("7f2580d0-b26b-4eea-b6a9-d2c901ddaaac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2673), new Guid("0ade1d50-a950-45d4-a1e7-ae58f5883acb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2685), new Guid("961cc03a-eed6-4af2-aaa2-568ce1e800fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2738), new Guid("015aa8ba-e3e5-4d0d-9b87-9818f082a904") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2748), new Guid("95fa717c-1fe2-4a15-aa94-a6db59812097") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2756), new Guid("b0b8ff6d-88e5-49b0-b83c-656c601f0f05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2764), new Guid("e7be3fd7-ee7d-4b6e-aea2-36cc779dc742") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2772), new Guid("78a35cb3-5102-48a5-9fcb-b9088749b6f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2784), new Guid("bcbfd82f-b0a2-462d-9b4b-9ca4948a3134") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2792), new Guid("59442b0a-bf8f-4191-b3e1-cb8c22bd5bf1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2803), new Guid("620c25b5-b77c-4d97-9943-935689819d96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2811), new Guid("9e3bfa69-daf1-4ece-8708-8921a68cd67a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2818), new Guid("c7d2d245-ed06-4cbf-ab76-50c1b8c38fca") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "PSO_Independent_Location", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2957), false, new Guid("b29907c2-9e6a-48a9-84cb-37ff0c689310"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", true, null },
                    { 2L, new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2970), false, new Guid("ec96a0d7-28b1-473c-a499-68188787b045"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", true, null },
                    { 3L, new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2989), false, new Guid("0c13791c-520d-4bbd-ac82-9a6eec468513"), 3L, null, "کارشناس بازرگانی", null, 3L, "Businessُpecialist", true, null },
                    { 4L, new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2997), false, new Guid("6c534972-8139-4934-be1b-a30d39fe5f4d"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", true, null },
                    { 5L, new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3006), false, new Guid("adec484b-2fa1-4e4e-a048-90be7e3edee2"), 5L, null, "مدیر مرکز توزیع", null, 5L, "DistributionCenterManager", false, null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1115), new Guid("43f3f047-2e27-43f2-ad8b-0a591ef6d977") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1307), new Guid("cd5ef267-2610-45da-9819-6fcf8e2444e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1318), new Guid("d34eed56-bbbc-4d73-9ad4-f9122fc6f90f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2871), new Guid("bfe1ee43-87e4-4ba9-82d6-22c9d7a9b2c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2882), new Guid("22eaf178-31fd-4f5b-bcb3-846dd5218866") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2918), new Guid("b92716dd-d907-4a0b-8fba-3f405b6b6bc7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2927), new Guid("c75b5253-40ea-4f72-9349-11bd6ba2012e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.AddColumn<long>(
                name: "D_PositionId",
                schema: "Links",
                table: "L_UserSkill",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PSO_Independent_Location",
                schema: "Dimentions",
                table: "D_Position",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<long>(
                name: "PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1381), new Guid("be389f00-0c17-4d4c-9845-74b0c0dbe2e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1398), new Guid("c3cd2c03-42e8-4826-b547-30c742e632f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1419), new Guid("ce95b2bd-55a3-45d1-9e81-8fe1b0e61aca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1427), new Guid("b5eda9c2-8328-4f70-8ae1-3d15f7c1aa12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3764), new Guid("ea82de4c-6a1d-4dc5-aeef-a1be565773a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4142), new Guid("cc6a6816-0610-4fdf-a53e-217676756a67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4170), new Guid("6cc566bd-917b-480c-ae7e-271fb2f7be17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4183), new Guid("04c43085-f40a-4295-b6e6-65aabbb1c472") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4197), new Guid("6b69c731-c0d8-4ee5-b54d-924aed039223") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4209), new Guid("cecd01a2-2a4b-403f-9bc9-d386b4d38cb7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4221), new Guid("96d2afa0-4940-4ee1-b4a4-1acafb02c089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4238), new Guid("c37ac892-f51a-41ce-aa74-b813a7a40ea9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4249), new Guid("5ed22806-3ef1-49d2-ba94-27a5d5dd68fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4262), new Guid("9c4a2230-466f-4803-86b3-0f7c6ee8902a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4273), new Guid("80caf8ec-8580-480a-9789-bc37e4d60c63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4285), new Guid("3a650c3c-35d5-4185-8dcd-a8a2de2d9d87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4301), new Guid("91a28829-0ba1-44a4-ae1d-00f1327a93f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4325), new Guid("d1d6c77a-0f61-4fa0-9712-84c749d18d0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4338), new Guid("c25f8d0f-6dc5-4b12-81b9-538214091da4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4359), new Guid("08933381-b951-4db3-ab7b-1d7a5e2fb4e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4371), new Guid("c2284b64-dc28-4d31-a320-8b435e79a7aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4382), new Guid("e1859985-6c45-40b5-95b5-84d149b1adf6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4394), new Guid("30a6d81d-034f-4bc9-bbf9-59a0c3ce8576") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4406), new Guid("d61d21d3-bae4-48ae-bde3-f328de734ae3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4420), new Guid("447bd6d2-9949-4866-a97c-7added26d6a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4433), new Guid("f3996366-5737-47e1-8941-c7a428cbc58d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4445), new Guid("83e5babb-7a12-4b09-b0ce-be592354b0ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4460), new Guid("98eb404c-471e-44f9-a635-ecc4fab3ad97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4473), new Guid("c7af8072-ae88-4bcc-85d6-0bc535503c58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4485), new Guid("60ddfae8-8691-482e-af97-d7298112ab15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4497), new Guid("aae55bb5-07b8-4948-b9b6-1827afc156cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4509), new Guid("bbf68b95-6d13-4fda-948f-7e01a90e7a2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1973), new Guid("77f5b96c-c3cb-44fd-a0af-6824ae17e0bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2009), new Guid("85bf526c-b075-47e5-a74d-53ef794db16b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2018), new Guid("9cdc89d1-7317-48c4-9be4-444e9752b81b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2026), new Guid("407db6e1-089a-43c3-99de-e609a3b39601") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1497), new Guid("783b9260-21b0-47b4-a8f2-977bb4eaad6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1879), new Guid("19a1fd34-9592-4ae0-8a9e-8dc28e3f82d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(1887), new Guid("57f6bae8-243e-4b15-a3c7-27bbb0139d9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2065), new Guid("f2a3e3fd-9d1c-4d4e-adc8-308354fc582c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2530), new Guid("6f13173f-002c-4de7-a792-5c5448f31050") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2561), new Guid("50db4eb0-f017-4e51-b8cf-8355904e4acd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2574), new Guid("a026a29d-2de6-41d4-87bf-726d47eb3afa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2585), new Guid("21487d7b-7379-4a46-9eb3-4ffcdfd69527") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2606), new Guid("dc485c56-aee7-4f85-ba2a-d71cb11b129e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(2813), new Guid("41fa6bfb-9c90-4818-b894-04b73807ab43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3136), new Guid("f12762e0-2a47-41fe-8c3b-b770d657a41f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3184), new Guid("f3863809-185a-40eb-98c0-09354122d88e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3232), new Guid("a97912b6-e0c9-4ba0-81f9-7afdc0ece4c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3247), new Guid("3f035a15-8ec3-47ee-b0a0-f6bebed7dc95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3259), new Guid("c75d4422-2634-405b-99ea-c22a3fd2d5ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3269), new Guid("67631c9c-1610-4e21-ac90-afbf83fcff77") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3282), new Guid("3de58319-2be6-4e9c-adb8-8ded9bf6cf82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3294), new Guid("07c01fb6-b868-4e3e-9e24-452256bf573f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3309), new Guid("9007a347-3d22-48d5-b96f-47e60302e79a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(727), new Guid("2a6e6fdb-63c0-47c8-9b07-79f46595ac56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(873), new Guid("170eb34a-444c-4f19-b002-1fe9cfa4dcb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(882), new Guid("b4a29cd0-6a9c-42ff-af2b-cdb6b8fed423") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3600), new Guid("5331b613-fece-4004-933a-588daf1af611") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(3676), new Guid("061f2ed3-0b82-499e-b174-28a9ff50c710") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4605), new Guid("09953523-c08f-497b-a680-f5621b8d1996") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 7, 22, 32, 40, 384, DateTimeKind.Local).AddTicks(4617), new Guid("28adbb13-c255-47d4-9853-f21ea23fd2dc") });

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_D_PositionId",
                schema: "Links",
                table: "L_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_Location_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationId",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_D_Position_D_PositionId",
                schema: "Links",
                table: "L_UserSkill",
                column: "D_PositionId",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");
        }
    }
}
