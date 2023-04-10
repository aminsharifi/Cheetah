using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Error : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(7671), new Guid("b4c884fa-fd67-416c-8786-dab7de527c2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(7814), new Guid("d2b50f0b-553c-411b-b09c-5eae3d4c56f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(7837), new Guid("07b82d4e-5a05-49e9-a6f6-ed09ae0cd52c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(7948), new Guid("c2b6a9d3-0d45-40b7-b2e7-7956e87c0dc8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9362), new Guid("8ded7dd7-5f1c-488f-b026-857f36c62f09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9657), new Guid("be8fa434-1615-48f7-a6b6-744ae1240602") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9678), new Guid("80df4a2c-0137-48ab-baba-407b8eb589ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9704), new Guid("bc9ac035-cdb6-4a00-b2ba-11c675079afa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9716), new Guid("0ec7c729-62d6-4bc2-a79a-e9be3c88f7a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9729), new Guid("58c90695-fc42-43a6-9b8d-0c2f6d08e359") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9741), new Guid("6e768e93-0241-4240-a482-0a8d4e65bba1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9754), new Guid("3fa95bd5-5af7-4592-9fce-47c7c0cbb8c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9772), new Guid("4f8e2239-0be7-42f9-899b-1ce4aabe2878") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9784), new Guid("2231babf-a39f-4be0-91c9-09376cf19973") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9797), new Guid("7111222d-2343-4d2c-9b2a-a6c5297e8643") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PIndex" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9809), new Guid("6da4fd12-b99a-4503-828b-1cf9213c644c"), 111L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9822), new Guid("05ec636b-e30a-48d2-9d91-ab29ccd7e87f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9834), new Guid("e008ad5e-5e75-4ffc-8436-74c7edbb25b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9847), new Guid("4c375713-0154-4343-bbcd-084dc9c44941") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9866), new Guid("b56331d8-b9e6-4c8f-b84c-ac6dc221c2c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9882), new Guid("026ee37e-70a1-4c82-8749-883cf9544b47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9893), new Guid("809d2956-0ce3-4467-bdc5-20c66253a3ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9981), new Guid("1c0dbcd6-ba31-4067-bbf4-93ba5cbfe38e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9998), new Guid("2a83d19f-19e3-4164-9fae-7351532a107e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(10), new Guid("184feac7-1c72-46f5-af3f-94e4bafb4235") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(23), new Guid("f2b3126b-bb54-41f3-b935-b2aec3c3fdb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(35), new Guid("12964e6f-a962-4bf3-abdd-818a5e26d1ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(48), new Guid("4cda0d72-0790-4e0e-92cc-045769bc8b2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8667), new Guid("d50d2c35-10ae-468e-b2bc-8d428c85d8aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8678), new Guid("41160fed-306b-4442-9527-f4d1dbda82cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8744), new Guid("b8b181e8-0c93-4c4e-b191-3c44077b0643") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8793), new Guid("e5a09c06-839e-4bf1-948d-5b2fd761b97e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8611), new Guid("6f81f7d9-909d-4012-8618-3f63ca4794f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8620), new Guid("5362d46b-0cb5-452b-9da1-1ebaac96a375") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8629), new Guid("a6feab63-871c-4695-9f03-1bdb6262f5b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8865), new Guid("e5069f1b-f865-421c-a852-f9cc87bb80fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8884), new Guid("5ef689bc-16c5-46c1-8e1e-ed733e950111") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8891), new Guid("0eb027f9-e6e9-4dcd-87d2-37ecde4442bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8900), new Guid("4372aa4f-5f99-4f3a-ab61-0b0386f2493d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8908), new Guid("f68893b9-3d0a-43ac-8fd4-d1f5608e31f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8916), new Guid("edba45d0-6595-484b-a19c-10fe7b385318") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9016), new Guid("b151bfe1-d22a-490b-9e1f-70a9d173292f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9025), new Guid("f2278c62-0d0b-42cb-8b9e-2297c630edec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9033), new Guid("9b046b65-b269-48fb-b91f-1ccb7f35c548") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9046), new Guid("28234a4d-da7d-4ca4-a2c1-97456699b12f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9066), new Guid("16822aa0-819e-4db9-8aaf-a3fd2fbbb1c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9075), new Guid("251130d4-3da6-4b90-a42c-f2a4ee6cbc73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9083), new Guid("767effe9-0eb2-4860-8d5b-33efdb62e98f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9091), new Guid("ad061fab-746d-4eee-8d59-e398a4b44a26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9101), new Guid("3d9734a3-8f66-4125-89d9-9dcb09e69560") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9109), new Guid("0f1282f5-8855-49b5-8241-050e04fe093b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8964), new Guid("35501c5a-3471-47af-b199-98a2aeeebf4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8973), new Guid("e5401abf-f4b3-4d2a-b2e3-0c5b548d4f50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8981), new Guid("aa3d0170-7206-4f18-96c6-4026b62ee392") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9277), new Guid("625b70e5-dfdc-4416-bd3c-05fd548145f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9286), new Guid("061802ef-6548-4b00-b14c-7e4927ceea11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9294), new Guid("38c81c7b-c9d9-4174-8ad2-197950fa1a8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9301), new Guid("58ff72bc-fd67-42f8-ae66-4b4b3c06d3cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9309), new Guid("e8929609-c3b5-4464-b155-7a977faeadee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9317), new Guid("b0847710-6cae-4c1f-a865-9ea856940f0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9324), new Guid("3a646689-f48f-4cc8-884f-4216db832647") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8524), new Guid("70967a0a-b2ec-4e30-a338-2a51fc0fe703") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8564), new Guid("7409cd27-dbac-4b42-a969-acbd54740417") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8571), new Guid("98a3a574-43a7-4dd9-af46-0ea2e822834b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8447), new Guid("46796de1-2550-4761-8530-02c510799a92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8470), new Guid("3e6295b6-84a3-4d6b-9bf6-8d1075605575") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(8478), new Guid("4974e26a-5b34-4c11-82f7-a71b79cfb1f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9205), new Guid("76c89b5a-e20c-4e91-85d2-614441214114") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9214), new Guid("057bfee1-ad32-42aa-8724-e79657045c23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9222), new Guid("00508d6e-8b9f-45fd-8f20-d166659ab5f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9230), new Guid("c0cdc9d8-af1a-4c68-a535-6f661823f86b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9241), new Guid("fb9faee3-51ed-4f56-892b-c1d3aeb380eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9150), new Guid("5a08fa94-72a6-4d7e-ba6a-3f7653971883") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9169), new Guid("88ded2cd-2131-4c1a-a755-72b15c9f9dd2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(184), new Guid("3af1d30d-27c9-4654-8609-2747b71c9b98") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(193), new Guid("7964c87c-f685-4c6c-8541-3e07f7986a84") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(201), new Guid("49acd2b8-a2f8-4ae0-b84e-21f4beb6e278") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(208), new Guid("f2fd36ee-6ac9-4cfa-8311-35736ceeac91") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(216), new Guid("35dcc867-c7bf-48ae-a21e-5f5b618c469f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(223), new Guid("1282d83b-9972-4fc8-a7a4-711d8c089f26") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(234), new Guid("45a5f77e-5d2b-4390-aba3-b3b68f788a39") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(266), new Guid("57f9e134-0c01-41b0-a0a0-e99b329e7b33") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(275), new Guid("12c35a92-f601-4de0-bff5-de71b719b8dd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(283), new Guid("47edb625-274a-4dac-ab74-790f21196e1e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(290), new Guid("4e29c31c-2fa1-4bf5-ad36-a1de7d8fa1a4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(131), new Guid("c2228c2d-aaaf-492b-b22e-25c6c0273735") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 267, DateTimeKind.Local).AddTicks(142), new Guid("e61ebde7-87fd-4202-9af2-4f3cbca14f97") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(779), new Guid("bea0e4c5-8dff-4d1f-a30e-8c2602fbb666") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(930), new Guid("e9f28cc4-ea4c-4f4c-9a92-73a8b643f05c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(953), new Guid("e508f243-e42f-4db4-bc2d-ae4052e75a67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(991), new Guid("f91f8d5b-8cca-48ef-aa0d-0ec3786931a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2445), new Guid("73da8e65-e649-4151-9c4b-2d6e7706539c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2729), new Guid("c5b42ce8-0305-4173-8ef9-efc508a2804c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2746), new Guid("d5003a21-e318-4ef9-ba98-dc53834a8397") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2758), new Guid("80198f10-1909-4e82-9aff-dfd8a471786e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2770), new Guid("9728f063-261b-4c96-9f3d-4ddfee545f8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2784), new Guid("b7152c1d-4450-4360-abee-c7bf0039d4cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2801), new Guid("d4110ae9-3bb3-4ca0-88b7-ae8c1823aa64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2812), new Guid("793f029b-7854-4ba5-83ec-9aef327ab4ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2836), new Guid("d3d5024c-79d9-4ea9-8f8f-4d4216c59685") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2850), new Guid("a0e4aff5-01d3-45a2-9095-0549aed860d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2862), new Guid("539ec988-ea34-4c2d-849a-560226a6ea3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PIndex" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2901), new Guid("6126b05c-0c91-46ed-a6bd-694e807640f4"), 113L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2915), new Guid("da73a9da-6452-4bc5-a0b5-022c25aa4d6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2946), new Guid("02264cd8-8fb2-461e-ba6b-6f7a5223a7cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2960), new Guid("c86ad5ab-58b0-4fb4-8d48-930671a431f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2971), new Guid("1a458ad6-2e31-4962-971b-845285141a9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2983), new Guid("036f7e8a-fd9f-4972-8dd3-5757f2564679") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2996), new Guid("4d519be2-0226-48e4-b41b-7fef74e5aaff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3009), new Guid("94f4cf16-37ac-42e5-92b0-2a706e0cd04f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3022), new Guid("e1a5d3c2-d212-48a7-abb3-486cc279fd60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3037), new Guid("56ceea00-b723-499c-9353-d833a5260b33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3050), new Guid("4becfa57-af42-447d-8225-ac24c2578b56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3072), new Guid("b28ec165-dd0a-425b-abcf-16703a51d2ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3085), new Guid("6269dcfa-0bb3-49a3-8f66-ee9690e02f1a") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 111L, new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2874), false, new Guid("ac74adf0-4d21-4f28-861c-098eee84f22c"), 111L, null, "حرفه ها(Dimentions)", null, 111L, "D_Skill", null },
                    { 112L, new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2885), false, new Guid("efd65545-c3a9-4da8-b8af-77f04b03e58c"), 112L, null, "زیرعنوان(Dimentions)", null, 112L, "D_SubRequestTitle", null },
                    { 305L, new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3096), false, new Guid("8882fea7-7236-488a-9ebb-e0cb909d4c7c"), 305L, null, "کاربر-حرفه(Links)", null, 305L, "L_UserSkill", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1784), new Guid("7da0651e-d60c-4d48-960c-a6f066b47b51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1795), new Guid("89e550ea-4671-41eb-adfa-5e723cbf6079") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1867), new Guid("da0c6279-dd5e-466c-beaa-8a96952f4747") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1880), new Guid("735a3e3b-861e-4fb5-9abb-77c44352e18a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1728), new Guid("0c72291b-5653-4d96-9406-a8cd44d917ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1737), new Guid("4e8214e8-6d08-4f5c-9560-b0eb4e73e19f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1745), new Guid("2ddede05-e21a-48f7-8d1d-a8f08badc545") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1926), new Guid("d50c2911-6f10-49fc-956c-f93b82f2de4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1935), new Guid("600c8e56-e241-4789-96dd-12a4a89d5291") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1943), new Guid("e0ee7d81-ac9b-4f1f-832d-18f72ff1b73f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1951), new Guid("7a358662-f25b-4ae5-8d09-55ca90fc38b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1958), new Guid("72237962-ed86-4c7d-802e-55044f6cc03c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1966), new Guid("0a576957-1fc9-473e-af16-90da3e6c8154") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2080), new Guid("3fc3579f-c6f8-456a-8402-e701eef83f2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2089), new Guid("08845517-0bd6-4c56-8df2-9e3da2e903e9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2097), new Guid("c566b816-fa41-499e-beb7-45d22c8cea45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2105), new Guid("f00c10f7-ce81-455a-88c3-55d84b6f7f5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2134), new Guid("0d7ce4e1-4dab-4859-842a-8fafd2bc41b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2142), new Guid("a970ef35-969f-4379-8173-4f83be01cbff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2155), new Guid("3e748768-2a57-4c14-b8c7-27ae5de46508") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2163), new Guid("a24cee3a-9999-4d90-a620-f7a6fc332f69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2171), new Guid("e7f49a43-1657-4191-9005-50762278e4ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2178), new Guid("ad001068-9750-4b30-9609-0a63ce11f5a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2009), new Guid("2392faa9-ade9-43f4-9415-f3deb9899d92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2038), new Guid("b89ff17b-098d-4856-989d-1d12c501bbe8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2046), new Guid("57c46fe9-7717-4215-9fcc-a48f04f43c14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2355), new Guid("f6645e59-c777-4f13-823d-75070f40ed4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2365), new Guid("1cb9f8ca-d69f-4e54-9eed-3f35cba81f3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2374), new Guid("0fe9fae0-3e23-4965-962f-c8aeb8b4e451") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2382), new Guid("350cc10b-d742-437c-839a-55752d2966dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2390), new Guid("8671841b-67e4-4dd6-b315-8a93942cc166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2402), new Guid("cade8b48-ad58-408e-a7b0-2acc7c376c29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2410), new Guid("15b7ff55-c6ce-4fa1-b141-ced065eaf962") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1630), new Guid("0383485b-e8eb-40de-957d-97124539f9ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1683), new Guid("59450641-64d9-444d-ad96-822824c8977c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1691), new Guid("228589f3-d4d9-441e-8120-b72a55735374") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1552), new Guid("bf67ff98-7b8d-4e65-b9d6-bfdbc4286738") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1577), new Guid("7c50246b-9578-41a8-9e83-a70862e5aa7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(1585), new Guid("6f164e25-6271-4b9a-8473-44216a1fae3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2266), new Guid("3a9ef24d-4f53-4a49-8811-45a317bddacf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2276), new Guid("1cb0aa50-2f26-4103-838d-4632a62d8375") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2288), new Guid("46455bf4-e1c7-44f6-a177-615d57d4dae5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2297), new Guid("7536113a-ceb6-466c-885d-3fc7c2aeb248") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2305), new Guid("8a593b28-ff42-49ae-9cd3-14bbafbb7a2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2222), new Guid("521de8c7-0268-464c-bfa3-1fcdc7b4f938") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(2232), new Guid("3f475ea0-a086-4845-b185-d23b65ae409f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3227), new Guid("275049c8-6e10-40ae-b5cc-ed2db84bf33a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3240), new Guid("c03325cf-605d-4e9f-a113-11293353cc11") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3248), new Guid("49292f68-c0f6-4dd5-97c0-d9ddb004e2ec") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3256), new Guid("292daeb0-9e97-42bf-9397-46de0eb05758") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3264), new Guid("49f5f2c7-9674-4ecf-9afd-b428f4535c45") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3271), new Guid("1d191ca1-4094-4aca-ab7b-c0709cd4d723") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3279), new Guid("1a35b514-4dcb-4ac1-ba81-62ee06061ef4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3311), new Guid("4d084419-3c18-4a07-921b-529784c022bb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3320), new Guid("d957ff7c-bb93-41e6-863a-f1ee9f246b5e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3331), new Guid("37f6107f-2dd7-44d9-ad77-c14b3b4678ee") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3339), new Guid("0a5ae62b-0bc7-4a42-901a-3f1f07ddaccb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3173), new Guid("3bd2319e-f2cc-428a-bdfb-1bdff4af4225") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 13, 26, 50, 105, DateTimeKind.Local).AddTicks(3185), new Guid("6f93028d-1477-4dda-86f4-c2739dbd417f") });
        }
    }
}
