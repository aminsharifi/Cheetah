using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Sync_To_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Sync",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9409), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e4d6cb4-1cb3-4fc2-83bc-26f51a918ce4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d394eab-b61b-4cdd-b027-a32e0e27237a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f941626b-ae9e-47ed-b178-528ce7112bdb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9422), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83e40004-5d5d-4fba-9824-28712b51c4a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9425), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c4d79a9-eb12-4450-af4d-76b8e03cf8f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a7893ed-9c0c-4f94-be93-b1c306c5b645") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 227, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f722160-cbc7-4256-a1ed-d980e8d835dc"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c710f2c-3571-4bde-aaae-a40725e329ec"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db61ce08-5b8c-41b2-a8e1-ac78d5ddffa8"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3501), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24975a56-a909-41f7-92ce-050df141b187"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de7c56f3-a968-44cf-b9df-9f7396a06421"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45bedc52-3458-45f2-8b41-712c68a99a9f"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5688efe-f157-4f6e-8f4f-38340240d3c2"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50024bf9-a1b9-4c4c-aea9-c9aff319cd2a"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a19efce8-6432-456a-8902-7f22335b0064"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61bd6438-c297-49d3-9982-6c68a2c6487c"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3541), new TimeSpan(0, 3, 30, 0, 0)), new Guid("180e2000-e64f-4dba-bbd3-238057b86b4f"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 3, 30, 0, 0)), new Guid("10a5c748-2b44-4008-91dc-7c6d5cf41536"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd6ae607-bb5e-4495-9b7d-60798159f44b"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord", "Sync" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b477dc4b-2593-4d8d-8cf9-7687938223d6"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 3, 30, 0, 0)), new Guid("38c7dbd7-c9ad-45e6-88cf-8269be9069c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bfab4a1-6d72-4006-b5ff-5571bf4c035b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0aba4c33-dab5-4e57-8206-e94fb1d7b8e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bcfa756-2b89-4878-a5b1-5c8c4cbec50d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6063544-d0c9-4826-b30b-4bf4d7ad1b6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("944000a6-4e2c-4372-8942-93830180b3a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 223, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e12fad91-9ebb-4126-aad6-6402dd227bfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(9194), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9107a895-1d8c-4e38-a134-fce160fcc97c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6c12cfd-d67f-4c95-b166-f3c0598d7641") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf22f574-f3a8-43b1-b3e8-6d4c5079c99c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2c1ecdc-ff14-4dba-ad3e-0d8501c41177") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51151ab7-7966-43b9-bc0f-4097d1ed9d75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0b9e522-afe3-496e-a4bf-38adf1c105d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 3, 30, 0, 0)), new Guid("172a2afc-fb77-4fbb-9249-b4e30f42ed67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b37961f-3c5e-4828-befa-3b9d11971093") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a88ddbf-c3ec-4221-8e5d-d4082691ef1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fb67908c-0f5c-42ae-a90a-f4054768e655") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("631d4b42-7d75-4ca7-8240-7433cd730bb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15486cbe-db10-4e77-b0e4-5822553726b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07f2408e-798b-4a28-9b8a-f014a76688f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9dc2f721-8322-41b6-8760-a65b91f7cf46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 3, 30, 0, 0)), new Guid("505e9357-3f6b-43c1-b725-e4ea73391b87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27cccab9-c3c7-4c54-abf7-7d29e0bdf115") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28d725d8-bd70-4ebf-8a14-928be816b24b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7181bbd-355a-4185-8ef7-67ffb2c5eac4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f08c7ac-bbdd-4fd3-af69-7810b6c03de9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a571e31-87b9-42cc-8a84-a8f0f3022f6b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4250e1b4-66a3-4917-b6e6-4d4f9e880c6a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e11e951-6ef3-447b-b050-47cf7e9b3ecd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1268baac-9433-4bb9-8c61-34547cb0074c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(234), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc306c08-40fc-4d12-8bfa-a60989709aac") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4becb24d-268a-48ff-80b6-4e7f565ca787") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86339ca7-4034-4ab0-ab58-0c1ee3da9bc7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 222, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bfbeb85-27dd-48a4-96e7-60e28116b95a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sync",
                schema: "Dimentions",
                table: "D_Entity");

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
    }
}
