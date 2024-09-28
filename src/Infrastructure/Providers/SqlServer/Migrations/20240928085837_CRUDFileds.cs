using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CRUDFileds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Display",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "Read");

            migrationBuilder.RenameIndex(
                name: "IX_D_Entity_Display",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "IX_D_Entity_Read");

            migrationBuilder.AddColumn<bool>(
                name: "Create",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Update",
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5513), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4543cd7-b2c2-4936-8fc6-8b23ffed3d04") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5529), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bd1b299-e12d-4ae5-85b1-ac76840ed063") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e7d7f84-9599-42ed-8fd3-7e423b777d33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae2038e6-cc02-43c9-9f07-1795a65d7620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13dc1ec1-3cc1-4b74-b6da-2f7176c3ed4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3cf32a6-d12c-4f5d-8e32-75bb27cab4a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 656, DateTimeKind.Unspecified).AddTicks(2359), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("bd7533d1-70b7-404f-a1d5-2e0dea7cadad"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2489), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("ffab7c69-07aa-42fe-94fd-e29699a57e71"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("2cbde78c-5e06-4a91-9a91-081ff4cfb7ce"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("239011aa-7367-4d69-a09e-d281d98a64f9"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("1ea54d80-35e8-4833-883b-6f907b6d0ea9"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("92e71d72-b41c-4392-87bc-9b79ff9992e9"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("91ae4286-b835-4038-b081-992d5c357cf8"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("baf27e9d-2287-48ec-99fe-2a3931ce36b0"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("d7c375b4-2d2b-42e1-9aa8-eeb7c89004db"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("7b9fa921-3666-4369-acf1-edf8a8b65838"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2606), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("027f1761-2556-4a57-97f9-935b0301b742"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("564b8f0e-a5ae-4ae1-bc31-908a7feb1256"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("92fb3368-ac95-41ff-8704-5104e5dfa506"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("e9c73646-53dc-462c-845a-cf7bb4ef0b7e"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Create", "Created", "Delete", "GuidRecord", "Update" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("9cc3af73-0145-43d6-9325-69578f4a727c"), false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b58a791-b9e4-49d3-8f6e-6ab56e619d4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d087c36-47b2-4c3a-93ef-0afff45ecec4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f406da1e-f5d4-4d72-836e-89b43eb751f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1623e6a8-43c1-41e1-b59a-9ebe963d9078") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3140), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cfc28ac6-1cbd-4785-9300-f44847e53744") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a41fa683-035b-4322-90e0-a2a2e817df33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(3809), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54b07b64-7ff2-45b3-bfae-1f6921abc581") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f70f289-9c54-41b9-92f0-cd3e29ae48fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa007938-2145-4dce-a95e-516a25c3f652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1627c0fc-763c-46c1-9468-e912b89e4f2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e62130e-2b95-4485-8dc3-b3d4dc9d7c0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9061), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0384f3a9-4722-47a0-90ab-c125062b5e7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d952f7f-e33d-4b1b-b10c-1d01adf05e07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(9068), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b39921a8-0b8b-4e74-8673-43751fd5b7f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(8143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a07e89cc-ca5c-4d4e-ab20-adda56033014") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f121afca-07ae-47b9-b0bf-26cf557b5da7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cced242-4f4c-43f7-908c-985e2d585ce7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edde073b-f6b1-4de4-b5dd-945b77fefce3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8881443-d1fa-47f3-8e51-29f16d32cfbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72ee3249-c229-4159-af37-9978f53cf557") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 637, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9b3c441-cde7-4e7e-a073-9451e8c847f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(7340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f83600c6-b591-4ef3-b441-8a34bd04c8ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c6f7fb5-5853-4956-b8d0-9fb15b132aff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74f1010f-9c18-4f19-8fef-ed90d2c6e2ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(7224), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b10e39fe-bd37-442c-8f0d-f1ea7e9d9651") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 657, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5868c94e-e756-4e4a-82dd-c897199e2608") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 654, DateTimeKind.Unspecified).AddTicks(1854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35a7347f-74b5-4b2e-a898-39fd5b07faca") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1e8a2e8-8409-436a-b735-ff2446159d61") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37d412e4-3dc7-402f-b69a-43359d911807") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 655, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 3, 30, 0, 0)), new Guid("950344da-77a4-4818-8446-c4f5914a1eed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abb0840c-6d56-45e1-862a-1726cb440462") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 3, 30, 0, 0)), new Guid("273aa231-1b6c-4897-bcb2-105d8f56375b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e10b7f4-2732-433e-94b6-c8a0fb3c9629") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40e5d343-1c0d-4b6d-9289-66d81a6f0409") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(9477), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd3e00f2-849a-4ff6-a5b9-8237c9fe1358") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 28, 12, 28, 34, 653, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a7345eb-94e0-4f2b-96a6-ccb04aa2a0f4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Create",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.DropColumn(
                name: "Update",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.RenameColumn(
                name: "Read",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "Display");

            migrationBuilder.RenameIndex(
                name: "IX_D_Entity_Read",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "IX_D_Entity_Display");

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
    }
}
