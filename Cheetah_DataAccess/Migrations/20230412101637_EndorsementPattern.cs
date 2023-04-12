using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EndorsementPattern : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.AddColumn<long>(
                name: "RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(8968), new Guid("dc347abe-3b35-47be-b540-0f7a1c1d588c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9166), new Guid("0f97e3e1-95f7-46b8-984a-2f651d33fff7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9198), new Guid("50c50ea1-12ca-48e0-9374-e8546264c463") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9256), new Guid("506fbe02-4664-4723-b9eb-ec458cfb7a9c") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(523), false, new Guid("e1001fb9-7b11-4ecd-a7ba-a62bfc427993"), 1L, null, "الگوی یک", null, 1L, "Pattern1", null },
                    { 2L, new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(609), false, new Guid("5849051c-a884-4cf0-8a57-6a9efab921c4"), 2L, null, "الگوی دو", null, 2L, "Pattern2", null },
                    { 3L, new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(621), false, new Guid("797bff19-7c53-4b56-b4d2-d3b15c123d22"), 3L, null, "الگوی سه", null, 3L, "Pattern3", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2195), new Guid("e12a78a3-8d71-4d5c-9219-129a02f60d00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2584), new Guid("0dce6928-57a4-48e5-b398-a89af9076c36"), "نوع فیلدها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2614), new Guid("3f3df689-8946-4f92-9cc4-d619e6adf8b0"), "موقعیت‌ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2626), new Guid("7c9d698b-c532-45b2-a9c3-1abb64e869f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2641), new Guid("c852963a-db86-44f6-a7dc-c7f11238892e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2653), new Guid("0327c4b6-b3ef-425f-8354-845fbf70bccf"), "نوع‌های پارامتر(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2677), new Guid("5c8639d6-3346-478c-9f14-53a2bd78a0f0"), "سمت‌ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2690), new Guid("8922e7c6-4cda-4f0f-bb02-61ae6ad9bcce"), "تاییدهای فرآیندی(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2702), new Guid("76370b08-64c6-41d6-a285-ea6e5082670f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2714), new Guid("8b377ff7-eea0-455d-abfa-a7dd03b4d9d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2729), new Guid("ceea188c-2db9-44bd-b67b-a190f8fbe0bb"), "نقش‌ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2769), new Guid("4a78a4d7-e2f1-49ff-92c7-41538e73d055"), "تمام تاییدها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2782), new Guid("32a33e1f-bb8e-4bdc-9a10-b89f15ca381f"), "تاییدهای جاری(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2806), new Guid("936eca65-adad-4cf6-ad08-48e5916049f2"), "ضمیمه‌ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2819), new Guid("fec22c56-05cf-4f54-94ae-4d9bd6f918ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2832), new Guid("95d86378-4710-4c46-8ecc-4e24205937bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2847), new Guid("c4f57b84-5a59-48f4-9eb8-4c68f8548fdc"), "اطلاعات درخواست‌ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2860), new Guid("23f124f3-22df-4b14-a0a5-6b7965cf0267"), "اطلاعات کاربرها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2874), new Guid("e59870cf-a12a-40f0-bfff-c8a26f0dc676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2896), new Guid("781016fa-ebfd-4b75-8bcb-90cf020a5f9d"), "کاربر-واحد(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2910), new Guid("48b6d65a-6e5c-4424-902f-11aab67842eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2923), new Guid("ed3fcefe-0bda-4512-952d-8be6f6732468"), "کاربر-موقعیت مرتبط(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2935), new Guid("eb4087f2-70ba-48d3-b522-112522b10d6a") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 111L, new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2742), false, new Guid("a8d91327-d708-49f1-b31a-aeae3d338745"), 111L, null, "کاربران(Dimentions)", null, 111L, "D_User", null },
                    { 112L, new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2757), false, new Guid("b65aaafd-33eb-45ad-8689-ec9ead8c2240"), 112L, null, "الگوهای تایید(Dimentions)", null, 112L, "D_EndorsementPattern", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1260), new Guid("3c28f1a9-fb73-4ff3-9d2b-afda1f85c037") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1274), new Guid("5bcd8044-beb9-49db-bc0e-43d369bc20b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1284), new Guid("2c0df146-79cd-4797-ab71-ef04548b660c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1300), new Guid("0b2eb987-7d0f-4d05-b890-18a004f22cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1311), new Guid("a9b215f2-9674-47b3-a301-6dcb2634bfa2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1024), new Guid("09c71890-dc74-432f-897a-e49cad68fd45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1191), new Guid("f6768a92-3e14-4863-a627-e22659a2a598") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1204), new Guid("a372215b-4de1-434c-bc01-6a9e61a7d5b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1372), new Guid("add87c31-7a8b-4af6-8208-19bb0f8b6959") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1385), new Guid("8f2cc5bd-3a03-430b-8add-860476401a80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1395), new Guid("194a5415-db67-4649-a331-540c9af9d5d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1410), new Guid("c46aefe7-48d4-4a33-bee4-a4e64af2c0ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1423), new Guid("2e0535f6-6fab-449d-b61e-f4254e4c5a33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1436), new Guid("349987c9-d917-41f5-acd1-0475667b38a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1765), new Guid("8bd43df2-535f-4bc2-b98b-e6a85f506507"), "عددی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1805), new Guid("9e30895c-7882-4df6-8af0-f68edf19e6f2"), "عددی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1818), new Guid("b0b9f080-3a2c-4820-8134-1d6cd65fbbd3"), "دودویی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1826), new Guid("96382338-8e5f-449b-8ea7-4836d9b239bb"), "عددی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1835), new Guid("3bb98a07-8f84-4bca-8ba7-39bdd2ecccf3"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1843), new Guid("90bf739a-c459-4add-b7d4-dd779ae42f4b"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1851), new Guid("c239e71b-029a-4911-991d-f7fedda87454"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1859), new Guid("be9e0023-ed99-4fe1-9c3f-c4a1bad77381"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1867), new Guid("8dd70bb2-3f82-4faa-b92c-c626beae99d1"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1875), new Guid("54961313-180b-481e-ba4d-f834506fcb66"), "پارامتریک" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1496), new Guid("b3205890-08c2-4827-a6db-1ea32c2499ed"), "متغیرهای عددی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1536), new Guid("9735cd2b-92c9-48bf-938b-57777393d264"), "متغیرهای تاریخی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1568), new Guid("39d10ef7-706d-47b5-9b92-f658377f2ac0"), "متغیرهای حروفی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1579), new Guid("1158b417-7bb3-42a8-ab15-859c3bedbcbb"), "متغیرهای دودویی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1589), new Guid("f89b5a7b-afc7-448a-a2fb-1cb5b1138b08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1605), new Guid("ddfa493f-81e8-4363-98a2-1217d14b9fec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2105), new Guid("587244b1-5a14-49e2-b771-d8f6b8a96d45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2118), new Guid("91f1469a-7154-49ea-8789-01c4b3dc441b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2126), new Guid("f32b4b23-e535-47db-a148-04621caa5948") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2134), new Guid("930c170d-4206-4214-ba3a-61a15e8f0235") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2141), new Guid("abc86d08-b97e-4480-90af-f3d863ffe915") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2149), new Guid("9096407f-0ff5-4921-a230-208d663281da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2157), new Guid("743b4669-3a2d-4391-955d-1a37f8201746") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(902), new Guid("109a7c9f-99eb-452c-a279-c46d333db4ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(918), new Guid("86b6e09e-2a8f-4aab-8d41-e20818c19626") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(941), new Guid("13a116c1-c11f-409e-902b-a4b915f698b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(961), new Guid("d8b72325-8ae8-4f83-90e3-7d4a61783051") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "RT_EndorsementPatternId" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(753), new Guid("1de7d765-12b6-4d7b-bc7f-d7b2cbface1e"), 1L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "RT_EndorsementPatternId" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(826), new Guid("f610aecd-dd76-4f0c-bfd9-34c00869c736"), 1L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "RT_EndorsementPatternId" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(839), new Guid("fbab72ae-baae-4173-9111-e650adcf7d96"), 1L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2011), new Guid("38655bf9-c8b9-41fe-a243-3dd214a41487") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2021), new Guid("a5356e44-4651-4af0-b770-a98edd850405") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2045), new Guid("9fccb0be-b954-4171-860c-e97ad83c3cb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2054), new Guid("89094149-6277-4d70-b563-83017afdf65d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2062), new Guid("4813f801-0cb3-4989-81fc-8eca89ce5d5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1968), new Guid("58330b31-26d0-49f2-8c7b-61ad359db3ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1979), new Guid("de21821f-5067-4ff0-8341-00320f730913") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3074), new Guid("4bd675c8-e335-4d04-b4f2-63482a2ce649") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3084), new Guid("b3e61af7-543b-44ad-adff-0966f961a7e5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3092), new Guid("5766bc20-52f0-403a-860c-86e54308a2b5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3099), new Guid("811f348e-c12c-41b4-b8e4-9c7d06315068") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3107), new Guid("4399b964-b3b5-4fcb-adce-02055a9f498e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3115), new Guid("a1969e30-7c89-4bdf-9dac-1d3e46a36733") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3123), new Guid("e86b9d71-3070-44cd-ab9a-7b8b84ae5cf3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3536), new Guid("1d39aa70-6a03-42d1-8153-16bd8551114c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3610), new Guid("9d7a7e51-33db-437e-9019-3ccbdc7cf672") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3627), new Guid("2dedf1a7-4df3-4a49-b8d3-d7b50b4cad4d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3640), new Guid("179301fe-e2d3-494c-9a63-340a90eb737d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3018), new Guid("bf6a1b7b-e35d-42c8-8901-9129bf923472") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3032), new Guid("b4dcbdce-49f4-4a82-b072-042eceba1969") });

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "RT_EndorsementPatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_RequestTitle_D_EndorsementPattern_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "RT_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_EndorsementPattern",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_RequestTitle_D_EndorsementPattern_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_D_RequestTitle_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DropColumn(
                name: "RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(4431), new Guid("af0623a4-87ea-46c3-bcd4-48d402d7344e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(4587), new Guid("d50ea6c3-b338-4231-975f-57bc86d33f3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(4596), new Guid("9552c698-8cff-498e-8c96-9dbc1769b1f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(4903), new Guid("3fb07ad7-42ce-408a-a8d4-70bdd6f8a722") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6472), new Guid("6c92012c-2f6e-4d13-b2cf-7d6fc39e9661") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6770), new Guid("2dfad762-d4d2-4aac-bcd7-9f6e517a45f6"), "نوع فیلد(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6793), new Guid("9f2e37c3-5df2-4eb0-9e60-49a5a61ead17"), "موقعیت ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6818), new Guid("b0ff8d9a-a3ce-4a2c-a4be-2791e3f90878") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6831), new Guid("78cd9838-cb00-4c16-8f83-49b466594e76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6844), new Guid("9bc0bb97-15cc-427b-b451-bb515b724845"), "نوع پارامتر(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6856), new Guid("0ed98f65-abe8-44bb-8426-c172563ff152"), "سمت ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6870), new Guid("acc64f55-2aac-4510-ba9e-c6e7181cffe4"), "تاییدات فرآیندی(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6881), new Guid("09181cb2-5f2d-4766-9bcc-f292db97207c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6894), new Guid("359758ba-c2db-4c73-b49e-95425e6570a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6908), new Guid("0fb314f9-a1b0-419a-a82c-354b52bd84cf"), "نقش ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6932), new Guid("b7abce90-d5b3-4649-9285-209e28b91f37"), "تاییدها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6944), new Guid("b46ffad2-dd89-49d2-97de-1a3cfa3059d1"), "تایید(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6956), new Guid("d599a14c-0054-4cb7-b2af-d4582502e90f"), "ضمیمه ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6976), new Guid("a3e1ee95-b411-41a7-b8db-54fe38497584") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6989), new Guid("4255bf94-7bcc-4801-b886-f3beb30d2553") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7286), new Guid("d3d04709-105d-47ce-83c3-6777c2b2d703"), "اطلاعات درخواست ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7323), new Guid("9d4dad46-236b-40e3-ab7d-a7f7aab62309"), "اطلاعات کاربران(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7354), new Guid("424ad4db-5ec0-4ce8-9760-85340c34b0be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7368), new Guid("a9d8331f-7734-406c-bd49-aa0a0bf6cc91"), "کاربر-واحدها(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7380), new Guid("093c9356-92dd-4726-bdd1-7f3686fae049") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7392), new Guid("e4370126-0580-448a-ba48-aa72218d1a63"), "کاربر-موقعیت‌های مرتبط(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7406), new Guid("8678849f-f944-4f88-be93-2bb05af4f916") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 113L, new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6920), false, new Guid("b79cc5b7-7a25-48f6-9b7d-d6f0e46208d6"), 113L, null, "کاربران(Dimentions)", null, 111L, "D_User", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5729), new Guid("a91f8375-2f17-4e5e-8252-536611e52314") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5829), new Guid("a9e594a4-31f8-4334-8af1-c0eddd529336") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5838), new Guid("c3418785-b94f-4c98-becb-62e8e39dc6f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5849), new Guid("3e35b5be-36a1-4f17-85c6-f87e21e5302a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5857), new Guid("5bb990b8-0bab-4cf8-8655-445a2f438755") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5680), new Guid("41a9fbe5-651f-48b2-815a-92d9243e8aec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5690), new Guid("fa96f1ef-c14d-44ef-8f0a-2dce2db80b4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5698), new Guid("aa24d53b-2ce4-44e0-9ac4-8e2af7a7b4b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5897), new Guid("c0d89bf9-ec23-4380-953f-c39d8e6611c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5907), new Guid("8ba7a614-6a95-4d79-9691-680efab78cbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5915), new Guid("25b4af8c-0ad5-4558-b8d8-80e799f3a49a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5941), new Guid("f4cb6171-056e-46ff-8438-8f1e53594c2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5949), new Guid("8d78b453-586b-460f-9cb7-0771fa63850e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5956), new Guid("63f772f7-faab-4e4f-b23e-d50539f83180") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6112), new Guid("db5f952d-6233-4bdf-9fc0-acb42db9d7a2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6129), new Guid("1193f797-d110-4ade-bd4b-c38813e2d559"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6141), new Guid("1be849d1-e323-476d-b412-62be974ce53b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6149), new Guid("14911e8c-bdd2-4887-85b7-36d1d4a95eb1"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6157), new Guid("770dbc27-6d93-40b7-befc-e8746afc9837"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6165), new Guid("62334049-d7ae-43fc-89fa-e3f461962c2e"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6173), new Guid("037420ca-38ce-4d5b-a0cb-98e33df57cde"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6181), new Guid("dd9f373d-846e-4c98-86c4-606185b65e23"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6190), new Guid("44d20e09-4d75-469f-a390-203e42bf790c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6198), new Guid("de162a43-9604-4d77-b399-a4617b887cd6"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6001), new Guid("ccdbb05e-1cb9-4c4e-ba2a-ab6e66a889e2"), "متغیرهای فرآیندی عددی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6012), new Guid("0ded7e2f-0d97-48bd-94eb-80cee4ab3f21"), "متغیرهای فرآیندی تاریخی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6020), new Guid("639366f4-6060-4c6f-819e-9189a468f7a4"), "متغیرهای فرآیندی حروفی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6029), new Guid("ed59768d-bb55-4854-9113-372631b8baa7"), "متغیرهای فرآیندی دودویی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6037), new Guid("b37fb6c7-70e1-4de0-88ef-3a0d71f8aeb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6069), new Guid("c6baefc4-1c52-4453-ab9a-8cb12631bfe7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6383), new Guid("0feaefa1-76f5-4c5b-a2a6-86d2657dbc4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6396), new Guid("247b0637-48e8-450b-8c37-8723d33df4a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6404), new Guid("06881369-9e4c-4ad3-bbba-2eb29b36078a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6412), new Guid("0bfcbfef-afe8-4958-aff4-af2b9913ba65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6421), new Guid("f2734438-b9c1-4082-b25d-7dd05e6fd49c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6429), new Guid("a13cb7ff-bd8d-4656-8ccb-54b65ece0e68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6437), new Guid("5fa66543-8d5a-490c-846b-f1068bd2bb67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5568), new Guid("1dce4fbd-eab5-4559-ace2-18deea3b25c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5615), new Guid("4822b744-1bab-4307-a101-3c89cad76709") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5631), new Guid("b2d3e939-ec65-4641-9828-edf3705b52c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5638), new Guid("fcb0030c-11a3-46f2-94be-008fe96b75d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5498), new Guid("9509cb08-d089-49ae-ab91-fd4f552a18d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5517), new Guid("0bdc0583-7cce-43aa-b775-445ca683a140") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(5525), new Guid("ada96504-a061-4ba9-86e1-15ecbcab0007") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6308), new Guid("8f4e1294-e411-49d9-8af9-a58da4e0da4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6319), new Guid("7b4b8c1c-8442-4d5d-8682-a6b22e0a7c99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6327), new Guid("77a807f9-9093-4446-a3f6-ed802bf18d7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6335), new Guid("6a326bc6-54e5-4396-a5c9-a52cc31842fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6343), new Guid("a11cec4a-a132-4f65-aab5-2beca63933c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6250), new Guid("f97898bb-7c7d-4f18-b5d3-ee2699168315") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(6260), new Guid("5f03f973-ef3f-4083-b86b-1f7a350cf18c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7588), new Guid("8ebb5ae6-773b-42ee-be27-1ff25e101c97") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7599), new Guid("c980b39e-2e30-46f4-a240-bf66d3f7364c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7607), new Guid("54fd09d4-106b-4d99-bc2c-3b9c0c24e9f4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7614), new Guid("ef5d5f76-b27e-49d1-b353-79e4161fe04e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7622), new Guid("14427088-696d-435b-af24-51e8d168ddb4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7630), new Guid("ccaa418c-0a40-4f48-b13e-312e2130a9c9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7637), new Guid("4043053d-53d9-4c47-a9d4-449859e796c2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7671), new Guid("5f90db46-1668-410b-a2e2-d2357371a054") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7686), new Guid("8fd1b1a9-dc40-49ff-af4a-22acda96c612") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7694), new Guid("63f1bfd6-dd5c-442a-a11a-77ec321b5450") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7703), new Guid("307e34c3-b0b6-4069-8b78-f7b2087cb8ff") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7530), new Guid("fafefd12-c1d3-4725-bf3e-4b8563ac2f08") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 13, 25, 27, 642, DateTimeKind.Local).AddTicks(7544), new Guid("7d5216fe-bb5c-4dc8-87f7-4a960efa64ea") });
        }
    }
}
