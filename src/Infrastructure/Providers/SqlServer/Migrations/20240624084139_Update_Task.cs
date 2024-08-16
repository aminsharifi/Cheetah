using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Update_Task : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Form_FormsId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.RenameColumn(
                name: "FormsId",
                schema: "Facts",
                table: "F_Task",
                newName: "FormId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Task_FormsId",
                schema: "Facts",
                table: "F_Task",
                newName: "IX_F_Task_FormId");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(657), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f98e6fe8-572a-4212-bff0-69c84b7ec10a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(663), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7cb19ac6-4554-4bd3-8636-7db24beaa349") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(666), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20122dbd-c444-4b4c-822a-ef5bee213bc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(668), new TimeSpan(0, 3, 30, 0, 0)), new Guid("da1e9eae-316e-4f12-a306-a4fee4153725") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3925b9f5-57ca-4e24-9e83-a7bbdb33e67f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac36ca04-20ef-441c-8655-a6be79e6d7b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 139, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f2dd17ec-bbf4-4f9d-b2bd-9b2630282682") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e970ca07-10f8-45bf-901e-7f503069fcda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05784f8e-0d24-4af4-ac55-97febf5f0c50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab1521b6-55df-47ce-83f8-325f1f11cf19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72fffbda-a3e9-4d0c-bd43-ba0f099fb80c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7b0de97-c608-419c-897f-f849c74d2327") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d7adf3d-fa13-464e-89ff-2c91adc0013c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 3, 30, 0, 0)), new Guid("034a60ce-9dc7-407f-beae-9150d92f83d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2746), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6270b787-d9d2-4b08-a3c1-0b5d62654aef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45f2b13e-d610-4bda-9ec6-81b6dbe955e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c681eaf5-2495-4627-98f2-0ca7bd98bfed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2762), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98da8040-b029-4986-b3ca-e885384d9da0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27069f83-6e5f-435a-b749-f2e5a6f9261a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1be9c7a8-85eb-48ac-8cb9-427db635dfe4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 140, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("88285beb-3863-4def-bf61-d52862054efb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4692), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ed5197a-04fe-40d2-95f2-993a2982df6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("524917c9-4ebc-4fb0-abe5-d21789a3ef9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4708), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4855e964-0827-4772-b027-e564254cea07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb84021d-bdb9-484b-a8a5-e21b60978e69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f63b46c-81eb-4f53-8399-838c230a9bdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11c444ca-45ce-4241-8947-b70cfb6c48dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 135, DateTimeKind.Unspecified).AddTicks(4373), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05c9a913-2332-48db-9301-ae7cbf0a0c34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cbc40b10-1b72-4d0b-9e83-c831221c2d27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e58e9f7-844f-41c7-89bd-0894ea3b8dbe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73f1b10b-36e4-4ea2-a9b2-07c2dc7ea897") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 3, 30, 0, 0)), new Guid("308a6790-32ec-4a24-a46f-8ce961def768") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d88d9d03-bfb8-418a-a819-8dd654ed6930") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fb1498cb-b93e-45a6-984d-3f149f53fc74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99e01891-38c3-486b-a348-1273a959287f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(9621), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78530106-f47c-4261-8aa3-08cd6c39bb34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(9632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f980385-5541-47f0-8a3d-880b995497e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(8307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef43c38f-7b09-427b-8f96-0a8ad6681dfa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(8320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af6f23ee-c4a9-4a10-b334-a5c289c1ba3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7b003d9-240f-4504-a2d0-7b95031dc563") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(8326), new TimeSpan(0, 3, 30, 0, 0)), new Guid("205daf41-a3f3-406d-a089-a1883b617349") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(4965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e0b0f073-b44e-4747-af87-11d224068ec3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edfc5104-0c8c-4781-9a25-c7d1b62bf1ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(2024), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aefcf099-8e7b-42ae-8194-80af4dbc69ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d84fa0d4-c663-4431-a514-888092d31448") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(2037), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a78ecf1-5661-41ea-a49e-bd80f0a720d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 138, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dcfd67d-aca2-4693-8a0a-73eb205510f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 136, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d9a02f9-8778-43d7-b92b-b98c972f29e0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(5419), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6e8fca7-1ab5-4689-8662-150752fbac3c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c08107bd-3ddb-4b24-8364-f3baf9a1aab1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d37ae0c1-34ad-4c45-aedb-446979876a94") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fcd0d4aa-5502-4127-af1a-36aaacf30e6b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1515f9b9-2e0a-44d3-a1ff-7b6d9a1a2ffd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 135, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8cd6799e-eec9-426f-833a-04f06c4d6cb4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef66b477-02c2-4f89-bcc1-5fac3bc3598a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 137, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c714a365-9d6d-40b4-a1d7-c5d9423ed310") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 12, 11, 38, 133, DateTimeKind.Unspecified).AddTicks(9603), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37cbc5d7-7561-43ab-bfd6-81ba8e9ebb65") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_Task_F_Form_FormId",
                schema: "Facts",
                table: "F_Task",
                column: "FormId",
                principalSchema: "Facts",
                principalTable: "F_Form",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Form_FormId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.RenameColumn(
                name: "FormId",
                schema: "Facts",
                table: "F_Task",
                newName: "FormsId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Task_FormId",
                schema: "Facts",
                table: "F_Task",
                newName: "IX_F_Task_FormsId");

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
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3829), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2264de8-209e-476a-8ba9-cd90b8bea152") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3834), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9aaaf4a6-1c97-4e6d-9a19-8f3ef7c98bab") });

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
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e0c5600c-7576-45e0-9182-8daf6475b161") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 11, 44, 44, 74, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("e7420fb3-7745-457a-b082-a6e6b80c0369") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_F_Task_F_Form_FormsId",
                schema: "Facts",
                table: "F_Task",
                column: "FormsId",
                principalSchema: "Facts",
                principalTable: "F_Form",
                principalColumn: "Id");
        }
    }
}
