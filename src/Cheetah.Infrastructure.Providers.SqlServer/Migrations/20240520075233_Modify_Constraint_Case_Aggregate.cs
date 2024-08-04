using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Modify_Constraint_Case_Aggregate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropColumn(
                name: "CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropColumn(
                name: "CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.RenameColumn(
                name: "WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "F_CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_F_WorkItem_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "IX_F_WorkItem_F_CaseId");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fce7f25b-062e-4162-b110-d634dc6960a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d962e0fb-95d6-4935-ac78-3a31bcb8ca87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("672b37d4-b9c5-4539-98b3-b78641cacdaa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71fbb56a-6971-4fd5-8541-d81c7a9c6f66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4749874c-ac3f-442b-a94a-bcd8bcc0a886") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70719537-c6c8-4ecc-9d3f-e7b4ff3d0239") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1432627-ff4d-4893-829a-5b6ac739c62a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9678), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f80ea019-d9aa-41df-8728-82f7723f4ed1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccc95834-b6b3-4d18-b09a-93aee1b1dc81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07fdff72-c591-43a3-ae16-6c6bf1cf133c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9729), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae2aa31a-161c-49c5-9c0a-b8cc7fd0d543") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ce05771-3e3a-41f1-a43f-b8d42aa9c62f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f69c8ea9-d9e6-494b-b493-0d5648598771") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99863305-e302-4e9a-863e-115f62f1dbb8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb6506c6-9ea0-4df6-980d-c42395ce2a93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("003f0f14-e6ca-4512-b37d-6afa0ebc6e8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a135387c-09de-4a7e-b991-bfc42dad0d1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dcf289ef-9935-4ec5-b861-5928c34441c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5497d429-43bd-4b16-826f-8e9f4e44f157") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f022f4b-8c0a-4dd8-babe-1052611b86fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1a56ea5-71bc-426c-8342-e049d9041224") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f45575c-586a-4d3d-a0f8-894160241d25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04072300-400b-4971-a442-bbd16661f593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f0855d2-0398-447f-891c-f9a2ca32a21d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7017c2bd-dfe1-40e5-8822-9d53e7659ce7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35e75d6b-6625-4a21-8676-f627f1a79f50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 345, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0408cb88-a370-46dc-abd9-235b5ea85f4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a765ade2-93be-4c01-9cc8-9fd22e315aab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99be2a1a-f73c-49a7-bb31-89373fdc9880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8f6ce0d-0e36-48e0-a540-782dc189bcb6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ba7babf-ef17-4961-beb2-c930f0647ef1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30584350-d1ee-4aed-b5db-7f2bb2d9e06b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f2485f3-34c4-44c2-9482-ea5fd70c8c11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, 3, 30, 0, 0)), new Guid("145d0dbe-06ec-4a91-9879-1bc9b6fb06ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a44bdf0-e5e1-4798-9834-d1a17481737e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a485583-aa44-431a-ac0b-f9aa3b22a954") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed0c0448-2968-4f58-bb6c-ba9aac3a9968") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f4a617a-fa3d-4cc9-9616-fe226676496f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad9a0c97-b5f7-4df0-8f93-aeb16d59ff8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12991509-0080-4d59-99b5-0681daaf531a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a23d219-2c0e-465a-bba2-e3f0f2383dd5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(1015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc56b753-e01a-4293-ae29-ef3352fb396c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba8309da-36d4-4e20-ae02-a3c89a1afd07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48641316-25cc-4c1d-961a-0469a3109b65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8166), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee7ff13c-1248-4967-8d64-80e5429c423d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8169), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fac50aa6-e02d-4d01-b416-ab252da9a9a1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b52f98f-3ae1-4a04-816d-6422ad247517") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98bb95d0-1001-45bf-9fe4-8ba48e78a878") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9ce1c31-1553-45b3-864a-a2a3aa0d84b5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7262c68-2d0c-4bba-8c33-f51d33e7c130") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 345, DateTimeKind.Unspecified).AddTicks(4965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("661a4f02-578f-45ea-bb52-f9be86939ad6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(5082), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57d11719-2062-4cf1-90e4-092a20409935") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32aa36b3-1dd0-48d1-a4aa-0ad284e39ed2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 342, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4a44f30-b90c-4c27-bf88-7654131b15f7") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Case_F_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "F_CaseId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_F_CaseId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.RenameColumn(
                name: "F_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "WorkItemStateId1");

            migrationBuilder.RenameIndex(
                name: "IX_F_WorkItem_F_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "IX_F_WorkItem_WorkItemStateId1");

            migrationBuilder.AddColumn<long>(
                name: "CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99e7d0fb-792c-4d07-b47e-42853186cc3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fa24d4d-60a7-4918-bdd6-73e29409ae30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d51c0471-f765-4c65-8ab8-c88ed3c74d3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d3a806f-fcb7-41cb-b245-82c85dc22a44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a95ef306-514a-4841-88b5-849906b1f7ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12b6aaf4-8461-4b6e-9201-6c70a4fa73c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 849, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55a21e02-d0b1-44d3-9bcb-babdd7f23f39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("576224ac-e112-4761-9277-7d4b00165b91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9bba22a3-daea-454b-be94-29f5d66cd33e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47124546-a7ed-43ec-970d-4e0879349c9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2775), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a70ec186-837e-4e00-8eb0-49d01492d617") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1731b94-a494-4cc3-a1ce-f4eacc212d49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 3, 30, 0, 0)), new Guid("765b261b-4d2a-4dce-bfd5-c5171f43dfd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a05974aa-2453-4abc-877e-d3ab7160cb5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ba705fe-5410-4edc-b595-db3c2b65897a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2855), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27d96b51-110b-4301-9fc6-71c65189ce47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2862), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81dcf5f6-18c6-4483-931b-2223024926b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf378260-dca1-461c-8b8c-ccbf81542130") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44009a17-4d20-4f4e-a0ab-3e02f1eea81c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b364bdd-3fea-43f7-b598-c150614eeb1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("943282b0-c0d9-4b53-af2b-730805de5328") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fa9a516-5bcc-4655-bc01-d71e23d26918") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2983cbf1-2f66-48bc-b256-b36c36432815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5987), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af4f4c77-acf3-4570-b527-51e4d409a1ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 3, 30, 0, 0)), new Guid("564b88c8-100a-448b-b342-6fd746919b7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7d978e0-fb93-4217-ad4e-14ebdbb68e70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 845, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67efd6ea-defe-4b3b-b805-aa0b60bb631b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(9655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a75389d4-c66c-4611-b01c-434d0c74984d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("834aaea0-80a8-4303-9cb6-f466c897c9f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a671d15-556a-4e48-975b-0a275f05b949") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2056), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd99c6e7-ff95-4f0b-921b-af4593f9d4f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1c66125-b1ac-4635-b115-081886c1c2e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec3cca46-c1af-48ba-82a4-fc1defd2d819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2065), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84dd2abc-13b2-4749-b1c8-62df59ab566b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82ec57ae-4506-46de-a5c7-3980f1910b47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cf82eba-be97-470f-98e3-0968aab23abb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1d44ffa-3c4e-4373-b383-ba960d19996c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b656430-8e46-4367-9e0a-50adfc4c45bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28b728f4-5d96-43a2-884f-7ed109fc5cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a23f9574-9c0c-46bf-9b9f-53c8d66c909c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85d1980c-c9b2-43e5-a823-6449f89dac0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6b43d4b5-a851-4d23-88c6-e60b1b78ed3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b99c5449-49ff-4798-ad5d-0720cbb7db75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8966aa45-3156-4a4c-a172-d62ae9fa9514") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("683eede4-393d-4db0-a52a-c5eda238e76e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06caa1c0-24b8-400c-bfef-a7cacaef115c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(6352), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb376c06-e931-4d0b-bad9-26937c28bf51") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2b7d5ca-070b-4265-a942-bd1a22e11a23") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70fc33f2-f3de-434b-a32d-3a2988013114") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd840bf4-fb52-4e1f-a1f5-6b21dcc5c30a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 3, 30, 0, 0)), new Guid("344606d8-9def-405f-860d-215cd9c7ffcc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(8494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ae737d4-ecf9-4af8-8714-84ffd10e9376") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e26a4368-013d-4396-a102-849c02cc39de") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 844, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6530b630-9cd2-484a-94c6-20ebe987dee6") });

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId1");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId1");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId1",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId1",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId1",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");
        }
    }
}
