using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Performers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf5e14bc-2e47-4207-b908-3baa9755ac42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d8a5d6d1-9cd7-405e-8b6e-2f630b3436af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fa3b473-6df4-4fa2-bcd2-5d00e0863096") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15d61567-a7d3-4ca3-91c6-e41070c1cfa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1156), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e946e929-5ba6-43de-8773-9c940b742186") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e486b99a-38c0-4f48-a0cd-0f98f5d2417a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa462075-fc2d-4cc9-8bcb-aebc9348db8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9266), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c6c44e1-ab61-4c17-a62b-c7d5b886bf2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9269), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c3f8eb2-42fb-46b2-b412-7ee2196be204") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d7769ea-ff9c-4dea-9488-ec5beb5f91f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d978d490-ed7f-42d9-9b60-f15a702e0f92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, 3, 30, 0, 0)), new Guid("657e2766-dadc-4daf-95bf-1264e8b3312e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 3, 30, 0, 0)), new Guid("75177607-e20f-4935-a44a-a989d1f04a73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef8f6fec-50f0-4b1e-8241-d5654b239d45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e73ffb6-a3c9-4dc0-b7a6-1b00eda8c1a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 3, 30, 0, 0)), new Guid("266f44d2-849d-4ceb-8390-29ad0f21c8d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d57cc65-90ef-4830-a981-165bb95d872e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(9329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c36c9ec-0c7f-4900-92d7-ddb0f9e1d25e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 504, DateTimeKind.Unspecified).AddTicks(7208), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a14428b9-82d4-486b-bdaa-8f78851c6d47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 3, 30, 0, 0)), new Guid("377b2ec8-7028-4452-800a-62c4911fcde9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eacd0495-0c85-4739-b70c-d40521de5811") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5acfacf5-4b32-4eb0-8688-88df617f87b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c48b0eb4-e476-45a9-998b-9898119303ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e529aeb0-7d16-43cf-afad-e0a9234df750") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8065), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e31a3997-4929-4486-ae13-0de261a4d200") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cee7c34a-b9a7-444e-892c-04234b8b269c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8076), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9c1bb7d-3b44-42c1-bf89-100a9ce08ece") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edc60655-fb82-4055-9e42-7876b6ed96df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c68bc1b-c304-44fa-8a10-46b02f2863b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0928931a-2e32-4064-ae5e-ebcf1fd01651") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edfe117c-1538-490c-b1eb-7d497c7584e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f68a13f-56ac-4311-8047-b1d304d9ed52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 505, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d2a90cbc-3a3c-46b4-ad19-5d7da414f2cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3dc134a-33da-4bb1-9e34-f2aea9c2d115") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ec98655-c4ac-4ad2-801c-3e3c7b38420f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bde95015-d2d6-4213-b91b-aac7d93f383c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5310cd2a-f2f1-44a8-8ac8-f0055ae47ef9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4986), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1859c6bc-47a1-4757-a53a-1c4d160e5d74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(4988), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f1e84ac-6330-470a-b9d2-22af5e7fc1ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0aca1398-4fe7-4cfd-97ad-f107864fdbb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(7391), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ab06924-08a2-4e8a-8d9b-79ab0f66f03a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5739616-6744-4034-a534-e36cd419da2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eee5a442-0ee6-4289-b99b-081389150948") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 3, 30, 0, 0)), "چارت کاربر", new Guid("dfd10519-8b52-4245-a53b-46b148edef16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ab065f1-5f32-4433-8d24-49a078c40877") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6adb002-0fb4-4fdc-ad89-0bce56728c79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ace40db6-b8e5-477a-bca0-d91a1fe5fa9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(9926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a5d4fc5-24d8-496d-90c3-427a465b76f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(9938), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77eb52a9-33ac-4745-b358-4e9a79e7608c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6823813b-657d-4ba5-b536-48ed8e3f354c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59ff194b-476b-4298-9817-8e9807ad7996") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eee44d0d-2b33-4294-a20b-dce547875a37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f883329-98d2-4066-90f7-150b9c3c54d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 499, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b78462c8-8616-46df-b8f9-a93fe56adbdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 500, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b716c7c3-3184-4ee5-accc-4c7012249fbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84780e03-4d31-4bac-9896-11d1d3cda51b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d379ec6f-fbc8-4aa9-8569-fe7952e3949a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e49c9721-f6d1-441a-a7bf-cb00f1cc136d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 506, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d60c2330-fff3-4983-9cbd-87b7ddcf1894") });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CheckValidation", "ColorId", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { -23L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(5739), new TimeSpan(0, 3, 30, 0, 0)), "ارسال درخواست", -23L, true, new Guid("30c05150-e0d7-4211-a89b-53fecd6b1054"), null, "ReviewState = SendRequest", 1L, -23L, 12L, "SendRequest" },
                    { -22L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 3, 30, 0, 0)), "بازنگری", -22L, true, new Guid("db3f422a-0193-49f1-bad0-a1272e9a926a"), null, "ReviewState = Revise", 1L, -22L, 12L, "Revise" },
                    { -21L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(5729), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", -21L, true, new Guid("8da63fcf-b1f9-46a6-bc0c-1fe800a7377f"), null, "ReviewState = Reject", 1L, -21L, 12L, "Reject" },
                    { -20L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 3, 30, 0, 0)), "تایید", -20L, true, new Guid("1e3ab8d1-da98-4eab-a4a5-c21a0f95f17a"), null, "ReviewState = Approve", 1L, -20L, 12L, "Approve" },
                    { -11L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 503, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 30, 0, 0)), "مدیر ایجادکننده", -11L, true, new Guid("6815eadf-e3fc-49d8-be9a-8adf45a2614d"), null, "Employees = Manager", 1L, -11L, 7L, "Manager" },
                    { -10L, null, null, new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 3, 30, 0, 0)), "ایجاد کننده", -10L, true, new Guid("d346dde2-4d01-454c-9cbf-0444eb7828f5"), null, "Employees = Creator", 1L, -10L, 7L, "Creator" }
                });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb1f2c2d-3853-49e3-90f0-06e6ed841d15") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("838c0992-7d45-4c20-9ddc-1c50d1187639") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 3, 30, 0, 0)), new Guid("640acb96-8712-4fb8-b162-75220c364d3e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59c66767-024d-45f0-a6eb-e7eef80bcd37") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 502, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1825e508-fa45-40be-a45c-6c3816bad9da") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 21, 10, 38, 52, 501, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1aff103c-3237-49fd-a45d-2e365771efc0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -23L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -22L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -21L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -20L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -11L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -10L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43cf548a-ae7a-4fb4-af35-4cedb2aa13b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9313), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e361e2d-327c-40d7-842e-43780e93a755") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bdd94e3-fe57-4e64-a987-a7d0819d3195") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d835dd61-1fb4-43aa-b9cf-8d346a5a2c55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f64bb782-8788-4af2-b8b1-0ad6ad10222c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b809d781-6175-4728-a1f3-472d149e1b0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc6e897b-83a8-4cc7-843d-0962a1818b9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b74fc779-dc3d-45d1-9deb-c5dd55ad154c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(899), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7e1bdf9-fcd3-458d-9841-8816b71a87c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("679f58b0-fda9-4dc7-adbb-909747733dca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(904), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91706487-50ec-478a-b4ec-a0949a94b012") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d127380f-66a5-4260-90cf-d453d227b493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2bb8ebb-efdf-4bb5-9309-c769c8278099") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b21def7-b2d3-4434-af0c-58d75f7cc13d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83288a8e-88ba-4316-900a-fe94137f6f1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 3, 30, 0, 0)), new Guid("caacb63f-ef9c-41e4-9951-ee629098695b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e0e6bba-d0d8-4c20-a147-1ae26a27aeb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e165fb9-7ff0-4539-b820-d4477f6badfb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9d60c33-7ed1-45ca-89ca-f034183216d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b85db7c4-e41c-4ae5-8c89-e6b27a1d9eba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56d570f3-546c-4592-a8b5-0ffb88088087") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a70df2c-dd9b-4c0c-85d3-4f11ba862e2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8c98719-65d9-4deb-b32c-2fa112bc0b56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d82dbb9-2edc-4456-a709-aeece27fd21c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1c07573-4eda-4da4-8e62-51c3072ddcf9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50088348-885e-49c0-863f-22a827e0e07c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d8a3938-1352-4538-8025-b0601b2a86ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6344), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2357a6d9-48c9-4685-afb3-3eaf30f885e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc77b8a5-4fef-4e2d-8a06-8db4a14a9b5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3be09ce0-359a-4cbd-a8a0-ad345da6e4a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b7343d0-b67f-4b1e-bd90-7dc594079036") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a04dfb1f-451e-4a03-982b-ea3648fbb09a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7782bd54-9847-4870-b40e-e44bb4d9dec1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1bb3155b-a91d-46a7-b820-4e355799c5a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ec9c6e-9427-419b-81dc-f6091c671d16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78c87e35-970f-46f3-9c9b-f932f586f85f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed36c78f-46f6-4bc2-a567-75f368a8a33f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db34260c-4273-4eed-8abb-4f304874fd69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59b53dee-0f13-4fa0-9180-8ca613b0eaa4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fc30ca3-35a0-4cd0-a706-2af8ddeb625b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(9487), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9d82607-3bd7-4c05-86e1-6d3e44a93e9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ea6bf62-7751-4cbe-8272-2909f6828cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8396509-f7d2-46e5-8af5-08f81e8da217") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2679), new TimeSpan(0, 3, 30, 0, 0)), "مدیر این پرسنل", new Guid("56db0c98-3cea-4651-bce0-2acbb1db11ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8714ded-222f-4ac0-b61a-e96ddc6e1bb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c505b07-b597-4020-b7e2-5618afd7537c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4876cd81-7ca7-4894-a0f7-dce7d03b80b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e6a3b4d-8cef-4c2e-8557-5dbf3bfc98da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a6672be-9c42-49ae-bc8d-a91e05eba0f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4091e051-b37e-402e-9f5d-7d3f033fe104") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ccd6c4f-1503-457c-be47-fb0fceae7c3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e28f4848-470c-495c-b076-bc7897a32695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61107578-9acc-46bb-93d0-56228bdc2199") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 407, DateTimeKind.Unspecified).AddTicks(6908), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64234da2-c0f9-4cdb-8b3b-3efee28fa880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7067274-0958-4c12-8da5-dcea6db52668") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b2b8779-acad-48e0-85d1-666ba1360887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e04c3c71-bb87-465e-8bec-ac604bf5280e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 3, 30, 0, 0)), new Guid("676adbcc-a373-4baf-9ac7-39472ac91ffc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f80d4204-331b-429e-b39b-db875ebea84e") });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CheckValidation", "ColorId", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 20L, null, null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 3, 30, 0, 0)), "تایید", -20L, true, new Guid("1a1c6e8e-eee4-4c09-b47f-8b65d222792a"), null, "ReviewState = Approve", 1L, 20L, 12L, "Approve" },
                    { 21L, null, null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", -21L, true, new Guid("7afd0b96-fb98-4df9-9ac1-2240874e00bd"), null, "ReviewState = Reject", 1L, 21L, 12L, "Reject" },
                    { 22L, null, null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 3, 30, 0, 0)), "بازنگری", -22L, true, new Guid("610c74de-e684-4c4b-bfec-a949813c5dcd"), null, "ReviewState = Revise", 1L, 22L, 12L, "Revise" },
                    { 23L, null, null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 3, 30, 0, 0)), "ارسال درخواست", -23L, true, new Guid("a28a5a2d-6da2-428b-89b4-b770c90b0dea"), null, "ReviewState = SendRequest", 1L, 23L, 12L, "SendRequest" }
                });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(1143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b44a671-ad49-46ac-b94b-4f70c62dda9b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02d1113f-8338-490b-90c0-23dfea8d8d45") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5127fc5-bce1-4c5d-b41b-584c1e1899af") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(2952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dd38652-33d9-45f0-b79e-d41b28c4d870") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(3359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f903129f-b7b9-4d86-859a-81d588ccad46") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d1c0fca-8cee-461b-a699-b506d122600e") });
        }
    }
}
