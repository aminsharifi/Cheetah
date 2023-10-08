using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class serilog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2214), new Guid("54f45a6d-8da5-4161-a718-3d9e1f8db26e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2218), new Guid("3e8ff3e7-cccf-423a-8572-0cf1a8dcb020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2220), new Guid("c16d5e9b-10d3-4dc3-938c-d071db5de912") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2222), new Guid("7dc2532c-42ee-47fa-9ff0-a2c5bab88895") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2224), new Guid("4f977004-5371-436d-9327-23e73cbcfac6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2591), new Guid("91546a56-4f87-4003-8087-ff55d29d8f8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2640), new Guid("e6de87f2-bd9e-4bfd-917a-35099feed129") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2646), new Guid("e0d5f14d-fd1a-4208-ab60-4e2770f51c45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2652), new Guid("37a51bf9-c208-40ac-bda5-3baa091c139d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2658), new Guid("de09caea-a8cd-48d1-833a-611f30f037cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2663), new Guid("5fd21199-1371-400e-90ef-8e6f584d9576") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2668), new Guid("f4cae591-546e-469e-a6cb-55d8cd06402b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2673), new Guid("60109540-86de-4781-a64f-4d019015b57b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2681), new Guid("2c006af2-20f1-4855-b607-60d5bf74eb12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2686), new Guid("7005a371-2279-4840-a315-21920cdf1610") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2767), new Guid("86278405-e2e9-4d87-877e-bf2d06dc52e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2775), new Guid("2c6cb023-bb37-4307-b2dc-95183d65de9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2781), new Guid("e81adf2f-3288-4164-b0f2-5a08c49954f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2786), new Guid("dc400367-b7c1-451c-95fa-9671d8ff311d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2791), new Guid("5cf1a1ca-eeec-41d4-851e-d450433cde23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2800), new Guid("ba4d2e8a-f9b9-4889-8a49-19f53493c9aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2808), new Guid("be160f68-e9c4-47b4-918b-648c40307c69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2812), new Guid("30651f28-c713-40f5-8a77-fa05ff8a912e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2817), new Guid("aecf1c3b-0a6d-477e-aeee-eed0d139340c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2823), new Guid("20fa206d-daac-4384-91ae-dcc6755d16b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2305), new Guid("18571eec-27d8-4292-b587-287c17ab5802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2323), new Guid("068be901-acf8-47e5-9fc5-8b0bb3fc7715") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2326), new Guid("f7c1d87a-826f-43d8-9c7d-9d4526511373") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2329), new Guid("e02ed417-9126-4a97-86ae-29aea479abe3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2331), new Guid("3e4e2057-fda6-47e1-bd05-65f8869c5a3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2340), new Guid("5bdd2aac-032d-41b5-8113-b8d36cf3263f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2342), new Guid("31255e35-0c96-47b7-81db-f8df83288022") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2566), new Guid("924f7f26-6ea6-4002-9a05-a9286a052dd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(1915), new Guid("856e3d5c-c0ee-45b1-95ce-6e8faedc6d43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2521), new Guid("616c71c1-9b6d-449c-b487-647f5b043fb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2530), new Guid("419c3262-462b-4c2a-81d2-14bf076b76e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2403), new Guid("f66e94b6-87bf-4878-9953-d2950d6cf0ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2409), new Guid("1dc5ecfa-aa9b-4575-88dd-af7138bf12fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2458), new Guid("20e23279-6caa-4461-8919-363396a11988") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2461), new Guid("af8490ca-f879-4ed3-ae58-efa0024711b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2463), new Guid("8ca0e148-722f-4d58-a8e1-005a22e0fcc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2373), new Guid("3a8e8acd-f7ea-4999-8b7b-4e0f4e16a840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2375), new Guid("3f82d8af-cde7-4fd5-b1b4-8d3566f1d67a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2378), new Guid("b64069fd-4117-4c06-8bc5-4a9a3cd16d59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2380), new Guid("c87a1a43-ebcc-445a-9bf8-d421f0807d37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2492), new Guid("8e06e50e-166e-4303-b8e6-cd7c7440c048") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2496), new Guid("0082e474-a413-4e0c-b0db-6d8e8467b8cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2259), new Guid("ca879edb-9720-4e81-a3d2-4e77f6871f16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2272), new Guid("4b7adc66-b186-42a7-bee6-07adb5285244") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2275), new Guid("c2fa4b64-bfdf-4f03-9608-6695ed1789c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2277), new Guid("3f443e32-6b99-4f1c-bc80-6e8787f9cf52") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3006), new Guid("3d1e22cf-f58c-4303-8101-5f5815e4753d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3013), new Guid("ba78e33c-b7c3-4591-bc92-77e32d303e64") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3016), new Guid("c276e0c8-53d5-44e2-8f12-c424dec011f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3019), new Guid("e977ec66-627c-4b89-b8b4-a9222814f001") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3021), new Guid("68e224fc-e14d-4fdd-b5d9-4d63e1928726") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2897), new Guid("37010a00-26d3-48a7-ab7f-0fb861eeb6eb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2901), new Guid("f50f8fb7-a5f6-419d-bc25-08d06bdbe275") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2929), new Guid("3a76c8ad-0c57-4177-afbe-cd153bc9d98b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2937), new Guid("c5681637-42a6-4501-a50f-dbceabff7fb9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2939), new Guid("6aeb8245-a5f0-492b-af09-2847e2ecda6b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2941), new Guid("8727c7dc-0b62-4b97-ac4f-756cbbe3947c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2871), new Guid("54496abf-2c18-4780-bda8-4e42f1d96478") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3170), new Guid("8de1eecd-5163-4184-b076-2cf82e7561cc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3176), new Guid("63f7e25b-1ba3-499a-9f07-6ee598a04176") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3126), new Guid("e1de4067-cdbd-4dec-b58c-84afa4739c79") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3100), new Guid("2369579c-b54e-4cab-b244-ea4537b3e851") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3103), new Guid("b3ae78b2-b921-4328-ac70-5b657bb3039f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3076), new Guid("9f83e371-1996-43f3-8cce-2cc11f3447cb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3080), new Guid("5256871e-569d-40cb-b919-a3cf821e5375") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3146), new Guid("49340d70-d265-450b-9b06-d3a48ed9766d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3149), new Guid("0a1d9b02-91de-4bfa-bbbb-132ca188ca4b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1032), new Guid("b798b14a-91ec-484d-8bbf-b983aebcf154") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1036), new Guid("3115a70f-07f9-4db2-874a-352f4e4e777b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1039), new Guid("fd4ed136-af76-4567-bd73-3497800e0961") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1041), new Guid("d045ced6-10f0-43a3-a2d9-b729226cdce5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1043), new Guid("fc73f04a-be1f-48eb-ab0d-e9041389e271") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1346), new Guid("cca7a715-cdf3-4dd4-9b45-d38646286d4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1387), new Guid("37792bb8-e522-4d8d-8e2f-1fe32d4bd6f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1392), new Guid("565cdd53-e77e-47b8-8d64-2f859b2e145e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1398), new Guid("2f3cde6d-0ab4-489f-9e73-555911007ee1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1404), new Guid("3ba2be6f-36ad-45de-9fd3-d06e511ef52b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1409), new Guid("fe9fecd7-beb8-4cf4-865a-36197012903f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1414), new Guid("765e189d-4a05-4ad5-ac77-60bac957b2cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1419), new Guid("81a58c97-2452-4d4b-a271-970af5eb577a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1426), new Guid("59edb2ae-7b2d-4ca9-ae88-e6fab419f27c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1432), new Guid("ddfec978-d333-4532-9d5f-bcd500c89b2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1437), new Guid("27635f12-892a-499c-afc4-5cc048dd047c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1443), new Guid("7de3a893-5b91-4c79-803a-29bca0afd695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1510), new Guid("60de9ae7-893f-4c9b-8d48-e3e2d591bbf6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1517), new Guid("30718ba7-6750-484c-aef4-2714dabd03f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1522), new Guid("21cae9dd-0d74-4d42-9454-92240b55d4ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1527), new Guid("f17d46b3-b5f4-4cb2-bffd-2b29e9f7c5b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1535), new Guid("a7c3d5b7-b161-4060-9c73-5d0982727964") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1539), new Guid("78b096be-46ff-4188-9bab-1503b629d552") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1544), new Guid("98a19d21-a0f9-4273-802b-49f730979e80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1549), new Guid("fb63a3c0-61ac-475d-908f-5966192139e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1115), new Guid("7de1368f-7884-4850-8f83-e53ffd9f3607") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1133), new Guid("06b851f5-6dcd-4097-9db3-e657cd7dbc68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1135), new Guid("e415f958-5471-4f1c-84f8-ea056f1bd502") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1137), new Guid("8ec6d733-71dd-44a3-a1e5-b046b98ec6a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1139), new Guid("34f083a4-0271-4a2d-9c1b-8aa8748d66a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1144), new Guid("9141b028-2d92-43f2-8a0f-d41987ad6dac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1147), new Guid("bad02f44-3898-4d64-9a23-2a12c9a82b02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1324), new Guid("4460df4f-c95a-4424-a994-5d4ccd9a43db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(791), new Guid("8e5d1169-1ef7-486d-8253-fad3da87efe8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1299), new Guid("06239da4-1319-45ab-9cff-a0da92cb252e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1301), new Guid("c7f56aa3-34b3-406b-a122-51df22a0e9ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1196), new Guid("f719d776-b57d-4bd8-8ef7-1dd6769ff621") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1199), new Guid("6835f1b5-178c-4912-a3c3-8efd981eeef4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1204), new Guid("66a51afa-48da-436c-be51-bd9a67dba8a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1206), new Guid("c25e9a32-0fc3-4811-8442-fe0cc01417f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1209), new Guid("9ebdcd1f-9954-437d-bc66-9cf40ee918b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1173), new Guid("d610312a-06cf-49b5-89a3-84cb4717a79a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1175), new Guid("f214a919-663a-4532-b382-40f5412d4005") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1177), new Guid("4d7a15c6-3454-4c63-a813-dc6c3cb21030") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1179), new Guid("f6a0f4b1-4fbe-496d-8013-b2d8f313c45f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1273), new Guid("1e11f225-cb10-4594-8903-ca2b260d29a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1277), new Guid("415e1cef-ef1c-4396-adea-0eaca78e797e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1073), new Guid("f73a3204-f8dc-4712-add8-f0fd566fec13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1086), new Guid("7be40c1b-cfa3-42bb-9760-c8e07ac72bd0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1088), new Guid("ce3f017b-8533-4b19-8eeb-30bcca90c41a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1090), new Guid("150133f9-f547-46ae-97a9-c7012f093696") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1677), new Guid("78208827-83c4-4360-87f2-54b586111526") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1681), new Guid("68af3fdd-fc12-4404-92c7-2e7e4577234e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1722), new Guid("7906f267-6b8e-47a4-aa5f-d111e9901bee") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1725), new Guid("793c4acb-f2fd-4bd9-9cc5-f975055f2d40") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1729), new Guid("392c4981-e663-44ab-8600-c3e00333fe7e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1618), new Guid("c5096c49-b359-4240-8df9-59328d2a706c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1622), new Guid("6153cf16-a911-4605-915c-de2ace85ac63") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1646), new Guid("64366c93-2ba1-4124-bcea-b8cd5e6a66ef") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1653), new Guid("d4ca46c2-7f21-47ff-80d9-d1e9265157bc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1655), new Guid("fb98e747-10ec-40fb-bfce-fecc5ece4f24") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1658), new Guid("2fda22e1-e362-44da-8d0e-200d64042b92") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1591), new Guid("a741d6db-6eff-4232-ba48-95d66af224ec") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1849), new Guid("84ae310a-9780-46b0-ae39-6f1d5e727204") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1854), new Guid("e8b6a7d6-ece2-4e16-9688-e85c33333c72") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1810), new Guid("87b584ea-cc9c-4268-986b-ec2ec0912c41") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1781), new Guid("d4d7ebef-5d6c-4fd1-8a44-27cd7a53e50b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1784), new Guid("70aaf63a-3160-4d46-b1d3-44887534274b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1757), new Guid("b75a2ca4-3b58-4915-ba3d-5bfd03abe04d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1760), new Guid("94174913-9c0a-4e2f-838c-e9dbfc358520") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1828), new Guid("55e7cfc2-6fc8-43a7-b51d-d73feaed984f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 41, 2, 678, DateTimeKind.Local).AddTicks(1831), new Guid("364c0a8c-0557-4fe8-bc75-b2db87f78c8a") });
        }
    }
}
