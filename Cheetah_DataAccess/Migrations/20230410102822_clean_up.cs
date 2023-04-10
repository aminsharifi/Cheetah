using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class clean_up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6086), new Guid("d38c326d-f6aa-4cf0-90f2-3ba112cbafbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6237), new Guid("74b582e7-2ad8-41fb-bd1a-1d83a986d070") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6245), new Guid("820eebdd-58e2-45a4-91ad-2a667c2f41e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6279), new Guid("b4a5576e-80b3-478f-ac3d-a6595108edad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7890), new Guid("e1b0caa7-4f6d-425a-8cdf-32c0a85ea5e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8158), new Guid("053f0ca5-8a7b-4320-82a3-46acc315ea2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8178), new Guid("7bc8a75c-573e-4977-b6ff-35231253b3d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8238), new Guid("a92de4d6-7105-4ab4-b946-54e5b44deea5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8255), new Guid("59f927d3-e8f9-4df4-a3f0-e199d3f6ab65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8273), new Guid("d1837c09-9bcb-4c9a-9d39-bc82db35ac0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8285), new Guid("612f60a4-fa82-4531-bb2a-d842e13c00f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8299), new Guid("ce74b10a-44ce-45a2-a220-934156b551fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8311), new Guid("e32fecf6-ea63-4605-84a5-3b4ccfe31c7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8323), new Guid("4407faae-f0be-4b7f-b58e-728d2497d8ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8337), new Guid("06300986-588c-431e-90b6-ad3e8f130500") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8350), new Guid("806251de-fa22-4592-8c2d-ab54b3c8bdcb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8362), new Guid("9f7b8e38-fb97-43e4-8588-78f4c702e447") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8377), new Guid("04544191-71f7-4c63-988d-1317bf5fcb66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8390), new Guid("261fd432-3630-42e0-9087-511512ee2925") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8415), new Guid("33e59f4a-9f69-4ad2-9cdb-01d8769fb45d"), "اختصاص نقش‌ها(Facts)", "F_Endorsement" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8428), new Guid("5765f5f0-b834-43b6-967a-dcf3586968cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8439), new Guid("645c3c10-d571-48bf-a0d5-45b1060ba62b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8454), new Guid("227fcea5-c41d-4c0e-a7ac-e1ba96b7d6d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8551), new Guid("91be60fc-161c-49db-b00a-45df7079cc3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8564), new Guid("5489b4ae-dcc3-46d0-a410-2ae41a360a7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8580), new Guid("e7e8b891-465f-45b7-8037-723acce3f478") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8592), new Guid("747ef774-0276-44fd-955d-4bdabc91c593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8605), new Guid("17a06c29-653f-4a0f-b33f-4b13db0a71ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7045), new Guid("ac2649fa-02fd-4c56-bd2a-d3a13e88e51e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7056), new Guid("653d09e7-8f38-4ef8-bdb2-034cd0802395") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7169), new Guid("44768d6e-9489-4bc2-b269-af996ecce65b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7178), new Guid("d3872de7-2a18-4cc0-97f4-61ebb39df732") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6982), new Guid("ae07d785-0ed2-42ce-8879-cc5cb4add084") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6992), new Guid("9574fdb7-b132-4d48-9964-1c3f62fdc2a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7001), new Guid("c39b47f3-5898-45dd-be19-4d87065df0e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7275), new Guid("92190e1c-f84a-43f2-8b06-101a3457d6cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7286), new Guid("19620bc7-856a-4fdf-8067-f1e13313d34e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7293), new Guid("ea9be265-a148-45a1-90dc-8e41aa3717fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7302), new Guid("0a66712c-ec2e-458c-853a-fdca336c44bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7309), new Guid("f61019d5-b092-43d5-900a-e50217002d15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7317), new Guid("ac5ac734-1e82-42e6-8576-c2be76eb5364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7414), new Guid("82c72495-240e-43e4-9bb8-1659780c7d8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7424), new Guid("00f47034-a6c7-4af8-b526-5d41bab612b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7433), new Guid("2fa54be8-f37e-489b-b8b2-82ecdf4f3ba6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7446), new Guid("c6681869-5329-43bb-a95a-db6e30727945") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7471), new Guid("70b59178-c49b-42b5-88c9-ab1e0d328850") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7482), new Guid("d0add361-09b3-43bb-a5a1-6c341c85cc9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7491), new Guid("ea0bc1d9-f49f-4247-b78b-304defa504d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7500), new Guid("47131c7f-fd4e-422b-8d87-ca971872e257") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7507), new Guid("f6925604-6dd6-4167-9c74-f797bd14f4df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7515), new Guid("65cb0f61-e6e3-439c-b8ca-2b77556a8ce0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7366), new Guid("7fad5778-49d8-4bdf-8563-94c18f62a153") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7378), new Guid("6662e39b-861c-4b02-ae19-18b7425bfb93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7386), new Guid("061bc64a-c653-4a16-ae2f-a3af089e6e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7804), new Guid("c26a475e-5394-41a6-baaf-5405b192bfbf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7814), new Guid("7ee485a1-296b-4643-9fbf-8a50298470f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7821), new Guid("c5a96960-6f0d-4f59-927c-410244dcf0f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7830), new Guid("d5a18943-032c-4235-9d2b-2dbd08031d6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7842), new Guid("a77d74cf-2101-430d-83cd-48b843c2518a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7851), new Guid("76a33fdd-3064-4cda-8230-f60ebab1ecc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7860), new Guid("b91fa67f-78e9-40fe-ba28-b4d72748601f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6895), new Guid("792e9790-68da-4e2a-bd9f-e0a617a9d946") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6934), new Guid("acc12f18-3d60-47ca-9886-e61ee35a67c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6943), new Guid("f9da13b9-e05d-4eb7-93b6-63900cfabe49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6789), new Guid("0eb98eea-39e7-470b-ac01-2fea04c04a23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6825), new Guid("3198e9bf-9256-4514-be47-610988c0a427") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6833), new Guid("c69f3d6b-5caa-451c-9528-ad130a04ae13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7719), new Guid("2ed3213a-790f-4aef-9c83-bbfb058cf7ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7736), new Guid("953d4578-9848-4110-909f-2b1e190f6410") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7744), new Guid("6f66af5c-ed0d-48a8-8e72-87a05791eecb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7753), new Guid("9550ddf4-cb62-4534-b766-fc0273665fb5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7761), new Guid("bf30681b-ac0f-4bdc-bfc8-31d0af088d5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7622), new Guid("46435ae5-7234-45a6-a868-93f366a8db8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7631), new Guid("c4ca451f-9679-4fc0-abf0-f24b312f1486") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8735), new Guid("47f91f94-e8dd-42e8-99a4-3cbbf528f0d2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8745), new Guid("de416578-6be6-4c66-97c3-cd432f5e072b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8753), new Guid("6e96e42b-9e87-436f-93c6-464da86ddfdb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8765), new Guid("eece7b48-ece3-4ed3-8feb-d7038ffaf611") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8773), new Guid("e5fd1237-6bdb-4af0-ba89-66b3290cd083") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8782), new Guid("ee851d18-ecb6-4b08-8cbc-be604476aa44") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8789), new Guid("071d988b-5b01-4c88-bc33-1efbf820c919") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8823), new Guid("5396da45-3eed-47d4-b04d-e579c655ea6d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8832), new Guid("97840008-8b86-4f28-8bd6-beb03a3118d9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8841), new Guid("10ff2dc7-3dfd-4604-a1e3-4ba89308e938") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8848), new Guid("ec57f7c2-e40e-429e-bb4a-874d2a36f139") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8684), new Guid("bc923314-4996-4b9d-af0a-4e0b49edfbfe") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8697), new Guid("708071b0-6d5e-4fae-96f2-1b86462a8fa8") });
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
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9809), new Guid("6da4fd12-b99a-4503-828b-1cf9213c644c") });

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
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 7, 54, 266, DateTimeKind.Local).AddTicks(9866), new Guid("b56331d8-b9e6-4c8f-b84c-ac6dc221c2c3"), "لیست سمت ها(Facts)", "F_EndorsementPosition" });

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
    }
}
