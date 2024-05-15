using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Remove_ConditionGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e277ef0-a676-4288-9152-bdba4d796d50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8bd0c3f-de0b-4e25-b93d-1f1d4fa9fe4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e3f1643b-966e-4d81-adc7-dfe3955b25e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e88b3e1-7bf8-4e09-8643-761ce19801c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68176843-3d0b-4e00-8b22-9345249d2354") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f08f169d-77ac-41cd-a615-ab3f0761b53c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 319, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a6f1309-91d8-415e-93b9-81590dde3284") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c19b62ca-9c4b-4fc3-a513-ac0b53d5aee3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e63e988-298d-42e1-933c-a6aa94bcfdbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79604f2f-4961-4892-a476-fc8c72a38106") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1862d0e9-8c65-40eb-81be-02a4617e8b51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3402f201-ae62-421b-b73a-daee2aef3030") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 3, 30, 0, 0)), new Guid("87616124-d755-4710-b204-2e86e0d28bba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3d137eb-54a6-4a73-a5fe-5ad436759c0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a182c31-563d-4a51-aed3-7bc314919e8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74438da8-9343-4551-956c-a38322482b92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("035af571-179f-4f72-ae2a-2728658fd141") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40012ae7-9b63-4b85-a485-b196b0655a71") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b901a06-f1dd-4759-8e4b-0fad68a6b71e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 320, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc963667-6424-4f46-a945-5918d235d75a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ef54273-ca76-4f34-869b-0fcabab5ca82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77875cd0-58ea-48cb-851f-d4a19e42953e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7364996b-8bfe-41db-8ad6-e01a65114242") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae9a88f0-31bb-40f5-8b90-c30ef9b9f75a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edd42399-5d02-42f9-a808-d0b077e59500") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63263ddb-977b-4351-ae9a-bd857029f325") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 315, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b12eee90-20ee-4434-af5d-f55815ee16fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b20c691a-4d5c-4c68-8981-b6e3e3c70e99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85492095-be74-4c92-8b1e-aba1ddca5c8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5582), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f7f35b3-5beb-4364-8563-30ae25f15ed8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("255d1438-599b-443a-84d3-3f0906e7bd32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4f0a053-a20c-44f7-9cd2-8914e1ce651b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 3, 30, 0, 0)), new Guid("610ff0cc-1428-42df-bbe1-be09509a2d85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e06654c-7248-4d6f-98a5-6cf85380fee2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c2eebc20-fd4d-4996-a3bf-cbd020ac7493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(5445), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1788afe6-8147-487e-a2a1-0e9cd558f0f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d249a204-6d42-4961-9d4b-b6802057ece2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(3113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01107b81-44b8-4b2b-84bf-707d0c921d0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aaae4a29-ff88-4ba5-9994-2b2adbcf0684") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 317, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cf7f857-97bd-4b3b-98d5-5279f9bbef38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1382ca34-9761-4650-950a-21d5b5ccb9f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dae5a5d6-47e6-4ad2-9462-6b0e4fe5f150") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6a56a2b6-770f-43cd-8eec-835f2e3b629f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6ba9797-91c8-4331-8cbf-4618e3e3d5d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("497007f7-ec17-41ef-b0bd-8a8d9ccb287b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2ab639c-085c-48cd-ba51-1340bb135b7e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 316, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cfef9fa-b425-406d-8500-913195202079") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efe86591-ec76-435c-a332-9518980ddb0c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15258698-36ee-4cbc-a7f8-b18544f336aa") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(1569), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6b415bd1-b6d6-42b1-9ca3-93fd0083d74e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 315, DateTimeKind.Unspecified).AddTicks(9772), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afd8e3f6-74f9-4e56-9bac-e96c88734136") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0579a7ac-27e4-4543-9024-4e94868e45d2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 318, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("172850a7-fb06-4b7b-a8ed-678407261ddf") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 31, 39, 314, DateTimeKind.Unspecified).AddTicks(3382), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf02bf27-36a4-4873-8331-f2a62000e0ff") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a158893-75e6-47d4-a587-feaca9ba2977") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5d1fe87-8df6-4b1d-8739-6b6151ec5e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b267c517-9df2-4941-ada4-ed7e2abe28b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("163ee147-405f-4212-b84f-6c87199f1772") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d35f8f90-a06c-4faa-9193-67e0019c1c4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db1a683e-6167-46a9-aa2d-c7e14862ac86") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 470, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7edaceed-852c-496a-a225-4f6bec7be9ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa56e7de-868b-420e-8c73-52c453e88dcd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1e42d99-657b-433b-9119-43d0a443f1d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3f34317-3a6e-4e4f-b918-1206358b7f05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26f86a2d-73f6-4ea1-9e60-fc90a0a21713") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23f9fdbe-3534-4082-8d99-347bb53a9cbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4758db17-1e4b-4cf7-946d-34152c383c13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("536dbd08-96e8-44c2-b4c5-aa536c735a27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0324989-6336-4c71-a2f0-8d79d9de71f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f405b42-eb39-411f-9f7c-7816c7b65881") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b04776f-6266-4d89-b0ec-25a03e4b5bad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1800), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40972156-7e25-4f5c-9046-bd619ff90bfb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84ffca53-758c-4dad-b50f-dc67f46613d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1807), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8dc01f89-8055-4823-9b70-8097e722c6d9") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[] { 115L, new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 471, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 3, 30, 0, 0)), true, "گروه شرط‌ها(Facts)", 115L, true, new Guid("fe9c3164-4eb8-47af-b085-2abe9fba69a6"), "F_ConditionGroup", 115L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6467), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5c31595-f4e9-487c-82a0-d3bb9298e786") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6512), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59eafd2f-962b-4857-81fa-552e2d2ed7a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7cb161e-f7ef-4d54-aab6-9d49ecc8d37f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43c380a1-2af8-4233-bf56-bd132fd20dca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("893b2e8a-6831-460b-8121-78076a9cada8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("afcf14fc-7083-40f6-8f8b-5e556964715a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 466, DateTimeKind.Unspecified).AddTicks(8562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d7aa0e7-6582-4efc-acae-b1031d79586c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b562f11-f635-4dc5-85d1-595dc5c5b8bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab7b4b24-6a4b-46bc-9437-cb4b8a9392f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d40d7b30-0806-4789-93be-fda786dbd42c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 3, 30, 0, 0)), new Guid("09ee3e33-618f-4152-b4e6-858315afbf27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2668), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54cd2002-6a38-4914-b622-9b4aa58779fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69e052e0-2d72-44dc-932a-c8c5a9fb1832") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6760b19-7c76-4625-a5ee-3ffd921b6c89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a875bdf-83aa-47f7-856d-9d58a388f78e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0937dac8-7f48-4855-bffc-3ceaf36f210e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0036664-e15f-42d4-8544-9d50f18c24e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b020919-71cd-423b-b3c3-c10b0ed2b68c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79b1922a-f159-4bdb-b57c-a86f140e665e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7949cf83-612f-4ccc-a8e6-157985261dde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 3, 30, 0, 0)), new Guid("133b89da-49d5-48bd-8991-59a290f29f55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d62e60b2-c011-4bee-9865-c7ae16800c51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31a006b7-39f8-4954-9ab4-2e80ea05e61f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6a7a35e1-e167-4152-9aae-aaf87977361e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("661c818c-b964-4dfc-8073-565fc2dd2728") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 469, DateTimeKind.Unspecified).AddTicks(1702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed11b412-2ccb-47a3-8d1e-b3f95faff1a1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 467, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 3, 30, 0, 0)), new Guid("baf786ab-e63d-4dd2-9e73-846e5b4bbb37") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0e2d026-8d0f-4a91-883a-e4ecaafbfe80") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54cadb4d-386b-49fc-a72b-5b37ca0918f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63ec0b16-887a-42e9-88b0-e8fc0043e2a6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 467, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56490d0e-055d-41bd-9a41-9ec0bb6694ee") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e391a2c-0ef8-41f6-9897-ebdb86750dd8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 468, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7ddbad9-acec-4c63-88a1-62b0d8aefc74") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 10, 0, 17, 465, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63ad46ba-9d21-4b6a-9498-af33e82589b8") });
        }
    }
}
