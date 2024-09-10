using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_CheckValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApproveState",
                schema: "Facts",
                table: "F_Condition",
                newName: "CheckValidation");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9677), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab2d58ff-271d-4e2f-8140-1c9e694b5a90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9840d2a7-307a-463e-ac8a-c3bc2de3f7db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8acd2600-35c6-478f-b2ac-b276ac78bf2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d8c4478-6063-43dc-9b21-b1a4e5aadfa7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7877bcb-2eef-4384-b46b-1846863e791a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d137940-b499-4400-b111-631f2121230e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 158, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7edf4211-87cf-48fe-99d8-6f6e93d3a705") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(5926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b65a7b13-7b46-4574-b0b7-c137181df717") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cb30138-5a0f-47d5-976f-32f74f83c2c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("457ab9b8-2ded-4a6c-a0a0-ecdf4edc0f42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41d89072-bf1c-4a0a-afe3-cab38abbf0a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0eccf1d0-0a71-4208-9042-be8317dccdee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d2eb953-94b5-456c-8986-1dbca9f6925d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fb48a39-59d4-49cc-912d-313075950d03") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92ebf09e-3b06-48b1-8f36-5fe632379d39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba9faa2c-ca6f-4255-98c1-94514ee4ad6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07ace0b8-f6ed-4493-99e9-0f8e8c211b50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43363177-929e-4f42-8994-445fc0771a3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1876914c-651e-4154-9a2b-f3384f8db8a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e9e14f51-6794-4c59-aa7c-83f6d70dcc3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 159, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e7d429c-b883-461e-b662-2b09b5a32221") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9ecd5f9-5cd5-48c6-a766-192d7ea27ffc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7df74515-0cc0-4be0-860a-ab5593032013") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4647ae9-8aac-47fe-a655-d7f316b4ac3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3223ce6d-37f4-405a-9070-ffa7a6d8cdf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4acb27e-aa79-4c84-907a-d90e47ec2054") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(3232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("107d9432-5937-4c2a-a1da-91c9a60028ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 154, DateTimeKind.Unspecified).AddTicks(9669), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b262099-21da-4eab-b3bd-4142e2e08b04") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b030ecc5-6e6c-4ae5-b3d2-655c6130fab9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc21b6aa-e839-4d36-a1da-7f5a821a4e5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 3, 30, 0, 0)), new Guid("895bc44c-9926-4d62-b1dc-24d369ad73ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8237), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d4f16a4-48d3-40ab-9462-f39b126d42b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("947a3984-b7e8-4b99-a267-279c73ae11a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c06985db-7ea4-4f62-8c23-ff1d0760fcd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(8253), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02e29e6a-a79f-4dbf-9b61-4f3570f9ed31") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64df5ebe-b6c5-44c5-94c2-37a0d5ea993b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cc87d88-7289-4d6f-9e48-a8c7849a9d01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3fbd8a4c-cadd-455c-90b0-19987799de52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a602ac3c-61f0-4610-baa3-fa119d80904e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b12bb1ac-7ae5-46f8-a8a7-2d610cee6158") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 156, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("834c978b-c5e8-4898-b48d-d0a784ecad64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 126, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 3, 30, 0, 0)), new Guid("567d73f6-f917-427c-a3b5-5cf8e201eae6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 154, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 3, 30, 0, 0)), new Guid("032bfdfa-932f-423f-8355-b7af66c30984") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 160, DateTimeKind.Unspecified).AddTicks(1443), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b5aff5e-8616-46dd-bd0e-eefd6ca0a86f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 160, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41e60492-dc98-4137-9547-a2d6e21afe34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 160, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae651a75-16e8-4465-b5b5-991e5cf225ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 160, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f35e9d3a-b26f-4b38-ae01-d7595b5eb3e8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81c1ec56-6828-4efb-8bc5-a16f24dad139") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3273cc3-353a-4cd1-8aef-3e0f7981b998") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56362279-53fc-4f94-8b01-16be323def6c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 157, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4297e8c3-3ef0-4eef-95bd-d132a2f32a41") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0141896-4b40-4748-86b2-849edced1350") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(3988), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6dc807d2-6806-474a-a811-3102542fe3c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("964d5ffd-69c6-4a7d-9390-a306bf9af4a7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df2fe686-d84c-4996-9184-746e3d2c4284") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 155, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cb550cd-e59d-4cff-baed-63b56bf4ecff") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 10, 11, 9, 7, 154, DateTimeKind.Unspecified).AddTicks(8209), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ec16228-5295-4043-86ce-1bec1cee3cfc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CheckValidation",
                schema: "Facts",
                table: "F_Condition",
                newName: "ApproveState");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18d6d824-fc4b-42e2-a430-3969aad0cd28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7349e284-f00e-4b3b-a0dc-0a3b0ab51d6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfdb1dc9-a97c-470a-a4c2-b526cfbb4a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 3, 30, 0, 0)), new Guid("102256a3-bb5b-4d58-a8e3-25f527cf289b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f93df360-99ff-4c04-88b6-8f6f19fdca4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0f20c24-49d9-400d-b121-5e0e54fc2543") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(8724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d8ca6b30-039c-4062-b857-3febf8d9d851") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 3, 30, 0, 0)), new Guid("895ee7f7-a8cf-450c-a7ec-af3aec4c29b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0f393d9b-a5ae-439a-8591-87094069800b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8adf873f-bd93-4295-8670-650f2fa981fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8722), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c098ef67-81b2-4462-a70b-b9966e2d5b78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bd36799-4fa2-4ad8-8411-764aa3efb89e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c916ab0e-9a7b-4d0b-a7c6-1832c2d40812") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24722ef3-92ea-445e-93a6-8adcbb51c3ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ea43a25-f5e1-4524-970e-36e1b7001e7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05d4d1dd-53a7-4f5c-b4d6-b171ef242f30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a56b71cb-0d50-434a-8641-c6f3b1ed5533") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8073d40a-3ff4-43bb-92f9-30d451c19a9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7f94655-f6a1-4431-a446-dedc142e766a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cd6f5db-da21-4892-aae0-7c501653e043") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(9359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f87bc250-5c6e-42f8-9ec2-631383e4fd0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, 3, 30, 0, 0)), new Guid("189dc905-fa7f-40d8-9707-11f160cd93f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bfac27f3-872d-4bb8-9e07-91bffa5199fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(84), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64bca20b-b323-46c3-8faf-995aaac32794") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(87), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd606144-9255-4489-924a-4d06d87b1ee3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 3, 30, 0, 0)), new Guid("696dfb5a-948a-499b-bcc5-c4a126acc802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(92), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80f385bc-c5db-4f48-b166-6fc4d88164da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1c609ba-9b0e-4aca-a990-999407f39426") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3ffa6ab-cd61-46db-bd8c-ebfe17ff664b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d01face-8a9d-4037-8239-5277d8968155") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4758189-5a7a-4e72-98bd-5250c83e3eaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3441dd7a-ebb6-4c23-984d-4b2880650f87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7b3a387-deb6-4c7b-98a2-f5cc49e89b6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90608828-f109-40f9-9e3b-7e810604913f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6dd79234-1a3b-4846-8fb3-e44c0fd38733") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4115f68-096b-40d5-97d8-ecd802d2ba90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7a7b05c-9aed-489e-befc-dc36e48fe8a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7cb07e6f-b488-4576-9e7d-e8de714eed06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b398e53a-74e2-43e2-bcfb-0dc416d1e267") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 3, 30, 0, 0)), new Guid("528ad336-2e18-4ae3-a5ef-c146dbe41d2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef847b77-4f38-4a4b-9560-4b31bbf4f09d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 357, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d007147f-1d9e-4e54-962f-c7dab946ebdf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 359, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef701aa7-e52b-416e-bcc8-c37af4dffbee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2957), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ed3fb1e-7c98-4c3d-bf1b-0f541880c372") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ddaf55-9dde-4f3e-85f7-6f3de98e7fb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cd78c77-90b1-4088-9d4c-7f35dca7596d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b2af249-6a27-42c1-a6bf-120c7303d6f5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c65bce9e-a302-4887-81be-0f809603b4db") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f15c747b-038f-4ab0-b33e-981a2b19f166") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b716f571-f13d-4bc7-92e7-268259d11451") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68612a05-7e61-45d3-960f-68f872f7b382") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(4786), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df08b52b-8bf1-44c2-8fac-2878577184a2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9aa357e6-0dad-44be-909d-d635165b388a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ec4eb83-99c9-4380-9dc1-0671bdeef221") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("372fa555-cb2b-4106-ac4f-1b3f4e452a83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee6071bf-8fcf-4a8c-9331-e92f32a247ec") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c6357a6-7fdf-4bb8-b2eb-9f8b385ddce0") });
        }
    }
}
