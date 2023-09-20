using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CleanUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8499), new Guid("fd4f6d99-c06c-456a-9e5c-c97a8f83107b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8503), new Guid("ce5c717c-2fef-4022-af95-f5af50f7d904"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8506), new Guid("b27a4346-0a50-480a-a472-a415eb9b640b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8508), new Guid("21c0c7b0-7167-427f-ab43-9c263dcc6a4f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8955), new Guid("f0a2e665-c86e-40b7-a1d0-507662406ad8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8998), new Guid("e63110f0-5936-4644-9a6c-1edf4dd4bd89"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9003), new Guid("a4da7f06-9401-4b98-9a26-91f8948337e3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9009), new Guid("5296e059-74cb-47f1-9a67-c1205f9fb0e7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9014), new Guid("39bf9a54-e0bc-4b49-ab6d-52615545481b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9019), new Guid("1b666849-b6dd-4d61-8d72-8d0d533b964b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9027), new Guid("e5365ba8-4351-4c2f-b285-63d85a85b644"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9032), new Guid("f2a454ec-7f5e-4701-a020-2a2ec12138c9"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9037), new Guid("d109d5f6-9142-4572-920a-dbc13f26df90"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9042), new Guid("1caf5916-4ddc-4f12-aad9-652d4e4063b6"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9047), new Guid("be45296a-6b79-441c-9891-17afbdfa5cde"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9084), new Guid("ccbded1e-2efe-42ea-a9f3-7469146b696d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9089), new Guid("76f9b0bb-739e-498d-a34d-f1cb34380bac"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9094), new Guid("68971932-d612-4ecb-9daf-86f7e0184628"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9102), new Guid("97f55404-f0a3-498c-b7dc-fa02c651fe84"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9107), new Guid("8fe82ec1-bb57-4f35-9a02-4d1f6de2a8c4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9112), new Guid("019a7cf2-88a4-4c4a-85f7-f1ffc3a7c515"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9117), new Guid("19161cf6-a10c-49e5-aeb0-871cbd79003f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9122), new Guid("e2f6dbd9-2bd8-4856-953e-6bf056ebeeed"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9127), new Guid("b7b9236b-7f26-4af0-ac72-23154f94df7c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8577), new Guid("ff517ed5-6242-4c50-b695-11552eb2d3f3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8664), new Guid("86612d3c-4564-4ae2-aac2-2138409baa67"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8667), new Guid("7e429c31-a0f2-402a-b938-49754bd41e57"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8688), new Guid("e1441603-80e3-499d-8e48-9517d3d85d20"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8691), new Guid("d925c208-b21a-4d05-bb56-5c0ec145a7c7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8696), new Guid("eb757e8a-89a0-4c0d-b9b8-41373d67f6ae"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8699), new Guid("15e4c51b-a3cb-487c-8b7e-1e57e54140eb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8701), new Guid("2ee5e330-dd3b-43c0-bfb1-e212ffbf9596"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8703), new Guid("a0a6b855-0514-4c16-a338-0139f5061938"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8917), new Guid("397a4a87-dca4-464c-b1db-ef418af864d7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8920), new Guid("339d04da-599c-49dd-92f0-1357a40fe8d2"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8923), new Guid("b907ae10-eb91-4d1f-9328-9993e2a1479c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8925), new Guid("c7b54875-feb8-4dc6-bda3-7e2a978e00e0"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8927), new Guid("0a2c9f9b-2cd8-4a74-958e-567a00374297"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8932), new Guid("1ef59a1d-8a89-4a8a-aae4-688cca77aa02"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8934), new Guid("a3f33b3a-42f2-434f-b9d4-ff9cec11301e"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8237), new Guid("a4bd5608-1c33-4fd3-8ccb-0a614d69df89"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8282), new Guid("129fd459-d338-4e0e-9b8a-15d515514c37"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8285), new Guid("04561cc5-e06b-4b8c-814b-d65e51116080"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8840), new Guid("47b02712-02b8-4c1a-8504-c2a1482d2a9b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8844), new Guid("b41f8897-4979-4d48-9288-aa18f295a260"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8846), new Guid("ff40608a-59b3-4fc2-9f8c-318df0c462bb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8849), new Guid("a7a4f3f4-fe30-43a2-9b13-84de2acadaaf"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8853), new Guid("c913d8f9-02d8-4221-af58-5126eb5d10e8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8888), new Guid("8613bb97-6bf3-43b6-9034-20477e8f46e4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8892), new Guid("c78569b8-c59b-466a-9815-1a1e8eab607b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8761), new Guid("12cad801-b12e-4fb4-979d-8aacad451a38"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8764), new Guid("41ff8e6a-6855-4ff4-8272-12bdbce1d95b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8767), new Guid("fe50c3aa-562d-4893-be37-c149d1a225e5"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8770), new Guid("1a588a30-820a-4d48-88e9-c894b35d79c5"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8772), new Guid("1ccdaed1-6d11-41e5-8390-cc0e7d850972"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8775), new Guid("aba6a636-fa7c-4fee-9e19-f6ca0cc37ade"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8777), new Guid("37360c2e-ba4c-4f39-8440-0fe033edfb83"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8780), new Guid("05e06e02-01a5-4d78-9751-49fb8dee1efe"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8785), new Guid("b3a92a8f-b7b6-4c5a-8cbf-771819d62d90"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8787), new Guid("4ac51a36-f33b-46d7-a5ee-03cf5ea5092e"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8735), new Guid("29852415-805b-409f-ada2-061fff782592"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8737), new Guid("ff2ae788-4a8f-480b-8541-77bf8a92022f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8739), new Guid("5c8ec177-c134-46ec-bcb8-96f050b05efd"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8742), new Guid("9a4639ab-802a-4428-acb7-5935bee9fda4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8814), new Guid("276d3920-3bd9-4bcf-aeaf-a7770ed10a73"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8817), new Guid("5b47f230-9b88-4939-8cab-62525c05085f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8534), new Guid("47f0134b-9d2c-4f1d-8d1c-6323dcd8e455"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8549), new Guid("1502b21a-6fa3-4746-b446-7cd176609dbd"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8551), new Guid("770a0c38-ee81-4cc9-bbb0-cb4028e13853"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8554), new Guid("7a359e43-5177-496e-863d-82750a499e10"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9197), new Guid("b8445b5d-82be-4a97-b082-36eb05ea3c8b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9204), new Guid("ef5aec23-6a00-45e7-8279-a80c6d7a5fc8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9207), new Guid("04cbf140-7b51-4e3a-867b-3be80c068faa"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9210), new Guid("113785aa-aeec-42c0-a6db-a77595b2402f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9212), new Guid("2e8e36ba-5767-440a-8e80-736153af2880"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9265), new Guid("91260251-fe5b-4e52-9595-16ba80915981"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9270), new Guid("3db0826c-a013-4245-8e3e-a3e45beff6be"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9275), new Guid("52ee10ee-d289-4ac1-b93a-01f98fb4ff9a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9279), new Guid("e2026d3c-2f3d-4193-9e3c-611d5d8407fc"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9166), new Guid("7d0f3a0d-6ccc-446d-8793-50b8563c48b7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9169), new Guid("156d85b2-a63b-4c49-a653-083796ca3d69"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9174), new Guid("df4d6a97-2b30-46cf-b1cb-75d2032de0cb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9380), new Guid("8cf725c7-13c3-4f5e-aef2-d01eb6431119"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9383), new Guid("cbc06e89-e5ad-47e2-b7cb-2c7f6b404084"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9386), new Guid("c0173932-f9de-4e5a-8ef0-a3d5a0b5cc41"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9391), new Guid("151d4d1d-b184-4406-a1b6-6e2566398ff3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9393), new Guid("ff012055-bc82-4d98-b59f-4b11604112ed"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9339), new Guid("d4bf7166-862b-4d32-9769-812a7e228e1f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9342), new Guid("8f28bf8b-14f1-4fad-8036-65ded51c78a6"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9347), new Guid("c2544734-6e9a-4e76-a9e3-b5d55a7a7e87"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9350), new Guid("650d2468-9427-4949-8cc3-079daeb43ee7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9353), new Guid("db8c3519-5db2-4622-bcef-6b86402ff47a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9356), new Guid("23731061-0aeb-409f-8f43-8a167f455c25"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9358), new Guid("53d0efcd-8ace-49d5-bb28-606f2f7d1d6d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9310), new Guid("9dd6b446-8fd3-4b9e-afb2-26d712422cf7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9314), new Guid("1a37ced0-2263-4967-b876-1147d16ecf3d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9317), new Guid("0d7421c6-c3d5-4270-bfcc-cd39774cf9f8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9319), new Guid("ccf15fb5-5adb-4efe-ba4d-e8a7e4f10c8a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9415), new Guid("ca59bb50-5c3a-42e0-b0fc-8fea07ff6bf9"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9418), new Guid("2bb1aef3-22d6-4f42-8872-7ceb964b115c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9419) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6930), new Guid("a44ac962-6ffc-493b-abed-29f10072e100"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6936), new Guid("0caca726-3596-4377-a673-402ed70de9e5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6938), new Guid("f62f752b-4b0b-46e7-9fac-8bbbd8a19d27"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6954), new Guid("bb626d0b-c1ea-455b-8840-2e779ae497c8"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7385), new Guid("fc9e708f-e585-48eb-8fbe-059d0714ad43"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7434), new Guid("fc056bac-838f-4853-865f-cc293155123f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7441), new Guid("3a73835d-db16-44cf-89a6-56e50476c64f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7448), new Guid("19e9ebd4-d505-464c-928c-1a9d208801e4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7454), new Guid("387f38b5-8722-4d9e-afd3-570893b4a637"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7459), new Guid("b8709abf-bea9-488d-83e8-d4f110b6cc9e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7465), new Guid("c995dee3-42c1-4242-94ec-e6f7ec76bde3"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7469), new Guid("3b7e6e8e-154d-450d-b325-c21163786055"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7474), new Guid("a0044f16-2f0f-4289-bd98-bad28452e134"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7479), new Guid("a9576818-fa60-4b4f-b9b6-9a349b4d4dc2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7484), new Guid("4fdfd62a-5dd8-4f19-b387-5e1551e655de"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7491), new Guid("9bcb64e6-252e-4e98-816c-68d9fafa470f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7497), new Guid("83d6aed8-b0ac-4ca7-b5ea-fa12bdca8124"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7574), new Guid("b840416e-1a45-4653-bac4-2eda7677aa5c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7581), new Guid("4b96b784-6cba-464e-98e3-e24b9f1a762c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7586), new Guid("4798313e-b334-490e-82fe-7a7efd253704"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7591), new Guid("25e568ce-7c0b-4ab5-b900-25661f08decf"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7595), new Guid("ac05beaa-d77a-4cae-94b5-de25c9b0f11f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7600), new Guid("c31a6aba-060c-4461-b585-3edc3697c1f4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7608), new Guid("9626d502-88b9-4757-84eb-5559eca2b7f2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7025), new Guid("edfe824b-e318-4221-9264-72020903aab4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7028), new Guid("1187b390-7886-44e7-bc61-5fd9bfc48913"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7033), new Guid("e95d44eb-d4f4-4627-8bac-7cf6218d6b04"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7052), new Guid("1bde7333-1a8d-44ac-b23d-c9263f118638"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7055), new Guid("d48f0153-f375-4149-a710-e5cab5485dbc"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7057), new Guid("60227466-ba05-4a5e-bf73-fa37c360bbdf"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7100), new Guid("bd081cfb-3bcf-4186-bb9d-4a495e7c8986"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7103), new Guid("cb85302e-613a-404e-847e-b4f56999c6ad"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7105), new Guid("38a434da-b662-441b-ad8e-5b5939f86d7d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7342), new Guid("c4adfec2-ec27-4d0d-b4e8-16f7f27f9c3e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7346), new Guid("f63b5de2-8890-4e03-a2d2-2c51ba8c35cd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7351), new Guid("462fb31b-4e93-4295-96b5-d5c5bb353101"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7354), new Guid("f865a1fa-a21b-4405-a700-d30b2cae81fd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7356), new Guid("d7984fe8-86da-484f-8a88-df1c058c2906"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7360), new Guid("0963594d-1eee-4e38-9f64-40decda3802e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7362), new Guid("8ff0bc54-ef45-47f2-8c8c-c79926ead19d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6623), new Guid("530eb64d-3d52-4be0-8290-390f1ba3f1d7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6682), new Guid("7bc70877-c598-4e18-a085-f8ed1d8a3f89"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6685), new Guid("544e499b-ef1e-4785-9e27-9b56e4f56feb"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7264), new Guid("7e72888b-ab01-4e2f-b6b2-b276aec48c96"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7270), new Guid("9988dbe9-7dec-4643-b08b-4e54fc3508be"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7273), new Guid("7bcef196-1914-4c34-9dc7-eeeeccd4f494"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7275), new Guid("905f04e3-921a-43e5-a2bd-bdf74530c437"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7278), new Guid("66ddea9f-33ca-4aed-a3b3-fc2142e15066"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7281), new Guid("f0dc8695-3df7-4667-96af-37c8524a3eda"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7283), new Guid("245c8947-8272-4b66-97b5-85538fc2ec56"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7177), new Guid("38c7a466-79a1-47d3-9a27-6d1bacb96cbc"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7182), new Guid("8868a09f-144f-4465-9999-e21d98a59d42"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7185), new Guid("badfda6c-1f34-402f-b554-09e1be050b9d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7187), new Guid("687d28d5-47fe-496e-9b2c-8b6373d7a209"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7190), new Guid("6dfb279d-fc32-4bf4-98cd-c0a83f9dd111"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7195), new Guid("cb30853b-1a2f-469b-ae5f-2cdcfe1882ec"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7197), new Guid("6cdceac1-6a0e-4340-a6cd-f34657f15669"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7200), new Guid("4fb380fa-014c-41ab-a137-196562feeece"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7203), new Guid("6cbeb282-0e3a-40d8-aff6-e5716c13d6e2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7205), new Guid("9b506ceb-97d1-424b-8dba-1d16a2f64cd7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7139), new Guid("e531e6c6-439b-4381-bf02-dc879b64708b"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7145), new Guid("bf74b33e-fadb-4aed-b3bf-2d5d84ae0dce"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7147), new Guid("f06eb347-037c-4955-be8e-6de42df41d8d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7149), new Guid("7d4bd0bd-57b9-42d9-a785-840bd4cb053f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7234), new Guid("4daafe0f-f574-4fd1-81f1-a3052082c4ba"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7237), new Guid("ffd1394e-ab8d-4721-92cb-ce11263ec2ef"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6985), new Guid("3ad8e1a4-e509-4139-a13e-6a9b90052cff"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6988), new Guid("5f857606-319d-41be-9347-22720c3e8d6c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6990), new Guid("1d78a1bd-a10b-4045-9245-c51f08f8f1b9"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6993), new Guid("13621085-cdb6-4297-93c6-26ea2000e80d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "LastUpdatedRecord", "Name", "SortIndex" },
                values: new object[] { 5L, new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6995), null, "ابطال شده", false, null, new Guid("3cf471e6-660a-40dd-8e29-9cefddcc434e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6996), "Aborted", 5L });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7676), new Guid("e94c15a4-e6d3-498a-9ae4-e64f29b91e24"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7682), new Guid("76dcb08b-c1eb-4b9a-ab74-2cad47ce71d3"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7685), new Guid("39b49312-dd7b-4eff-824f-9bc51937fbb5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7688), new Guid("32ba2466-454c-436f-8eb4-899f5dfb54b2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7694), new Guid("b06ef74f-b802-421c-ac96-5e35b8991449"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7715), new Guid("58679a07-de1e-43a9-afed-1e6cdecc90a4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7719), new Guid("af0bf40d-b7d2-4e20-87ef-b8554bc39f7f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7722), new Guid("c5b2e46e-5026-4820-8e2b-7b298011fcf4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7724), new Guid("6de92cb9-77b9-44f7-be2a-45ed1e03490a"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7647), new Guid("f97e8397-c754-46c1-a185-146f1213b0ec"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7650), new Guid("73474b0f-1cfb-406a-97c9-58e20362dfcd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7653), new Guid("f14f7556-d0f7-4bb2-b599-4c90f8340af7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7864), new Guid("16b443cf-6936-4be8-9d67-87cbd632b0c6"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7868), new Guid("08f85e51-d0fb-4148-a00d-6d6317897bf5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7870), new Guid("8b608481-e7ea-4e25-84f1-2eb100f90a73"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7873), new Guid("3793f80b-0ef7-4e59-b025-5c9afb33f537"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7875), new Guid("5df878d5-90a8-4073-bcc2-f3b6ac408860"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7823), new Guid("636a15f8-c811-495d-a6e3-89ef281f04a1"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7826), new Guid("c57da287-9001-424e-bfab-861d544a1598"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7829), new Guid("6639c240-bf70-4b8b-8a68-b0f88873fb2f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7831), new Guid("a9e62a6b-50b5-4e3b-bb1b-afb1f2aa5b07"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7834), new Guid("bdedb85f-1d93-487c-be92-2618ed9153b7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7837), new Guid("c835a932-2cff-4dcd-97d7-39d42b06409c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7839), new Guid("8c6e411c-2ef3-43d6-9deb-50e0c2d15d9b"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7787), new Guid("0adbbffb-97c2-464c-9a95-7c83404d069e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7792), new Guid("76719ceb-3da9-4df7-9a6c-c105c45535b0"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7795), new Guid("313b7bdc-e673-427f-873d-5f7ab2ae1eeb"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7800), new Guid("c02c3554-d093-43f6-9d77-af1c32155693"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7898), new Guid("0d2f6c91-f48c-48fd-af0a-b61451662ff5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7901), new Guid("4a12311a-9b1d-4b3f-a72e-268d80274ee1"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7901) });
        }
    }
}
