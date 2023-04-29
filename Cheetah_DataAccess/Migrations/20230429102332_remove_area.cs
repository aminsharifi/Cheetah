using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class remove_area : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L);

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
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(7176), new Guid("4088ff71-9ded-44b6-9c06-2b3f088306e9") });

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

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6443), new Guid("5a4acc09-7670-42d8-94af-af65af8408bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6452), new Guid("73815608-0513-4a65-9553-2897deab8c59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 53, 31, 341, DateTimeKind.Local).AddTicks(6458), new Guid("e5595536-91b4-47b8-ac6f-314940849669") });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(2665), new Guid("0f96feec-62b9-49bc-b9b3-52c7e997aeb5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(2786), new Guid("4800c5e2-1a92-43ef-91ba-d97fc209b2ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(2805), new Guid("56454a9e-d26e-41c5-8d31-e709dcc631b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3983), new Guid("2b250c70-eada-48a6-a32b-a295f97d21f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3994), new Guid("8495dc2a-9546-433b-b6ce-c6778b56f3aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4002), new Guid("1fcd3d64-4cb0-4fe1-8a9f-586542e867a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4011), new Guid("ef3269cc-c5ee-4283-b944-ff2ff019599a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4022), new Guid("3bdf4f2c-0f69-418e-8220-cc44e594939b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4031), new Guid("4fed0eea-369d-4129-b199-fc2ac3803f9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4039), new Guid("2bbf4bd1-cf4a-46b8-856c-b6146cebc37c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4047), new Guid("3289d332-3405-4e68-ae30-e2d51feb6dfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4057), new Guid("761613b7-0ac5-4fc5-9c23-aca77deb28d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4066), new Guid("bee00202-2c42-478f-a96c-fb895066ad50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4085), new Guid("6748f122-ea0c-42b4-9262-f12f48f5b5c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4094), new Guid("a373b8fa-4494-45ad-bcbc-bd32d7a05dce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4104), new Guid("3eca0afc-ae58-42fa-85d3-54fea9fad055") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4112), new Guid("829440a0-4ec0-479b-b0fe-2515bce66b71") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4126), new Guid("f766e352-d244-48bb-94dc-2feeb52f47c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4134), new Guid("a20638cd-87c1-4e86-8e25-eb9e9991d137") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4143), new Guid("5bc6ea4f-047b-4f3b-b4d8-1e78656bd9e9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4152), new Guid("fb313883-87d2-4a31-a0d1-919965274a54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4162), new Guid("984cf61e-0e2a-4c0a-b953-fce9f4d23ad7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4170), new Guid("61b2ec71-1de8-4ffe-9744-a73604a44f7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4181), new Guid("71d67756-10d0-4887-879e-6fcf35ba6da6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4189), new Guid("ea004776-7324-4226-9d1c-0ef47214b4a4") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 100L, new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3799), false, new Guid("dbdbd77a-0dcd-46ee-81fa-4af649d081bd"), 100L, null, "واحدها(Dimentions)", null, 100L, "D_Area", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3329), new Guid("fefc88c7-3c27-4bd6-be9d-38cd058902b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3335), new Guid("ac9855dd-a71b-475e-89a8-5be273683e7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3343), new Guid("205fd342-1c05-459d-b303-df1ef37e67e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3366), new Guid("e8b2e5fe-619c-4484-a39f-958b0929978b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3372), new Guid("6144d2ac-32c5-4a7c-ae20-bc551e0df160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3436), new Guid("c26fb78f-a1e6-4939-8e2c-95b2d65b818d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3442), new Guid("66c926fe-7cd5-4e28-852b-237cb5ca138f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3447), new Guid("5c80f30f-e685-45d7-90d5-c2b6f8855d89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3452), new Guid("ecd4ddc9-71b3-4130-b48a-c66cc3db99a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3730), new Guid("87e2fc2c-cfc9-4107-b75b-56e6fd425b12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3736), new Guid("deb54ecf-3c9c-42a2-be75-c9ca89e8efae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3741), new Guid("6b801b2c-1994-45d7-b930-e73adef69f16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3755), new Guid("1dea7085-f3b8-4264-b8cb-7d4cde8c258c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3763), new Guid("67a21aea-2136-49df-84d0-4fb0680e6620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3768), new Guid("5b52addd-17c8-4285-8cb8-b38f37513843") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3773), new Guid("ac59d521-6b0c-4c20-8ffc-a44d4e80b192") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3268), new Guid("4b6b3b6f-a787-4c34-be47-83d1ae839d73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3274), new Guid("1cbb45e4-0c54-421f-83eb-cb73706b227e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3299), new Guid("f6704c21-8078-4a3e-809e-bc23d4ce282e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3304), new Guid("47381ff5-ac05-454b-b1b2-0bd5a189790f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3207), new Guid("f333f8c4-3e13-4a0e-bdf1-c778fb4d89fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3231), new Guid("577ce47e-d834-4f2e-b84c-c846518e5a24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3239), new Guid("08300058-f785-4ebb-916d-61ff6bf32529") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3679), new Guid("195d1edb-051d-4f81-b69f-635afb952205") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3688), new Guid("b9aeaaf3-d929-44b9-8379-db5d8680a7b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3694), new Guid("ba471463-57fa-41ee-a411-378ba280e8ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3699), new Guid("9079ac1e-acae-412f-befb-d107aeb7c5e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3704), new Guid("a4382a70-8800-4a99-b820-0959c1232ba9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3535), new Guid("d4949c37-6908-4b2f-8ba5-b15da4149b2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3552), new Guid("639ed1d4-2bac-4bf0-ac6a-0ce92be8238c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3558), new Guid("c63d59ab-7da2-4f19-9b4d-9cddce2be8f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3563), new Guid("b9034ea0-d39d-48e6-b58a-453885cfdb4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3568), new Guid("37933a5b-44a3-434d-ab51-651e39d10aa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3575), new Guid("ed537349-a20a-417b-9a99-6eec93084fc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3580), new Guid("854df183-091f-45fe-8908-7d14f16c11c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3600), new Guid("c02012a0-e356-4757-90bb-324023c6dd4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3606), new Guid("1e6f6d33-f21f-4f29-bb1e-14be4aafc152") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3611), new Guid("1e6ad91c-4749-419f-85d5-ca5f120b6bdb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3489), new Guid("23f7a1e2-234d-41e1-862d-3d6a200e72bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3499), new Guid("287710e4-cfa6-4bd2-b519-e3ca966f3bb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3504), new Guid("b9e3ebf7-b568-4984-b0c5-c48218eb58d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3510), new Guid("a2fcbeef-0858-4468-9a0d-95d3ec8236dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3643), new Guid("f4c24db6-394e-4831-b1bf-8739dab45d74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(3650), new Guid("676e7563-8bcf-424d-ac6b-0fd9c8dab008") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4271), new Guid("94c5db0c-9627-43c5-9712-9a1078ca0e16") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4286), new Guid("760a6179-8378-4a0e-88d1-4193c5ba3dfa") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4292), new Guid("10335bac-7104-44fc-88ea-8b09481488a6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4298), new Guid("23b61097-adce-435e-b074-a50205c0735d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4306), new Guid("0ff22071-5298-4b84-a260-0f6786dc41c1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4312), new Guid("82cfffb2-22f7-4368-800d-2637dc063427") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4319), new Guid("b08aa8c6-de23-4030-b815-41437529201b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4241), new Guid("071b3ea5-c217-4075-997a-7ab5427783d0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 34, 7, 969, DateTimeKind.Local).AddTicks(4249), new Guid("3afbf670-acbf-47a9-af97-1ee85131e850") });
        }
    }
}
