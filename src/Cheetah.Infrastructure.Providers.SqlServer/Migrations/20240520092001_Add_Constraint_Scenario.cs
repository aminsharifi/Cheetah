using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Constraint_Scenario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eee29dde-7544-4420-95c1-1b4d5c7a68e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d5512a8-9c80-4eca-86b3-98954dbb8aa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 3, 30, 0, 0)), new Guid("041e96b2-f44b-40ed-a521-713d0551af0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f49b8f9f-10e7-4462-b946-829288f723bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("005ad7b8-f2b0-4e07-8007-5adb894b7b9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 3, 30, 0, 0)), new Guid("727f87cb-b937-420d-8cce-72d8f16761e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 924, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03e9768c-f894-4b26-8fe2-b6241cdd8183") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5dc8d070-7111-4a95-9328-72a1f3fa4825") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9bf2f79a-6c93-4318-b0bc-5c99f84f3ac8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ba78806-7474-4fba-a53c-c604ba444228") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("17f91e36-aa59-44d8-980b-bdddef26d4dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("732f9e67-5b6f-4440-ab0c-1ebf3bea63f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9788bb74-3b1f-4fae-b929-fd207e5bdc7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a80eef83-65ff-4b60-84da-2efb0609f9bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cdf10ab-c56e-4cd0-a5c0-ae228153a8e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d80bae1-41bf-42eb-b612-081b8d1ecc13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 3, 30, 0, 0)), new Guid("081de6db-6549-4ab8-b19b-912f3b682429") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0b4a1c2-f0fe-443f-9900-280607ee3dad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("739303ff-2310-494f-b999-61c1491e50f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f97ca56c-0d71-4e56-8d2f-0142faa433ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6cd53d5-f7f0-41ff-af76-fde465da6abe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8604), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cecb4495-1860-410c-996f-59e5092b7aa1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8607), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48685e48-4004-41fb-9cad-89c356e07a78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("269d741e-2c8f-4255-a769-2fbff1b6b85e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8612), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a1810e7-c8dd-41ae-9d8e-a19942ce1f1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 3, 30, 0, 0)), new Guid("146fd180-75f7-4059-8625-6e0135c4174f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6dce95b7-fc2b-4991-82d9-0ac037cbae4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("128fd601-e938-41dd-9ddb-876f385da093") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("09c22ee5-4423-43cd-8e7c-1f5468d4fa6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d8f61a6-7d64-4494-bf02-fea3c4fdd364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35504dbd-002d-4475-92d6-07cd9ede807e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("335112fc-d862-49a7-b7d4-a08efef10ed5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5285c932-b918-4249-97f9-cb36cc7b105e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a23561f9-774a-4e11-803b-ef1b69316bd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4368), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c703f04-6a3d-4850-bb36-391bb6392120") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("457714f4-1f1b-41b9-b11c-6aa2e61fa541") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6558dfeb-9cc7-48f2-8da2-25333f0c0527") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef96ee34-8852-42c9-a0bd-e937cce8299e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d28c910-caf2-451c-b8c0-ade408702bb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44160268-e447-454d-bd02-98355a48d86b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e03c8c6-1720-4676-be6f-e14906667d92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79e74505-3113-4c20-8643-5c8a0fa7bc8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41ce4de8-04da-4a1d-ac93-d6f75fdfa448") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96e91845-a76a-47ed-af65-63a681dd961d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91eaee83-1d2e-4628-912e-2eb09d1547af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9bf0c12-5083-4674-8b2f-5357f047ee12") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(8635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b8f3eb4-1acd-4197-b908-8ed5575ad287") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8db44612-3ddc-4084-9009-f8eda4e0d48c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(9008), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f647e5af-b2d3-4d53-8019-e14b637695e2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b1b0ff4-83c3-4a1e-a8f5-c000b9b35699") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66360de1-d1f3-4379-a103-ac601e9b6b0c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd70b676-0d97-4d95-8eda-bc100b4bab14") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f72dc05-b236-4bb3-8ffc-bb235e56acb6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 919, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 3, 30, 0, 0)), new Guid("998fff66-da2e-47f9-b33b-5869f9e7c745") });
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3acef13b-ff80-4d68-ada1-3af32830af8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dafa2075-d19b-4aaf-b0ea-9a78508a4ea7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7165d9fe-e5b2-4671-bd60-e5bfb2ebe1ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b0f21f8-ca7d-4949-9c0f-8a5e67c2d2c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a762f929-aadd-44a9-80ca-ba40043c0d70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ecee1f0-8531-455e-9432-d3779c5fe7c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 482, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d714507-1b8f-4efc-8cf0-bae86fe935c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("691ab8d9-5b8c-47ad-80dc-40d934c22586") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c2ba860-ae81-48f7-8aec-174905ff6441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4367), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be94f789-35d8-48b7-a936-bd9be02f80da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4372), new TimeSpan(0, 3, 30, 0, 0)), new Guid("384a6ea0-1f83-4990-98a6-0ba46dce3903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a57971c-43e6-4b3f-acc4-b3a138d73a73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c56586d-eda4-410c-af41-29baa1f3fedf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 3, 30, 0, 0)), new Guid("237a71f3-6b13-446a-81f7-69369ae75965") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6304fce-9f9e-4a83-8754-049628a0b68c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 3, 30, 0, 0)), new Guid("177d9ef1-28ff-4af3-becb-498e389f228f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db3a238d-c52c-4f9e-a292-b569f56aeb45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ea04046-a5e4-4a2f-8c2f-c5a988d0324e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c34e1806-84c9-424a-b8b9-631d2f08a36d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00c79700-c60e-49fc-b378-a1aa38342ed7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5833), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28e0b53e-e30f-4b6b-a45e-d78952f9817d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be780752-41f1-4fc5-a841-94e5901f1035") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e80bed5-5a17-4780-add7-fb3763921fbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2abf0db2-acc8-47fd-84d8-3488c3604559") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aeda43e7-b99c-4005-8a08-9a636862985b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cad4ead5-5154-41f4-ab18-ca7cfabc50eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 478, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b034d8f6-a26f-4fea-8b98-88b54c82f998") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("278b5c84-dbb4-4807-b02c-696882cf48b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9130cdc5-0aef-4853-b292-b2e2b74d5d97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac6ff255-7c40-4ebc-98f4-cc1e8147e0f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68aef45e-3b96-4b5a-9c5c-e71398160d44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0047ca24-ed17-49be-a23f-a4ed99980408") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47c4968c-4fe1-4823-b608-1ccadadc085c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2854af21-67cd-4ea6-8894-42b2d912831f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20821f26-9642-4e27-b7b6-23f9a456e3c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d860aeb-c5bb-44b4-bd3b-2e723c7a4ecb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f250c5e4-713f-4ba2-901d-34c328000c6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abdbd173-cb8e-45db-954a-a81380a3cbbe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d99c68c-1983-4481-9f9d-21fe77c6599d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd6d70a0-9a08-455f-8cdd-5ef141b42a8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16184429-c20d-4eb2-8dd9-01b0507dc3f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(4575), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54183d65-0d0e-49a7-b6f4-6812a5f1d919") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("459bfa13-47a7-4168-9038-3e1a821cd396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa3ce758-b758-4dc7-87a5-93c215afc39f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd70da2f-6da7-449f-bc37-7864e663ecb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1624), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a1b37e0-1437-4ba8-94ba-563e19d8f314") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71483239-5d1e-4edf-99f4-f562012d2135") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6215), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca0a2e57-e1c7-4414-ae57-aff405d65444") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efed98ea-672e-4ffe-acd5-e81b44a42284") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6225), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5a75ca9-5b7c-48bb-a23c-5cf803ecc048") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(364), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83ffb95f-ec42-41ff-b754-baeca60b0846") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43c90797-14f2-4808-9686-b15ff99f6de7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(8693), new TimeSpan(0, 3, 30, 0, 0)), new Guid("057da293-600c-445d-9171-f11dfdb1fe15") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 467, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b7f815b-b352-48f8-b0e4-4fee7542b66d") });
        }
    }
}
