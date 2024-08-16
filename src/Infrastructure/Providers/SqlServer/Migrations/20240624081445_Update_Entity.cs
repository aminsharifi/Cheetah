using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Update_Entity : Migration
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9746), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52ab031d-1d19-4509-97b0-7b42392663ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9758), new TimeSpan(0, 3, 30, 0, 0)), new Guid("204ec504-6bd8-405c-b401-cf1f8fefcc84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7af867d9-763d-4550-ba49-8b728c6c6d69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05460983-1ab8-49bf-a7f8-8065e3e7a678") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9766), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c31dafa6-577d-41aa-88bd-ff96a5cdb651") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(9769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2f516d6-324b-4f48-94c1-a9c2f729af48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 73, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6373f179-722e-46d0-9278-a1b571d8436c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3757), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fa0d1c3-531a-40a0-b428-53498a4275f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fc72de8-08bb-4839-ab6a-6e0d90d581f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3799), new TimeSpan(0, 3, 30, 0, 0)), new Guid("748c5b21-6cb4-4ff9-b46b-b8ac06925ea4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5397dfe3-5011-474e-9c29-c8fed1e9e841") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d551e4a-dffe-42c2-bd82-6d125ad42620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3829), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("a2264de8-209e-476a-8ba9-cd90b8bea152") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3834), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("9aaaf4a6-1c97-4e6d-9a19-8f3ef7c98bab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3840), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4cad8201-4788-41fc-ae30-65e75bc0a81c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3845), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b11b47b7-662b-46c0-96e9-245103d8a4f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8db3f12-fa1d-42ce-8d3b-38b455e1bd06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3856), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d17281d5-e661-4263-9683-cdb6356aab2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3861), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bc4ace4-21b1-45b3-99ba-f14cef2db9da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("e0c5600c-7576-45e0-9182-8daf6475b161") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex", "Sync" },
                values: new object[] { 115L, new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), true, "فرم‌ها(Facts)", 115L, true, new Guid("e7420fb3-7745-457a-b082-a6e6b80c0369"), null, "F_Form", 115L, true });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37abf9db-ee0c-433d-90ae-14d4d39c2dea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45172b09-5de7-4ff5-b7e1-57c8d35dab96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a152f0d6-ee05-4db0-a4d2-666fb4483b4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e92e1a00-01ce-4753-a656-15a30b8bf9f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ca11bb7-39d9-46fc-9a74-b20a1f62a3f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 3, 30, 0, 0)), new Guid("297a23c8-15a9-48e3-ba4b-043261c58a7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 69, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43855e71-2a31-4013-b497-17d6ec7ab11d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(5397), new TimeSpan(0, 3, 30, 0, 0)), new Guid("76230996-0e8d-4eab-aefc-08a9a462a1d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, 3, 30, 0, 0)), new Guid("448465b6-0c44-453c-acb7-c57b7283b2a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44b49fd3-af71-41f0-b4d6-85f0fed7544f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 3, 30, 0, 0)), new Guid("008c3c35-72a6-4a7e-ad67-06977a1fa6e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9328), new TimeSpan(0, 3, 30, 0, 0)), new Guid("505d4170-17ec-4b8a-9c46-9b0bb9f46870") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e37e208-467e-4173-bb09-6d5be5e0804c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(9341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3d19034-72ee-403e-8c16-259ff6bc5aa7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37f2a6f6-32fb-4854-8f19-6e58a55ae86e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfccb236-c6c8-42cb-94a0-f25b850ac567") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0564d0f-d89e-4996-8c61-dba22e09a114") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(7199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cac8aa87-19ce-404a-92f3-ee34058a14ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(7203), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99dd6cb9-d9eb-4dae-9b87-c2ab9d323dd5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b95484ff-a1c4-436b-8527-83366299c8ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(4354), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f8cafd1-0af1-4454-bf07-7d59cfbbef7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08b01d4a-9be1-41cf-a1a6-5fec51d97f0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(1071), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6194cd57-959c-4569-b5a5-fa80647cefb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63dc15ef-a250-4a34-8308-70ce404d9511") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(1083), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c9cbd76-43c8-4012-b7ef-7abedb69140b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 72, DateTimeKind.Unspecified).AddTicks(1085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b88842b8-d52f-4e61-93ae-d925225d8c8c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 70, DateTimeKind.Unspecified).AddTicks(613), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4157b80c-d8ad-463b-9c44-97307f008305") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c9e45ef-6afb-4890-a4b7-683f0fadea87") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a55f3fc5-ed14-4074-ac6b-ecde4965fa88") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86aa914b-3e5a-44e4-8ec0-132a7abb6e41") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1ad580e-041a-41d8-ac87-7fb184d35361") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(5572), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0fdd09e-63b9-4a85-aad0-eaeeccc62e8e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 69, DateTimeKind.Unspecified).AddTicks(5028), new TimeSpan(0, 3, 30, 0, 0)), new Guid("89704ceb-3de6-4cf4-8fe1-63d62f0cf98e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12c56007-99a6-4bd3-86c2-8e0e2b8cf3e6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 71, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c26eba33-8390-44a1-aa8c-8f8b8c9d7fdc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 67, DateTimeKind.Unspecified).AddTicks(6523), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbc296da-4fd5-4698-b312-2548997f4bbf") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a4fabd2-e6e4-4aeb-8e34-3a2d9f803004") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c45a085-a3a6-42cc-a419-db8e39d7e1b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5413233e-b93d-48fc-90ae-f9ea67ab0cf8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aaa3bd60-997f-47b3-94b2-e179a4d17cda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70dd8a98-bd8c-405d-a0fb-3f387921e661") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3997aba5-3fd9-4bb4-9489-296260906e92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc5d6706-5bc2-41f9-a3ba-e5d90c3328ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8384), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c371442-b482-4726-8483-b6b88de32256") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af5cacde-354b-4551-9fa0-83cef56dd828") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fba2ae7d-2a22-48a7-afd6-5f4d391dbd19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8431), new TimeSpan(0, 3, 30, 0, 0)), new Guid("610efc5d-15e3-4af0-8d8b-b33b1a1a82de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a9916d2-d536-4a1a-b1dc-54dd118e4079") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("e783b856-e27c-4869-80c0-5c4117fce7bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("fed079b6-6242-45ea-a61f-874b8e216d1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8464), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cdb9ef4-f995-4aab-8737-9dd27ebce720") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 3, 30, 0, 0)), new Guid("986e3e71-8800-481d-8a6f-735cf0e45ef5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72b37075-3734-4c12-81b8-f49d46ffe396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a4d089b-9d50-4271-a5bb-87a6c5b06d47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6060ff53-ded8-4687-8e04-1e9d75f64624") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 780, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("65f891c6-73de-4c6c-a20a-0490eba2911f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c746247f-6b6c-48f9-abef-e69e6cf45f87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58cb509e-f175-49b7-b15b-e7aca666f727") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65452e0d-12e2-4cf6-81df-0ce02a00f517") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 3, 30, 0, 0)), new Guid("547030cc-f6b3-437b-a7a4-5019df2d3e56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(142), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4fceba9-57d6-4550-a2b6-fdb145881af5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(145), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5fa4573c-da10-4b5d-aef7-d1e56d08aaeb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 775, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 30, 0, 0)), new Guid("243290fa-c7e0-433e-bed8-4f800323c020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59e3e968-dfcd-4059-8ad1-ee73c6bc5024") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed3a1002-a47a-4076-b83c-25203b14f162") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6421f3e8-1814-4f9f-a5bc-ba6297101862") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d41c5ce-7fcb-486a-a762-442ffc6eedb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6a9bb5f8-4fc2-4101-85ef-209b85bbefac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a1ee0e2-7b63-4a87-b49b-9779c665ed05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(6113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03b73076-e20c-41da-b5b2-a8b6e091c09f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(5062), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40b074b4-4002-4d94-90b0-5e6a089be9a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8afe500-f109-482b-9766-d0d0a0afdc9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4d0671e-8562-41d8-8038-fd4080eb9305") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3798), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8055b522-3e1d-49e5-bc9d-62a32bfd850d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45a5a001-604f-4a93-9a61-336ec799c2ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 777, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e5c0ed4-a9fe-4990-87d3-e0b0c0cc9c76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56271a52-4649-4826-bf8f-61e437bf603f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 779, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af61f573-916f-41c1-b8a5-a7885b8a9758") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8fe44cc9-d5e8-449a-beee-0580c7444500") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 3, 30, 0, 0)), new Guid("978df255-eee4-4ada-b30a-6920b7fd7a1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("082f80dc-c9fd-4671-b9d1-7606bc181bc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2caabb72-a13e-4ab7-ad08-d103ad5d57ca") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 776, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3838265c-365a-4c96-a2e6-2a71701d28df") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b6b82f1-1768-41ca-abf9-4133733a22cb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e67fef1-68de-466f-a028-993ebe4530d9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d64e59e7-bd25-42b3-bb72-19bffa2535f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f2bcdc05-292f-4e04-a557-81b62664410b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30c35661-98fb-44fe-972f-feb86f18d03b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 776, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d10b0c9d-1020-4fd1-960b-a27353a8e022") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0098ca01-c103-424d-9c23-4a569abd4698") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 778, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65f338a1-ba20-4356-a9ee-8b6e86f6a3b2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 35, 23, 774, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a52ecf22-c736-428b-86cc-ba210632d8c6") });
        }
    }
}
