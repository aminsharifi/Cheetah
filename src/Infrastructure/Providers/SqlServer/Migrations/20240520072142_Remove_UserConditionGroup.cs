using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Remove_UserConditionGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_UserConditionGroup",
                schema: "Links");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2086), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69e41c48-0136-436d-afc4-6cb5d50d0578") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb273f28-2eb9-4111-90ab-51d350cf7d1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 3, 30, 0, 0)), new Guid("386a2db7-deeb-4d96-a862-58db719a613f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("116098d4-92e9-45fd-bd21-2196952ec9dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d218d32-e052-4936-8445-7f1d623574a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(2112), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca667f25-4e29-4024-b98f-5e0b45d9f617") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 285, DateTimeKind.Unspecified).AddTicks(3547), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0a13062-ba97-44cc-9082-212a855d8aa4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc87c427-89a6-4439-bdac-a061a1607480") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51487b61-2e75-4717-87d0-72f3664bb1a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3aa2f17e-ff3d-4496-8639-f3f7a98e1040") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0885d5b-b78d-419b-8fb4-cc8c3c686845") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4208de1a-942a-4de8-ba56-ee1df51ad96c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ffb26da-6d9a-44e5-ba1e-4b134bc0b9ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3554), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1eb64a84-73d2-4902-91dc-152012bfe27e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 3, 30, 0, 0)), new Guid("924bbaaf-cfa3-4ec1-bde3-43be90c80dc8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dcd73eff-56a7-4dec-9367-fc897a1e236d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 3, 30, 0, 0)), new Guid("326c74f4-222c-4b07-80b1-e0850d41e6c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8e1d989-45b7-4c80-9d55-a6eec3f3d839") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3615), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c72db1aa-aedd-460d-9948-41890245ad9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 286, DateTimeKind.Unspecified).AddTicks(3619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ef2f456-f35b-4c46-8ae0-21a185e45781") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d769b69e-03d4-41c5-8b3b-db83c1cfc0f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd7ff32a-3ae7-4426-af74-95a161d5f882") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32ea0023-6192-491d-a0dc-71626faa8736") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4dd60eca-cae9-41cc-adb0-6b28c1f22142") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57a712a1-ca16-4a04-bf42-4fbeb410ec71") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c9c2abb-0dec-4b66-a50d-05be282a5a50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 282, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, 3, 30, 0, 0)), new Guid("95f37f6a-cded-40d9-8ea6-e86edf70a3aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d531df4-d082-4694-8b88-cfafa84f72c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3330), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e032395d-a767-40c3-932b-a9ae48c9f741") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e0c7087-6eee-4c24-a4b4-dbe6b1c03c41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e99090c6-d5ac-4b4b-9e72-85dffa8a8d4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9e0ade1-1abf-4728-b369-0d1eede11af5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3466), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4dd956c-90fc-423b-80cd-c75ddc4b877c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ade6453c-5533-47af-bfa0-29e562e146b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ea4575b-116b-48fb-a60b-379eedbfe4c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2ecbebf-6478-4560-9422-56da5cfaeaec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 3, 30, 0, 0)), new Guid("667b98d8-e129-4ce1-bab7-d40acc103858") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4e97883-f5c8-45fd-8aab-b06fd0992b60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 3, 30, 0, 0)), new Guid("726ae80c-6eae-4485-98f9-41a8569647e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f996f78d-08b9-4af0-b5aa-16a53a73ec43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57fd6361-b8ff-4914-b252-3bcd7fe17436") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("88925908-d570-46cc-9a0d-bc2e6867a7d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ebe5816-2b47-4e4c-9dc2-a8be46f4e67c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d75e3f8-fb78-4c54-bf01-5ab2bd876743") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8a64375-d3f1-458d-9df1-f4023cc5cae2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(3348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4996adbc-1c49-418c-bf7c-f751e75952ff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 282, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c28e7740-3185-4982-b28e-ef6d0532039d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8189d768-03c5-486b-8db4-d63f5a612e40") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5b65d2c-8b95-4615-af00-8c3767b42ac9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 283, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e19d6009-0e64-4f6f-a481-bc8017382855") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 282, DateTimeKind.Unspecified).AddTicks(1780), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5acc73ed-0c7c-469f-9746-2a14f0cca849") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(26), new TimeSpan(0, 3, 30, 0, 0)), new Guid("050544af-9318-4713-a61a-03bb70c4a9ac") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 284, DateTimeKind.Unspecified).AddTicks(306), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1604f09f-4274-4a52-a7d6-86ceeb43e92e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 51, 41, 280, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0b165a8-f4df-438d-8943-05c3a864323c") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.CreateTable(
                name: "L_UserConditionGroup",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    L_UserConditionGroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserConditionGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserConditionGroup_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserConditionGroup_L_UserConditionGroup_L_UserConditionGroupId",
                        column: x => x.L_UserConditionGroupId,
                        principalSchema: "Links",
                        principalTable: "L_UserConditionGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8371), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6fa5350-c838-49c9-94f5-3a00cc8e2615") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03619895-701a-4290-88d5-c53fa71c21ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("466146b8-d648-4047-bd6c-4fedbea9a88a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1ef2c1b-2aef-48f6-b920-2b5c43d8e5df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46e3b742-4b3b-4141-a6a0-781bce694742") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32b16881-9b5d-437c-83d9-04f733cb07dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b339f5c9-5bc3-4bb6-a057-1b6ed28779c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67782b07-9f44-4910-9403-c8ff5ae33404") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 3, 30, 0, 0)), new Guid("34b1bd39-ff6f-4398-ba3a-8906e9e5ef2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(4), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9789ba65-6dc7-4be6-8319-b71708b353a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35b19a5f-0c13-4cc3-b496-ac04551b2f26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(15), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a0fbb96f-9960-4ab4-a121-777a3fcbb821") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(31), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0c9ac52-ad76-4b4a-8d69-abd4c06a98f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(36), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a18d34a0-ee0e-4524-89c8-bdb4e96d2c51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 3, 30, 0, 0)), new Guid("412beab5-97c8-4fb2-91e1-5542674065c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9cb3a2a-517f-4b2c-b04b-68224af6832b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(52), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7eb9de6-f7db-4433-9b78-fb3aac12d8a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 3, 30, 0, 0)), new Guid("741d130b-5282-4980-9c51-647f7ad99364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49b719a2-bd43-49a9-b86f-f6667577629f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7745e1b2-dbfd-4910-b275-dae52c5c2880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(3988), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f9828b4-6de3-4f93-9157-5b8edfa52e74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3960c784-b8c5-41a7-8a46-65c93aab1985") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce3bb274-d4c4-4116-ad53-03044b0e79ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)), new Guid("840b4db8-c8f5-45ad-a784-908821db452c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac71722f-5ec8-432f-a8ad-44fc4f1eb8fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1592327d-c66c-47b9-840a-b0640a692ef1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 712, DateTimeKind.Unspecified).AddTicks(6227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5316b538-ffa9-4e51-935d-516584a48990") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("53154d1e-f844-448b-9a17-286697d10764") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d583c8d7-e4a4-4826-9ae7-8e6cb3ec1558") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(131), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bb40740-6a4d-47eb-b64f-9125465cbe17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99042731-0d40-498b-9be0-e4ffff9d2b70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3646197a-951d-42e2-bc65-6180f54b5c2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("919d654e-9dc5-4152-8f65-66ecd5bc86e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdfe2168-bf63-45b2-87b4-1f6ee0a24106") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71b69d07-3b9f-4843-9cf3-1ffc3b608ab8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(13), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c641d698-df5b-4659-9013-bdf88a75a296") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("601ee9d6-6776-4bdb-b659-bb1f112a9313") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c93361ae-4965-4425-809b-782e3d3998e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c2b5ee3a-21c3-44d7-9122-c3d6ed818b01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6f41609f-2006-499e-9e4c-6d769ef6a82e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 715, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 3, 30, 0, 0)), new Guid("38f99caf-a79f-41d8-a789-1c4cd3b8babd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 715, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce496182-15e8-44ee-85c6-b07a847d7b34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b12b52b-0609-4502-a328-04570408bac7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("027b6066-d988-4a17-808f-cc3b38bed973") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("76cf84c0-9eee-4510-9652-3d592a56cba9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3b629df-5686-45d5-9123-5e0f07676026") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2a698ef-e4ad-46a3-b025-ef9baedb3e57") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c58db21a-ed57-48ab-9515-4d2977c55f83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56d06faa-5dc4-4578-9402-2c443aab3fb8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4442), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3fc1287e-7ff4-4564-a371-9483eded473d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 712, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d70bb6c5-2eeb-496a-932b-ac0fb73541b9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8779be99-4442-42ac-9cb2-fb05ddfe43e8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f42eae9b-b42b-4130-9285-bd71b01964cb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 711, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb24558b-c636-4684-94ce-81a60ad678d7") });

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_EnableRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_ERPCode",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FifthId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FirstId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FourthId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_L_UserConditionGroupId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "L_UserConditionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_SecondId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_ThirdId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "ThirdId",
                descending: new bool[0]);
        }
    }
}
