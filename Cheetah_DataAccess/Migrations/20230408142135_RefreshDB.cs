using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RefreshDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropTable(
                name: "D_SubRequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "L_UserSkill",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "D_Skill",
                schema: "Dimentions");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DropColumn(
                name: "PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.AlterColumn<long>(
                name: "PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1414), new Guid("560ed802-c1a6-4553-ad55-bc6f0b1aa679") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1430), new Guid("20d705f0-1df4-49ba-b48a-f8ec2183a1cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1504), new Guid("d55a76a2-3f65-4f44-ad68-b2ef85ea0340") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1514), new Guid("994662ba-eea7-433a-b4c0-ea3bf43659ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2299), new Guid("e400864b-8be8-4873-abf8-523040a24953") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2565), new Guid("e260a903-bb26-49ee-a1e4-24287e78b0d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2626), new Guid("bcad29b2-3394-4031-ae57-f2ff0ec3ea1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2646), new Guid("ad26ee71-ccad-4987-80a9-adcce1b829a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2658), new Guid("fce3e3a4-fef6-42a8-94b2-112d914c1123") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2671), new Guid("f3e64a5f-cefe-4222-814d-57ea416ed36d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2683), new Guid("7e5a9a4d-3e4d-4907-b74e-07eb61deb584") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2696), new Guid("84a692b1-b5cf-4fdc-ac3d-7ec550887fe5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2708), new Guid("1b564077-1459-4f33-9112-61e2acddd631") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2720), new Guid("f0a348d3-59c6-40a0-b03a-88cf7825878a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2735), new Guid("a930c228-bbb7-4f95-b734-b45fa822e0b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2750), new Guid("f06f5753-2b3d-454d-bf7e-ed63ebb3fcf4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2763), new Guid("ace1f70c-3df3-40d2-b825-d6387a43d2fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2774), new Guid("2c3cf2f7-b46f-453c-a2fd-553857286463") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2786), new Guid("75b4e3f4-be9e-4bba-bfc7-4425be81787a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2806), new Guid("2fe3b309-9d5b-46f9-9d8b-f9aec5eb25a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2818), new Guid("a78407e6-3e09-47d3-b1c1-1b18dbc5c77c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2828), new Guid("6e5f0cf9-69fd-404e-b319-fac71122bb0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2883), new Guid("3bebb7e6-4c46-44c7-ae86-8cba4a9cf6b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2900), new Guid("2d524064-559f-496d-8d70-90d8b410180c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2912), new Guid("255f9711-531d-4c19-adc2-12aadd6adbab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2925), new Guid("311705c8-d268-4e75-b1d8-4bc13b18e068") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2937), new Guid("9258e97c-7846-4aa7-9a0d-a53904880480") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2949), new Guid("525f4a1e-6f7e-413e-b1e0-94959537338f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2961), new Guid("954845c2-067b-43d7-805e-5a2a0fbd9396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2973), new Guid("c4bf7a7c-641e-43a2-8c41-157f86f73182") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2989), new Guid("11ae6642-587b-4900-bc9d-82116ba47c4c"), "کاربر-سمت(Links)", "L_UserPosition" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(3007), new Guid("5d3f4fec-2f4c-4a9e-9a35-aac4b0ee608f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1653), new Guid("ef4f4931-8314-4586-ab67-7509528601bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1664), new Guid("ca169b1c-9708-4d5b-bed8-e08006c1342d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1672), new Guid("9c9c04da-8420-4747-b73b-d355f569fb7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1681), new Guid("e181b07b-1ada-4c85-b702-0ef4051850c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1560), new Guid("73e3b6a2-03fc-478b-b358-0fc40c491c23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1595), new Guid("de4d80f6-4612-494d-aa92-827d5bca98c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1608), new Guid("e1542f76-4ef0-4201-a09f-09e5a1404bc5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1718), new Guid("1806c4a8-6944-4a51-86c8-b52b0fb28164") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1835), new Guid("08017750-7bdc-4d08-9309-7340de573b29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1844), new Guid("300cd6e4-d6b9-4fbc-adca-c8e93c6656a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1856), new Guid("ae1b280e-c4c2-41ab-96eb-1322b7ac1dfd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1863), new Guid("5e793126-2055-4d10-833e-5eb467967f01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1872), new Guid("a6ebfc5d-c137-40e4-a844-70ba9bee5a28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1918), new Guid("39e5613d-c697-481a-bf71-df1265e1f0d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1926), new Guid("2d7a4cac-581c-4b8e-aea8-3e040e46f522") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2210), new Guid("fe6378a4-0267-45e2-9e6f-d660a2c16f8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2220), new Guid("ab30167a-ac94-4b7c-b1aa-8323bc17ecc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2232), new Guid("515b5a39-e6c9-4d3d-90cb-e2391ce500f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2240), new Guid("befe2158-c443-4714-b5e0-e416c9f7fad4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2248), new Guid("beae47ef-b157-4b73-898d-1a5940d06470") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2256), new Guid("177e93b1-4a47-4493-9960-2641777415a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2264), new Guid("a48df445-8054-486e-b1cc-f488e7247ac0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2118), new Guid("12551375-fd6f-452a-8a59-50dd45e61d2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2126), new Guid("f6cf23db-d881-49ac-b0b8-3436b02a9a12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2134), new Guid("dc737e8c-1a9c-4a6b-bae1-a2d57a657db3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2142), new Guid("312c5c9f-7836-408f-827b-cd2161357248") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2171), new Guid("8d04d4e2-e83f-4cab-95ba-9ba24289542c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(695), new Guid("ab59ec52-11e3-44db-baf9-7a4826c99d51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(862), new Guid("40db9f92-d173-4f65-86fa-cde491d5f673") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(873), new Guid("3555a7ab-0adb-4d06-b316-c31f459167a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1960), new Guid("07cd6501-96fa-4476-b3b1-970eb566450e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(1970), new Guid("6060fc79-9c57-4aee-8c2c-3baafb5255c2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2058), new Guid("b151c839-3626-42a9-9002-b6991cd574e3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 18, 51, 34, 418, DateTimeKind.Local).AddTicks(2073), new Guid("9b967e99-d757-44ce-9685-17dfd6384a85") });

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList");

            migrationBuilder.AddColumn<long>(
                name: "PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "D_Skill",
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
                    table.PrimaryKey("PK_D_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Skill_D_Skill_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_SubRequestTitle",
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
                    D_RequestTitleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_SubRequestTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId",
                        column: x => x.D_RequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_SubRequestTitle_D_SubRequestTitle_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_SubRequestTitle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserSkill",
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
                    table.PrimaryKey("PK_L_UserSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_Skill_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 731, DateTimeKind.Local).AddTicks(379), new Guid("217144ce-4f1c-4a74-9585-a453c7693a3b"), "کاربر-نقش(Links)", "L_UserRole" });

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
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9343), new Guid("99e2831c-e6b8-4819-8e21-97664c128327") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9371), new Guid("e9600562-45b1-47b5-9fb1-57b02ad3728a") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "PT_P_FieldTypeId", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9293), false, new Guid("865ca2fb-8ec7-48c4-90a7-f6a0ad424a2a"), 1L, null, "سهم دیگران", null, 1L, "OthersShare", null, null },
                    { 2L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9301), false, new Guid("048a8a61-e9af-4133-90b8-57a2145607ab"), 2L, null, "سهم شرکت", null, 2L, "OursShare", null, null },
                    { 3L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9309), false, new Guid("6aace53e-67de-440b-8040-27c62d40dddb"), 3L, null, "نوع واحد مرتبط", null, 3L, "AreaType", null, null },
                    { 4L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9316), false, new Guid("a51551c3-8ca0-46dd-8723-da8c8417b61c"), 4L, null, "ستاد", null, 4L, "Staff", null, null },
                    { 5L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9324), false, new Guid("20a8d591-954f-4173-9c7f-1fb640317673"), 5L, null, "مخدر/ یخچالی", null, 5L, "Refrigerator", null, null },
                    { 6L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9333), false, new Guid("cb91cb26-106f-4d27-a1d9-754babd4ff8e"), 6L, null, "مبلغ", null, 6L, "Price", null, null },
                    { 8L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9351), false, new Guid("5a57d792-6827-4348-bd82-72a2da2c06ef"), 8L, null, "متغییر ورودی", null, 8L, "InputVar", null, null },
                    { 9L, new DateTime(2023, 4, 8, 16, 28, 26, 730, DateTimeKind.Local).AddTicks(9359), false, new Guid("74f873f2-169c-48ca-9556-a667e4372bc6"), 9L, null, "متغییر خروجی", null, 9L, "OutputVar", null, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PERPCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PName",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_CreateTimeRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_DsblRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_FirstId",
                schema: "Links",
                table: "L_UserSkill",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PERPCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PIndex",
                schema: "Links",
                table: "L_UserSkill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PName",
                schema: "Links",
                table: "L_UserSkill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_SecondId",
                schema: "Links",
                table: "L_UserSkill",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_ParameterType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_SubRequestTitle",
                principalColumn: "Id");
        }
    }
}
