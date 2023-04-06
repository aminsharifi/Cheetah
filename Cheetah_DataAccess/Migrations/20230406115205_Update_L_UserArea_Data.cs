using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLUserAreaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7463), new Guid("416c2afd-f86e-499e-b191-c1287a09b343") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 2L, new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7519), new Guid("3170a11f-b080-4bd2-9020-2295c01ee5da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7527), new Guid("413c3f0a-92ac-4ffd-b612-246c0c0babd1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8065), new Guid("fa33c901-8591-4315-b443-bdea5e40c692") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8372), new Guid("49b1254f-cc49-4978-ba7b-f84c8fe06057") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8395), new Guid("99593bcd-28a4-445e-8752-dd2a44d52075") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8415), new Guid("bb316864-ce4b-47a1-b82a-7e7bfc7ae536") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8431), new Guid("43102786-551e-460f-b123-5daca8a246d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8443), new Guid("a68a1fd1-83fb-4453-a375-31def282e99b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8455), new Guid("a212d0ce-9026-484b-bf00-9898f157cd74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8467), new Guid("3f052d62-04d0-406c-9de3-408737227ccb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8480), new Guid("1e67388c-da9e-4086-81b9-6bdb510840a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8492), new Guid("6a6d7b9c-ae2f-48b6-8fda-42d0eea513d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8503), new Guid("4e301ee2-bc84-48e6-9013-56676c4c88e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8514), new Guid("004b608f-53b0-4e89-bb39-81c5427cccd9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8530), new Guid("9fb2ca62-4fbe-427c-8800-7be7745313a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8541), new Guid("510d0f7a-d0d4-4909-add9-897df03782a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8564), new Guid("7285dfbc-7508-440f-9cb6-b6de6c77eb82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8584), new Guid("00634480-608b-497b-87fb-cec0ffede83a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8596), new Guid("6c641d0e-e3d8-45a3-b3b1-f313b645d5f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8607), new Guid("798896a0-df84-460f-b4d5-3393b4d6332c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8618), new Guid("02865df5-ea7e-4ac8-9656-57de799d4070") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8629), new Guid("cae9dc15-e5a9-4c32-ae78-322531fca384") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8644), new Guid("bbce5c9f-2f41-446e-a508-900687d27e50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8657), new Guid("18de218f-bbbc-4a40-a8cf-c54a60258241") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8668), new Guid("b3fcd7bb-1f8b-4bc2-afc5-cd90cca3ea34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8680), new Guid("c8ca13fb-8264-4f27-b058-9da96542a74b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8692), new Guid("0f709b62-dced-4308-89e2-a5cb5dbe86ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8704), new Guid("8faa25fc-d4d5-448e-aaa9-c12f0df691bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8716), new Guid("a3e32489-8879-4ff9-a81f-55c36eef1744") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8727), new Guid("1c4873f8-3575-4f9f-8489-4f7fb9262ba4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7580), new Guid("6e610023-ae39-4432-a495-12ce1ead8497") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7591), new Guid("823ab6a9-0049-4ea9-9a4f-ace012812805") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7612), new Guid("57ecbd88-a8bb-4188-a02c-eb58e88a329c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7673), new Guid("a12bcb41-14be-420d-b011-b5a1f3c5483f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7716), new Guid("545b5fb5-26e8-4658-8541-93661a312117") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7726), new Guid("bd0ef7ad-46c4-4d9e-a0b9-75c56be879d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7734), new Guid("19ee07f4-2276-4b69-b8be-569243c3fcbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7741), new Guid("7fa4369a-cfea-47bb-b22a-ccaa9f122810") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7749), new Guid("64142f94-2ab6-4ad1-b6ba-0ca7c522e0cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7757), new Guid("b99a2ee4-4942-4815-b762-df9279ecb5f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7888), new Guid("248d1cb0-b7bc-4075-8a94-7b491eb70164") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7899), new Guid("ee4af325-d8c0-4f79-aa40-a26d8ca7f053") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7906), new Guid("9650abc6-793a-42db-a98d-71ccaee7b4cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7914), new Guid("9c785294-727a-42a0-8e50-b221d3de42fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7922), new Guid("c664c313-8535-4706-bd80-bc4049a262a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7930), new Guid("f9cf2586-88f5-4366-817a-0338aeb924f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7938), new Guid("5e973b3e-1c2f-446e-9e18-a771ec7ffea0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7947), new Guid("9f906f72-a111-4154-aa4e-5afc0b491269") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7958), new Guid("cd24dfdf-31ec-44bd-b9fd-f411914c3b51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(7966), new Guid("3e4a62df-fdd6-4d53-911c-8ff680483921") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(6551), new Guid("7d2fb5f2-4f50-4cac-b0fe-46d399973872") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(6701), new Guid("e26f79ff-c401-4d36-842d-a4707ca59064") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8009), new Guid("cd253766-5d5f-480d-8277-49de67785a4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8019), new Guid("46982625-8a13-4f91-9d35-974caf0fe316") });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserArea",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8801), false, 1L, new Guid("490e0f18-0594-4190-b35a-1bc351f3958b"), 1L, null, "تهران-محمد شریفی", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 4, 6, 16, 22, 4, 579, DateTimeKind.Local).AddTicks(8824), false, 2L, new Guid("49aa7bee-d74c-43c3-b1cd-fee5101e0857"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1338), new Guid("54a78092-9fe5-40c4-92e6-1bc9ecb664ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1385), new Guid("2581916a-12cb-4ebc-8a0b-fa82703592cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1395), new Guid("2e489483-fff7-4603-bdb3-344c0b7c7d65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2594), new Guid("d97b3388-7ecc-4991-aa76-5bb30fa2e263") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2627), new Guid("4554626b-f978-4b73-8e16-3b362fe4d8fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2638), new Guid("cfe1562c-3db0-4a8c-9ba9-a3b009d42f20") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2676), new Guid("52e9bf5b-effc-42bf-8c09-02de244e04a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2693), new Guid("0214fea6-251d-4f96-8536-5ea70d59874d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2704), new Guid("4d80248c-8365-451a-b187-ab570dc85091") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2714), new Guid("94644e52-4148-46fc-a10d-e2731227aef9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2725), new Guid("c9810d02-bc97-4f84-a347-1c79f2348c14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2735), new Guid("ec3a0a68-c3ca-431f-9811-13d5531a9a34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2746), new Guid("95cbfc98-39d5-4a07-8382-c387ad3b804f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2756), new Guid("e8b25718-3099-4f14-b1ae-fe87de985453") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2787), new Guid("a5ec0837-e650-4be7-8872-7bc8758353be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2801), new Guid("cb87e9d8-c256-45d1-97d4-25c6463a95e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2811), new Guid("46702992-b2cc-44d9-9b7a-18ff692fbb84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2821), new Guid("4c1d986f-268a-4656-bb7f-fa0b1944deef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2832), new Guid("b800133f-3f1a-4d80-bbf9-4a97beca08cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2842), new Guid("991fb45b-625c-47d5-bf95-1eb438bfcaf6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2851), new Guid("a322d318-fe02-481b-b2f7-dfc756a9fc9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2861), new Guid("79984a1d-55be-4869-9802-98b8ba3f6a5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2871), new Guid("70b1be8c-f96e-4c6a-911b-ed0a438514b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2885), new Guid("6e48577e-8b13-41f4-8b5e-510881d2da8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2895), new Guid("f78369f5-fecc-44a6-88fb-fe280e0673a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2905), new Guid("527f8aa2-0754-4dae-98ba-b661151dbba3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2915), new Guid("8804d213-65a6-4f5f-815b-7a694cacbbe1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2925), new Guid("5c96f6d4-5bd2-46d8-b468-5e803394225a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2936), new Guid("2757dc91-5335-4b8b-9c94-a03fa9e990ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2946), new Guid("bf7e81e8-600c-4aa4-8bd2-e529480c6f23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2968), new Guid("9354f3cf-92bb-49e4-a5c4-dc212aa1567c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1441), new Guid("59281723-2a5a-47e5-b49f-b989dc8a0579") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1451), new Guid("025b9012-7cb9-41c6-b662-bf9c7be9b44c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1477), new Guid("dd5b9abd-1d07-4c57-aaf2-023b43ad48e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1824), new Guid("61f43420-d9b6-4f8b-8c5c-a660486da14c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1934), new Guid("f4dec16e-ae1a-493a-a08b-d4e7bbab6447") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1943), new Guid("cffc3aec-482f-4e0d-92d5-71c4e77358d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1951), new Guid("fe954ad5-02c1-412a-b574-6c203ebb077f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1960), new Guid("7d1be286-611e-486c-bb0a-d3608c898efe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1970), new Guid("f98dafa1-30b8-481b-a148-df1abe9f02ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1977), new Guid("b3b4aba3-5b83-4690-938b-9710516b86e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2119), new Guid("e03e6b2d-174d-44d9-a457-7c15f0dee840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2161), new Guid("41412c6b-7574-4980-9e91-8a4641e206af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2193), new Guid("f97c8a22-e014-4887-809f-6f5860377793") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2204), new Guid("0dc9660f-65fa-461d-8fc4-2ebcd12a0e8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2216), new Guid("94ddb4ea-3fa7-4703-87eb-e900b0d32e8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2227), new Guid("5831c612-045a-4920-a654-7a9c8a861da4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2239), new Guid("6b72325b-5768-4f5f-89d6-427c43a2582d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2250), new Guid("563d65e9-f60e-42e8-beb2-a9fa2f529d64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2267), new Guid("3da1f8b0-1b90-419a-81ae-35bf9421e2d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2330), new Guid("c66eebea-7778-4f29-b41a-33fab4181835") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(621), new Guid("d80d816b-9c6f-44bf-9c9f-c8813edd37b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(793), new Guid("75d8dcbe-4713-43ec-843c-73685ca53d3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2494), new Guid("820f4449-8ff8-4bed-8824-c10c1438ce99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2529), new Guid("db573c5d-39c9-40e7-8e20-76327e3f1b9d") });
        }
    }
}
